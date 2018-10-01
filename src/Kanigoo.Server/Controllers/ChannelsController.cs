using Gpusoft.Kanigoo.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Kanigoo.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChannelsController : ControllerBase
    {
        // GET: api/Channels
        [HttpGet(Name = "ListChannels")]
        public IEnumerable<Channel> Get()
        {
            return new Channel[] {
                new Channel
                {
                    Id = Guid.NewGuid(),
                    Name = "Channel A"
                },
                new Channel
                {
                    Id = Guid.NewGuid(),
                    Name = "Channel B"
                }
            };
        }

        // GET: api/Channels/0119ad7a-8d5a-43f3-9e57-612324b3d0bc/Updates
        [HttpGet("{channelId}/updates", Name = "ListUpdates")]
        public IEnumerable<Version> Get(string channelId)
        {
            var version = new Version();
            return new Version[] {
            new Version(version.Major,version.Minor,version.Build,version.Revision + 1)
            };
        }
        
        // GET: api/Channels/0119ad7a-8d5a-43f3-9e57-612324b3d0bc/Updates/1.0.0.0
        [HttpGet("{channelId}/updates/{currentVersion}", Name = "ListUpdatesForASpecificVersion")]
        public IEnumerable<Version> Get(string channelId, string currentVersion)
        {
            var version = new Version(currentVersion);
            return new Version[] {
            new Version(version.Major,version.Minor,version.Build,version.Revision + 1)
            };
        }

        //// POST: api/Channels
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT: api/Channels/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE: api/ApiWithActions/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
