using Gpusoft.Kanigoo;
using Gpusoft.Kanigoo.UpdateSource.Http;
using System.Threading.Tasks;

namespace SandboxApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Updater.Instance = new UpdaterConfiguration()
                .UpdateFrom.Http(new System.Uri("https://kanigoo.azurewebsites.net"))
                .CreateUpdater();

            var channels = await Updater.Instance.ListChannelsAsync();
            //var enrolled = await Updater.Instance.GetEnrolledInChannelAsync();
            //Channel channel = null;
            //var result = await Updater.Instance.EnrollAsync(channel);
            //var a = await Updater.Instance.CheckForUpdateAsync();
            //var b = await Updater.Instance.UpdateAsync();




            //            Channel channel;
            //IEnumerable<Version> a =            await Updater.Instance.ListUpdatesAsync(channel);
        }
    }
}
