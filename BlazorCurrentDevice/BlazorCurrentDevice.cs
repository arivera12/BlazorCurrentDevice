using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace BlazorCurrentDevice
{
    public class BlazorCurrentDevice
    {
        protected IJSRuntime JSRuntime { get; set; }
        public BlazorCurrentDevice(IJSRuntime jSRuntime)
        {
            JSRuntime = jSRuntime;
        }
        public async ValueTask<bool> Android()
        {
            return await JSRuntime.InvokeAsync<bool>("device.android");
        }
        public async ValueTask<bool> AndroidPhone()
        {
            return await JSRuntime.InvokeAsync<bool>("device.androidPhone");
        }
        public async ValueTask<bool> AndroidTablet()
        {
            return await JSRuntime.InvokeAsync<bool>("device.androidTablet");
        }
        public async ValueTask<bool> Blackberry()
        {
            return await JSRuntime.InvokeAsync<bool>("device.blackberry");
        }
        public async ValueTask<bool> BlackberryPhone()
        {
            return await JSRuntime.InvokeAsync<bool>("device.blackberryPhone");
        }
        public async ValueTask<bool> BlackberryTablet()
        {
            return await JSRuntime.InvokeAsync<bool>("device.blackberryTablet");
        }
        public async ValueTask<bool> Cordova()
        {
            return await JSRuntime.InvokeAsync<bool>("device.cordova");
        }
        public async ValueTask<bool> Desktop()
        {
            return await JSRuntime.InvokeAsync<bool>("device.desktop");
        }
        public async ValueTask<bool> FireFoxOs()
        {
            return await JSRuntime.InvokeAsync<bool>("device.fxos");
        }
        public async ValueTask<bool> FireFoxOsPhone()
        {
            return await JSRuntime.InvokeAsync<bool>("device.fxosPhone");
        }
        public async ValueTask<bool> FireFoxOsTablet()
        {
            return await JSRuntime.InvokeAsync<bool>("device.fxosTablet");
        }
        public async ValueTask<bool> iOS()
        {
            return await JSRuntime.InvokeAsync<bool>("device.ios");
        }
        public async ValueTask<bool> iPad()
        {
            return await JSRuntime.InvokeAsync<bool>("device.ipad");
        }
        public async ValueTask<bool> iPhone()
        {
            return await JSRuntime.InvokeAsync<bool>("device.iphone");
        }
        public async ValueTask<bool> iPod()
        {
            return await JSRuntime.InvokeAsync<bool>("device.ipod");
        }
        public async ValueTask<bool> Landscape()
        {
            return await JSRuntime.InvokeAsync<bool>("device.landscape");
        }
        public async ValueTask<bool> MacOs()
        {
            return await JSRuntime.InvokeAsync<bool>("device.macos");
        }
        public async ValueTask<bool> MeeGo()
        {
            return await JSRuntime.InvokeAsync<bool>("device.meego");
        }
        public async ValueTask<bool> Mobile()
        {
            return await JSRuntime.InvokeAsync<bool>("device.mobile");
        }
        public async ValueTask<bool> NodeWebkit()
        {
            return await JSRuntime.InvokeAsync<bool>("device.mobile");
        }
        public async ValueTask<string> Orientation()
        {
            return await JSRuntime.InvokeAsync<string>("eval", "device.orientation");
        }
        public async ValueTask<string> OS()
        {
            return await JSRuntime.InvokeAsync<string>("eval", "device.os");
        }
        public async ValueTask<bool> Portrait()
        {
            return await JSRuntime.InvokeAsync<bool>("device.portrait");
        }
        public async ValueTask<bool> Tablet()
        {
            return await JSRuntime.InvokeAsync<bool>("device.tablet");
        }
        public async ValueTask<bool> Television()
        {
            return await JSRuntime.InvokeAsync<bool>("device.television");
        }
        public async ValueTask<string> Type()
        {
            return await JSRuntime.InvokeAsync<string>("eval", "device.type");
        }
        public async ValueTask<bool> Windows()
        {
            return await JSRuntime.InvokeAsync<bool>("device.windows");
        }
        public async ValueTask<bool> WindowsPhone()
        {
            return await JSRuntime.InvokeAsync<bool>("device.windowsPhone");
        }
        public async ValueTask<bool> WindowsTablet()
        {
            return await JSRuntime.InvokeAsync<bool>("device.windowsTablet");
        }
    }
}
