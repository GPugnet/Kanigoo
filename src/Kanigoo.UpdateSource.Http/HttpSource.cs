using Gpusoft.Kanigoo.Core;
using Gpusoft.Kanigoo.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Gpusoft.Kanigoo.UpdateSource.Http
{
    public class HttpSource : IUpdateProvider, IDisposable
    {
        private const string getChannelsPath = "api/channels";
        private const string getUpdatesPath = "api/channels/{0}/updates/{1}";

        private HttpClient client = new HttpClient();

        public HttpSource(Uri uri)
        {
            client.BaseAddress = uri;
        }

        public async Task<IEnumerable<Channel>> GetChannelsAsync()
        {
            try
            {
                var response = await client.GetStringAsync(getChannelsPath);
                return JsonConvert.DeserializeObject<IEnumerable<Channel>>(response);
            }
            catch (HttpRequestException e)
            {
                throw;
            }
        }

        public async Task<IEnumerable<Version>> GetUpdateVersionsAsync(Channel channel, Version currentVersion)
        {
            try
            {
                var response = await client.GetStringAsync(string.Format(getUpdatesPath,channel.Id, currentVersion));
                return JsonConvert.DeserializeObject<IEnumerable<Version>>(response);
            }
            catch (HttpRequestException e)
            {
                throw;
            }
        }


        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    client.Dispose();
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
        }
        #endregion
    }
}
