using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace EasyPolls.Controllers
{

    /*
     IDEA:
     Somebody Creates the poll and gets ID back
      -- Poll Creation API

     Poll Owner (Who nows the Id) can Publish it or remove
     -- Poll Publish API

     Poll Types 
     - Public (Visible for All API users)

     - Accesible by token (Generate token)

     - Private (shared to specific Audience)

        Service does not contain Identity (investigate)
    
     */
    [Route("api/[controller]")]
    [ApiController]
    public class PollsController : ControllerBase
    {
        private readonly IMediator mediatr;

        public PollsController(IMediator mediatr)
        {
            this.mediatr = mediatr;
        }
        // GET api/values
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok();
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
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
