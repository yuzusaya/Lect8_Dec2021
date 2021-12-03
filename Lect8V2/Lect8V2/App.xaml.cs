using Lect8V2.Services;
using Lect8V2.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lect8V2
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();
            DependencyService.Register<IAccountService, AccountService>();
            MainPage = new DataValidationPage();
            //MainPage = new DataValidationPage2();
            //MainPage = new CustomRenderDemoPage();
            //MainPage = new DependencyServiceDemoPage();
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
