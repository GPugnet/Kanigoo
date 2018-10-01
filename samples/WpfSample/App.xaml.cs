using Gpusoft.Kanigoo;
using Gpusoft.Kanigoo.UpdateSource.Http;
using Microsoft.Identity.Client;
using System.Windows;

namespace WpfSample
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        //Below is the clientId of your app registration. 
        //You have to replace the below with the Application Id for your app registration
        private static string ClientId = "e4281539-934f-461e-becf-8292d24bab2e";

        public static PublicClientApplication PublicClientApp = new PublicClientApplication(ClientId);
        protected override void OnStartup(StartupEventArgs e)
        {


            Updater.Instance = new UpdaterConfiguration()
                 .UpdateFrom.Http(new System.Uri("https://localhost:44369"))//"https://kanigoo.azurewebsites.net"))
                 .CreateUpdater();


            base.OnStartup(e);
        }
    }
}
