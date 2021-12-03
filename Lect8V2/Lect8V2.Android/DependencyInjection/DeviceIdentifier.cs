using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Lect8V2.DependencyInjection;
using Lect8V2.Droid.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

[assembly: Dependency(typeof(DeviceIdentifier))]
namespace Lect8V2.Droid.DependencyInjection
{
    public class DeviceIdentifier : IDeviceIdentifier
    {
        public Task<string> GetDeviceId()
        {
            return Task.FromResult(Android.Provider.Settings.Secure.GetString(Android.App.Application.Context.ContentResolver, Android.Provider.Settings.Secure.AndroidId));
        }
    }
}