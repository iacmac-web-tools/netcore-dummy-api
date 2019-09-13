using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dummy_api.DataClasses;
using Microsoft.AspNetCore.Mvc;

namespace dummy_api.Controllers
{
    [Route("api/values")]
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
        public string Post([FromBody] string value)
        {
            return value;
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public string Put(int id, [FromBody] string value)
        {
            return $"{id}:{value}";
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

          [HttpPost("check_test")]
        public async Task<IActionResult> PostCheckUserAsync([FromBody] LoginResource model)
        {
            try
            {
                var res = await GetCustomer(model);
                
                return Ok(res);
            }
            catch (Exception ex)
            {
                return BadRequest(new ErrorExceptionResource(ex));
            }
        }

         private Task<string> GetCustomer(LoginResource model)
        {
            var str = $"Surrogate check:{model.Email}-{model.Password}";

            return Task.FromResult<string>(str);
        }
    }
}
