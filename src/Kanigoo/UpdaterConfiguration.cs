using Gpusoft.Kanigoo.Core;
using System.Collections.Generic;

namespace Gpusoft.Kanigoo
{
    public class UpdaterConfiguration
    {
        readonly List<IUpdateProvider> updateProviders = new List<IUpdateProvider>();

        public UpdaterConfiguration()
        {
            UpdateFrom = new UpdaterSourceConfiguration(this, u => updateProviders.Add(u), ApplyInheritedConfiguration);
        }

        public Updater CreateUpdater()
        {
            return new Updater(updateProviders);
        }

        void ApplyInheritedConfiguration(UpdaterConfiguration child)
        {
        }

        /// <summary>
        /// Configures the sources that provide the updates.
        /// </summary>
        public UpdaterSourceConfiguration UpdateFrom { get; internal set; }
    }
}
