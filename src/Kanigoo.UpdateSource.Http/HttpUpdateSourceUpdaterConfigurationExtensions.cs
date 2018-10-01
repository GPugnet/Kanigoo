using Gpusoft.Kanigoo.Core;
using System;

namespace Gpusoft.Kanigoo.UpdateSource.Http
{
    /// <summary>
    /// Adds the WriteTo.Console() extension method to <see cref="LoggerConfiguration"/>.
    /// </summary>
    public static class HttpUpdateSourceUpdaterConfigurationExtensions
    {
        public static UpdaterConfiguration Http(this UpdaterSourceConfiguration updaterSourceConfiguration, Uri uri)
        {
            if (updaterSourceConfiguration == null) throw new ArgumentNullException(nameof(updaterSourceConfiguration));
            if (uri == null) throw new ArgumentNullException(nameof(uri));

            return updaterSourceConfiguration.AddUpdateProvider(new HttpSource(uri));
        }
    }
}
