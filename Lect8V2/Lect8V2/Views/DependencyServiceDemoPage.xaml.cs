using Lect8V2.DependencyInjection;
using Lect8V2.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lect8V2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DependencyServiceDemoPage : ContentPage
    {
        private IAccountService _accountService => DependencyService.Get<IAccountService>();
        public DependencyServiceDemoPage()
        {
            InitializeComponent();
            Task.Run(async () =>
            {
                var deviceId = await DependencyService.Get<IDeviceIdentifier>().GetDeviceId();
                var userDetail = await _accountService.GetUserDetailAsync();
            });
        }
    }
}