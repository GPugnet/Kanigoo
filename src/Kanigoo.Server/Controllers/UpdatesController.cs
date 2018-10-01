//using Microsoft.AspNetCore.Mvc;
//using System;
//using System.Collections.Generic;
//using System.Threading.Channels;

//namespace Kanigoo.Server.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class UpdatesController : ControllerBase
//    {
//        // GET: api/Updates
//        [HttpGet("{channelId/}")]
//        public IEnumerable<Version> Get(Channel channel, Version version)
//        {
//            // fake update
//            var fakeUpdate = new Version(version.Major, version.Minor, version.Build, version.Revision + 1);
//            return new Version[] { fakeUpdate };
//        }

//        // GET: api/Updates/5
//        [HttpGet("{id}", Name = "Get")]
//        public string Get(int id)
//        {
//            return "value";
//        }

//        // POST: api/Updates
//        [HttpPost]
//        public void Post([FromBody] string value)
//        {
//        }

//        // PUT: api/Updates/5
//        [HttpPut("{id}")]
//        public void Put(int id, [FromBody] string value)
//        {
//        }

//        // DELETE: api/ApiWithActions/5
//        [HttpDelete("{id}")]
//        public void Delete(int id)
//        {
//        }
//    }
//}
