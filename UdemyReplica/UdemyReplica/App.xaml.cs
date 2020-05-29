using System;
using UdemyReplica.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UdemyReplica
{
    public partial class App : Application
    {
        public App()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MjIzODM1QDMxMzcyZTM0MmUzMFhZZktBMU41MWVGTnJMVEhuSEh0aWN3SlJJQ21qcTQ2Ri9iVVpCVXRvSUU9");

            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
