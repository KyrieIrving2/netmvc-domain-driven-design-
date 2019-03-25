using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ManagementForQJDJ.Web.Controllers
{
    public class ApitestController : ApiController
    {
        // Set mock data
        List<string> mockDataList = new List<string>()
       {
           "Product A","Product B","Product C","Product D","Product E"
       };

        // GET api/values
        public IEnumerable<string> Get()
        {
            return mockDataList;
        }

        // GET api/values/5
        public string Get(int id)
        {
            return mockDataList[id];
        }

        // POST api/values
        public IEnumerable<string> Post([FromBody]string value)
        {
            mockDataList.Add(value);
            return mockDataList;
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
            mockDataList[id] = value;
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
            mockDataList.RemoveAt(id);
        }
    }
}
