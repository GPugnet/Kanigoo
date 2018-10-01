using Gpusoft.Kanigoo.Core;
using Gpusoft.Kanigoo.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Gpusoft.Kanigoo
{
    public sealed class Updater : IUpdater
    {
        private readonly List<IUpdateProvider> updateProviders;

        private IEnumerable<Channel> channels;

        static IUpdater updater = DummyUpdater.Instance;


        /// <summary>
        /// The globally-shared updater.
        /// </summary>
        /// <exception cref="ArgumentNullException"></exception>
        public static IUpdater Instance
        {
            get { return updater; }
            set
            {
                updater = value ?? throw new ArgumentNullException(nameof(value));
            }
        }

        internal Updater(List<IUpdateProvider> updateProviders)
        {
            this.updateProviders = updateProviders;
        }

        public async Task<IEnumerable<Channel>> ListChannelsAsync()
        {
            channels = await updateProviders.SelectManyAsync(p => p.GetChannelsAsync());
            return channels;
        }
        
        public async Task<IEnumerable<Version>> CheckForUpdateAsync(Channel channel, Version currentVersion)
        {
            return await updateProviders.SelectManyAsync(p => p.GetUpdateVersionsAsync(channel, currentVersion));
        }

        public Task<Channel> GetEnrolledInChannelAsync()
        {
            throw new NotImplementedException();
        }

        public Task EnrollAsync(Channel channel)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync()
        {
            throw new NotImplementedException();
        }
    }
}