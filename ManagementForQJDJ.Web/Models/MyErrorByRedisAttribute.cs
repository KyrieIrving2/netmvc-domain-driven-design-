using ServiceStack.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ManagementForQJDJ.Web.Models
{
    public class MyErrorByRedisAttribute : HandleErrorAttribute
    {
        public static IRedisClientsManager clientsManager = new PooledRedisClientManager(new string[] { "127.0.0.1:6379" });
        public static IRedisClient redisClient = clientsManager.GetClient();

        public override void OnException(ExceptionContext filterContext)
        {
            redisClient.EnqueueItemOnList("errorMsg", filterContext.Exception.ToString());
            base.OnException(filterContext);
        }
    }
}