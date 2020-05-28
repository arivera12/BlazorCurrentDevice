using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace BlazorCurrentDevice
{
    internal class BlazorCurrentDeviceService : IBlazorCurrentDeviceService
    {
        protected IJSRuntime JSRuntime { get; set; }
        public BlazorCurrentDeviceService(IJSRuntime jSRuntime)
        {
            JSRuntime = jSRuntime;
        }
        public ValueTask<bool> Android()
        {
            return JSRuntime.InvokeAsync<bool>("device.android");
        }
        public ValueTask<bool> AndroidPhone()
        {
            return JSRuntime.InvokeAsync<bool>("device.androidPhone");
        }
        public ValueTask<bool> AndroidTablet()
        {
            return JSRuntime.InvokeAsync<bool>("device.androidTablet");
        }
        public ValueTask<bool> Blackberry()
        {
            return JSRuntime.InvokeAsync<bool>("device.blackberry");
        }
        public ValueTask<bool> BlackberryPhone()
        {
            return JSRuntime.InvokeAsync<bool>("device.blackberryPhone");
        }
        public ValueTask<bool> BlackberryTablet()
        {
            return JSRuntime.InvokeAsync<bool>("device.blackberryTablet");
        }
        public ValueTask<bool> Cordova()
        {
            return JSRuntime.InvokeAsync<bool>("device.cordova");
        }
        public ValueTask<bool> Desktop()
        {
            return JSRuntime.InvokeAsync<bool>("device.desktop");
        }
        public ValueTask<bool> FireFoxOs()
        {
            return JSRuntime.InvokeAsync<bool>("device.fxos");
        }
        public ValueTask<bool> FireFoxOsPhone()
        {
            return JSRuntime.InvokeAsync<bool>("device.fxosPhone");
        }
        public ValueTask<bool> FireFoxOsTablet()
        {
            return JSRuntime.InvokeAsync<bool>("device.fxosTablet");
        }
        public ValueTask<bool> iOS()
        {
            return JSRuntime.InvokeAsync<bool>("device.ios");
        }
        public ValueTask<bool> iPad()
        {
            return JSRuntime.InvokeAsync<bool>("device.ipad");
        }
        public ValueTask<bool> iPhone()
        {
            return JSRuntime.InvokeAsync<bool>("device.iphone");
        }
        public ValueTask<bool> iPod()
        {
            return JSRuntime.InvokeAsync<bool>("device.ipod");
        }
        public ValueTask<bool> Landscape()
        {
            return JSRuntime.InvokeAsync<bool>("device.landscape");
        }
        public ValueTask<bool> MacOs()
        {
            return JSRuntime.InvokeAsync<bool>("device.macos");
        }
        public ValueTask<bool> MeeGo()
        {
            return JSRuntime.InvokeAsync<bool>("device.meego");
        }
        public ValueTask<bool> Mobile()
        {
            return JSRuntime.InvokeAsync<bool>("device.mobile");
        }
        public ValueTask<bool> NodeWebkit()
        {
            return JSRuntime.InvokeAsync<bool>("device.mobile");
        }
        public ValueTask<string> Orientation()
        {
            return JSRuntime.InvokeAsync<string>("eval", "device.orientation");
        }
        public ValueTask<string> OS()
        {
            return JSRuntime.InvokeAsync<string>("eval", "device.os");
        }
        public ValueTask<bool> Portrait()
        {
            return JSRuntime.InvokeAsync<bool>("device.portrait");
        }
        public ValueTask<bool> Tablet()
        {
            return JSRuntime.InvokeAsync<bool>("device.tablet");
        }
        public ValueTask<bool> Television()
        {
            return JSRuntime.InvokeAsync<bool>("device.television");
        }
        public ValueTask<string> Type()
        {
            return JSRuntime.InvokeAsync<string>("eval", "device.type");
        }
        public ValueTask<bool> Windows()
        {
            return JSRuntime.InvokeAsync<bool>("device.windows");
        }
        public ValueTask<bool> WindowsPhone()
        {
            return JSRuntime.InvokeAsync<bool>("device.windowsPhone");
        }
        public ValueTask<bool> WindowsTablet()
        {
            return JSRuntime.InvokeAsync<bool>("device.windowsTablet");
        }
    }
}
