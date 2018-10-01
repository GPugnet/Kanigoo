using Gpusoft.Kanigoo.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Gpusoft.Kanigoo.Core
{
    public interface IUpdateProvider
    {
        Task<IEnumerable<Channel>> GetChannelsAsync();

        Task<IEnumerable<Version>> GetUpdateVersionsAsync(Channel channel, Version currentVersion);
    }
}
