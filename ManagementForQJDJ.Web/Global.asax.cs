using log4net;
using ManagementForQJDJ.Web.Models;
using QJDJ.Common.Action.Log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace ManagementForQJDJ.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            //redis写日志
            RedisWriteToFile();
        }

        private void RedisWriteToFile()
        {
            log4net.Config.XmlConfigurator.Configure(); //获取Log4Net配置信息  
            ThreadPool.QueueUserWorkItem(o =>
            {
                while (true)
                {
                    if (MyErrorByRedisAttribute.redisClient.GetListCount("errorMsg") > 0|| Log4netHelper.redisClient.GetListCount("writeMsg") >0)
                    {
                        string errorMsg = MyErrorByRedisAttribute.redisClient.DequeueItemFromList("errorMsg");
                        string writeMsg = MyErrorByRedisAttribute.redisClient.DequeueItemFromList("writeMsg");
                        if (!string.IsNullOrEmpty(errorMsg)|| !string.IsNullOrEmpty(writeMsg))
                        {
                            if (!string.IsNullOrEmpty(errorMsg))
                            {
                                ILog logger = LogManager.GetLogger("testError");
                                logger.Error(errorMsg); //将异常信息写入Log4Net中  
                            }
                            else
                            {
                                ILog logger = LogManager.GetLogger("writeMsg");
                                logger.Error(writeMsg); //将异常信息写入Log4Net中  
                            }  
                        }
                        else
                        {
                            Thread.Sleep(1000);
                        }
                    }
                    else
                    {
                        Thread.Sleep(1000);
                    }
                }
            });

        }
    }


}
