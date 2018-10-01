using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Gpusoft.Kanigoo.Entities;

namespace Gpusoft.Kanigoo.Core
{
    public class DummyUpdater : IUpdater
    {
        public static readonly IUpdater Instance = new DummyUpdater();

        public Task EnrollAsync(Channel channel)
        {
            throw new NotImplementedException();
        }

        public Task<Channel> GetEnrolledInChannelAsync()
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Channel>> ListChannelsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Version>> CheckForUpdateAsync(Channel channel, Version currentVersion)
        {
            throw new NotImplementedException();
        }
    }
}
