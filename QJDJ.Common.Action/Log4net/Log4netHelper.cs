using ServiceStack.Redis;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

[assembly: log4net.Config.XmlConfigurator(Watch = true)]
namespace QJDJ.Common.Action.Log4net
{
    /// <summary>
    /// 设计思路：用一个临时队列来存放这些日志信息；再启用一个Task任务把队列的日志批量存放到.log文件里。
    /// </summary>
    public class Log4netHelper
    {

        #region 普通队列
        static ConcurrentQueue<Tuple<string, string>> logQueue = new ConcurrentQueue<Tuple<string, string>>();
        static AutoResetEvent pause = new AutoResetEvent(false);
        static Task writeTask = default(Task);

        static Log4netHelper()
        {
            writeTask = new Task((object obj) =>
            {
                while (true)
                {
                    pause.WaitOne(1000, true);
                    List<string[]> temp = new List<string[]>();
                    foreach (var logItem in logQueue)
                    {
                        string logPath = logItem.Item1;
                        string logMergeContent = String.Concat(logItem.Item2, Environment.NewLine, "-----------------------------------------------------------", Environment.NewLine);
                        string[] logArr = temp.FirstOrDefault(d => d[0].Equals(logPath));
                        if (logArr != null)
                        {
                            logArr[1] = string.Concat(logArr[1], logMergeContent);
                        }
                        else
                        {
                            logArr = new string[] { logPath, logMergeContent };
                            temp.Add(logArr);
                        }
                        Tuple<string, string> val = default(Tuple<string, string>);
                        logQueue.TryDequeue(out val);
                    }
                    foreach (string[] item in temp)
                    {
                        WriteLogs(item[0], item[1]);
                    }
                }
            }
            , null
            , TaskCreationOptions.LongRunning);
            writeTask.Start();
        }

        /// <summary>
        /// 外部调用
        /// </summary>
        /// <param name="preFile">日志详细位置</param>
        /// <param name="infoData">日志内容</param>
        public static void WriteLog(String preFile, String infoData)
        {
            logQueue.Enqueue(new Tuple<string, string>(preFile, infoData));
        }

        /// <summary>
        /// 队列内部调用
        /// </summary>
        /// <param name="type">错误位置</param>
        /// <param name="msg">异常信息</param>
        public static void WriteLogs(string type, string msg)
        {
            log4net.ILog log = log4net.LogManager.GetLogger(type);
            log.Error(msg);
        }
        #endregion

        #region redis队列
        public static IRedisClientsManager clientsManager = new PooledRedisClientManager(new string[] { "127.0.0.1:6379" });
        public static IRedisClient redisClient = clientsManager.GetClient();
        public static void WriteLogsByRedis(string type, string msg)
        {
            redisClient.EnqueueItemOnList("writeMsg", msg);
        }
        #endregion
    }
}
