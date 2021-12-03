using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Lect8V2.DependencyInjection
{
    public interface IDeviceIdentifier
    {
        Task<string> GetDeviceId();
    }
}
