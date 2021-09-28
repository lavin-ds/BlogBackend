using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Api.Proj.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BlogController : ControllerBase
    {
        private readonly ILogger<BlogController> _logger;

        public BlogController(ILogger<BlogController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<BlogPost> Get()
        {
            throw new NotImplementedException();
        }

        [HttpGet("{id}")]
        public BlogPost Get(int id)
        {
            throw new NotImplementedException();
        }
        
        [HttpPost]
        public void Post([FromBody] BlogPost blogPost)
        {
            throw new NotImplementedException();
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] BlogPost blogPost)
        {
            throw new NotImplementedException();
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {   
            throw new NotImplementedException();
        }
    }
}