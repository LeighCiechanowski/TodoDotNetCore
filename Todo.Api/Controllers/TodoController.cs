using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Todo.Api.Services;

namespace Todo.Api.Controllers
{
    [Route("api/[controller]")]
    public class TodoController : Controller
    {
        readonly ITodoItemsService service;

        public TodoController(ITodoItemsService service)
        {
            this.service = service;
        }
       
        [HttpGet]
        public IActionResult Get()
        {
            var todos = service.GetAll();
            if (!todos.Any())
            {
                return new NotFoundResult();
            }
            else
            {
                return new ObjectResult(todos);
            }
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
