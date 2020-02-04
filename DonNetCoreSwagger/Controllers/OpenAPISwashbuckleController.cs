using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DotNetCoreSwagger.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OpenAPISwashbuckle : ControllerBase
    {
        //the class Listify was created as part of a technical evaluation for a job application.
        //it is presented here through the Swashbuckle UI.
        // GET api/OpenAPISwashbuckle
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            string[] oReturnString = new string[200];
            IEnumerator oEnum = new Listify(100, 200).GetEnumerator();
            int i = 0;
            while (oEnum.MoveNext())
            {
                oReturnString[i] = oEnum.Current.ToString();
                i++;
            }
            return oReturnString;
        }

        // GET api/OpenAPISwashbuckle/start/length
        [HttpGet]
        [Route("api/OpenAPISwashbuckle/{start}/{length}")]
        public ActionResult<IEnumerable<string>> Get(int start, int length)
        {
            string[] oReturnString = new string[length];
            IEnumerator oEnum = new Listify(start, length).GetEnumerator();
            int i = 0;
            while (oEnum.MoveNext())
            {
                oReturnString[i] = oEnum.Current.ToString();
                i++;
            }
            return oReturnString;
        }

        // GET api/OpenAPISwashbuckle/start/length/id
        [HttpGet]
        [Route("api/OpenAPISwashbuckle/{start}/{length}/{id}")]
        public string Get(int start, int length, int id)
        {
            string[] oReturnString = new string[length];
            return new Listify(start, length)[id].ToString();
        }

        //The below POST, PUT, and DELETE calls have little value for the purpose of this demo.
        //They have been left as comments for use in a future project
        // POST api/OpenAPISwashbuckle
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        // PUT api/OpenAPISwashbuckle/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        // DELETE api/OpenAPISwashbuckle/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
