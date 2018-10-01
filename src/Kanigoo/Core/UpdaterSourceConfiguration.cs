using System;

namespace Gpusoft.Kanigoo.Core
{
    public class UpdaterSourceConfiguration
    {
        readonly UpdaterConfiguration updaterConfiguration;
        readonly Action<IUpdateProvider> addUpdateProvider;
        readonly Action<UpdaterConfiguration> applyInheritedConfiguration;

        internal UpdaterSourceConfiguration(UpdaterConfiguration updaterConfiguration, Action<IUpdateProvider> addUpdateProvider, Action<UpdaterConfiguration> applyInheritedConfiguration)
        {
            this.updaterConfiguration = updaterConfiguration ?? throw new ArgumentNullException(nameof(updaterConfiguration));
            this.addUpdateProvider = addUpdateProvider ?? throw new ArgumentNullException(nameof(addUpdateProvider));
            this.applyInheritedConfiguration = applyInheritedConfiguration ?? throw new ArgumentNullException(nameof(applyInheritedConfiguration));
        }


        public UpdaterConfiguration AddUpdateProvider(IUpdateProvider updateProvider)
        {
            addUpdateProvider(updateProvider);
            return updaterConfiguration;
        }
    }
}
