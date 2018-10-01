using Gpusoft.Kanigoo.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Gpusoft.Kanigoo.Core
{
    public interface IUpdater
    {
        Task<IEnumerable<Channel>> ListChannelsAsync();
        Task<Channel> GetEnrolledInChannelAsync();
        Task EnrollAsync(Channel channel);
        Task<IEnumerable<Version>> CheckForUpdateAsync(Channel channel, Version currentVersion);
        Task UpdateAsync();
    }
}
