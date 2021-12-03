using Foundation;
using Lect8V2.DependencyInjection;
using Lect8V2.iOS.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIKit;
using Xamarin.Forms;

[assembly: Dependency(typeof(DeviceIdentifier))]
namespace Lect8V2.iOS.DependencyInjection
{
    public class DeviceIdentifier : IDeviceIdentifier
    {
        public Task<string> GetDeviceId()
        {
            return Task.FromResult(UIDevice.CurrentDevice.IdentifierForVendor.ToString());
        }
    }
}