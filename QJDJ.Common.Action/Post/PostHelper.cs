using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace QJDJ.Common.Action.Post
{
    public class PostHelper
    {
        /// <summary>
        /// 无传参的post请求
        /// </summary>
        /// <param name="url">请求地址</param>
        /// <returns></returns>
        public string Post(string url)
        {
            string result = "";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "Post";

            //获取请求响应
            HttpWebResponse httpWebResponse = (HttpWebResponse)request.GetResponse();
            Stream stream = httpWebResponse.GetResponseStream();
            using (StreamReader reader = new StreamReader(stream, Encoding.UTF8))
            {
                result = reader.ReadToEnd();
            }
            return result;
        }

        /// <summary>
        /// 带请求参数的post请求，并且请求参数是字符串类型的
        /// </summary>
        /// <param name="url">请求地址</param>
        /// <param name="content">请求参数</param>
        /// <returns></returns>
        public string Post(string url, string content)
        {
            string result = "";
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            httpWebRequest.Method = "Post";
            httpWebRequest.ContentType = "application/x-www-form-urlencoded";
            byte[] data = Encoding.UTF8.GetBytes(content);
            httpWebRequest.ContentLength = data.Length;
            //写入请求数据
            using (Stream stream = httpWebRequest.GetRequestStream())
            {
                stream.Write(data, 0, data.Length);
                stream.Close();
            }

            //获取请求响应
            HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            Stream rep_stream = httpWebResponse.GetResponseStream();
            using (StreamReader reader=new StreamReader(rep_stream, Encoding.UTF8))
            {
                result=reader.ReadToEnd();
            }
            return result;
        }

        /// <summary>
        /// 带请求参数post请求，并且请求参数为字典类型
        /// </summary>
        /// <param name="url">请求地址</param>
        /// <param name="dic">请求参数</param>
        /// <returns></returns>
        public string Post(string url,Dictionary<string,string> dic)
        {
            string result = "";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "Post";
            request.ContentType= "application/x-www-form-urlencoded";

            StringBuilder builder = new StringBuilder();
            int i = 0;
            foreach (var item in dic)
            {
                if(i==0)
                {
                    builder.AppendFormat("{0}={1}", item.Key, item.Value);
                }
                else
                {
                    builder.AppendFormat("&{0}={1}", item.Key, item.Value);
                }
                i++;
            }
            byte[] data = Encoding.UTF8.GetBytes(builder.ToString());
            request.ContentLength = data.Length;

            using (Stream req_stream = request.GetRequestStream())
            {
                req_stream.Write(data,0,data.Length);
                req_stream.Close();
            }

            HttpWebResponse response= (HttpWebResponse)request.GetResponse();
            Stream res_stream = response.GetResponseStream();
            using (StreamReader reader = new StreamReader(res_stream, Encoding.UTF8))
            {
                result = reader.ReadToEnd();
            }
            return result;
        }

        /// <summary>
        /// 无参get请求
        /// </summary>
        /// <param name="url">请求地址</param>
        /// <returns></returns>
        public string Get(string url)
        {
            string result = "";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "Get";
            HttpWebResponse response= (HttpWebResponse)request.GetResponse();
            Stream rep_stream = response.GetResponseStream();
            using (StreamReader reader = new StreamReader(rep_stream,Encoding.UTF8))
            {
                result = reader.ReadToEnd();
            }
            return result;
        }

        /// <summary>
        /// 带参get请求
        /// </summary>
        /// <param name="url">请求地址</param>
        /// <param name="dic">请求参数</param>
        /// <returns></returns>
        public string Get(string url,Dictionary<string,string> dic)
        {
            string result = "";
            StringBuilder builder = new StringBuilder();
            builder.Append(url + "?");
            int i = 0;
            foreach (var item in dic)
            {
                if (i == 0)
                {
                    builder.AppendFormat("{0}={1}", item.Key, item.Value);
                }
                else
                {
                    builder.AppendFormat("&{0}={1}", item.Key, item.Value);
                }
                i++;
            }
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(builder.ToString());
            request.Method = "Get";
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream rep_stream = response.GetResponseStream();
            using (StreamReader reader = new StreamReader(rep_stream,Encoding.UTF8))
            {
                result=reader.ReadToEnd();
            }
            return result;
        }
    }
}
