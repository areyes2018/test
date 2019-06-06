using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevOpsBP.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevOpsBP.Controllers
{
    [Route("DevOps")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public ActionResult<string> Post([FromBody] MessageSend messageSend)
	    {
            return "Hello " + messageSend.to + " your message will be send ";
	    }


    // PUT api/values/5
    [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }

}
