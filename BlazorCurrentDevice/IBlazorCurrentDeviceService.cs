using System.Threading.Tasks;

namespace BlazorCurrentDevice
{
    public interface IBlazorCurrentDeviceService
    {
        /// <summary>
        /// Check wether the current device is android
        /// </summary>
        /// <returns></returns>
        ValueTask<bool> Android();
        /// <summary>
        /// Check wether the current device is android phone
        /// </summary>
        /// <returns></returns>
        ValueTask<bool> AndroidPhone();
        /// <summary>
        /// Check wether the current device is android tablet
        /// </summary>
        /// <returns></returns>
        ValueTask<bool> AndroidTablet();
        /// <summary>
        /// Check wether the current device is Blackberry
        /// </summary>
        /// <returns></returns>
        ValueTask<bool> Blackberry();
        /// <summary>
        /// Check wether the current device is Blackberry phone
        /// </summary>
        /// <returns></returns>
        ValueTask<bool> BlackberryPhone();
        /// <summary>
        /// Check wether the current device is Blackberry tablet
        /// </summary>
        /// <returns></returns>
        ValueTask<bool> BlackberryTablet();
        /// <summary>
        /// Check wether the current device is running on cordova
        /// </summary>
        /// <returns></returns>
        //ValueTask<bool> Cordova();
        /// <summary>
        /// Check wether the current device is desktop
        /// </summary>
        /// <returns></returns>
        ValueTask<bool> Desktop();
        /// <summary>
        /// Check wether the current device is FireFox OS
        /// </summary>
        /// <returns></returns>
        ValueTask<bool> FireFoxOs();
        /// <summary>
        /// Check wether the current device is FireFox OS phone
        /// </summary>
        /// <returns></returns>
        ValueTask<bool> FireFoxOsPhone();
        /// <summary>
        /// Check wether the current device is FireFox OS tablet
        /// </summary>
        /// <returns></returns>
        ValueTask<bool> FireFoxOsTablet();
        /// <summary>
        /// Check wether the current device is iOS
        /// </summary>
        /// <returns></returns>
        ValueTask<bool> iOS();
        /// <summary>
        /// Check wether the current device is iPad
        /// </summary>
        /// <returns></returns>
        ValueTask<bool> iPad();
        /// <summary>
        /// Check wether the current device is iPhone
        /// </summary>
        /// <returns></returns>
        ValueTask<bool> iPhone();
        /// <summary>
        /// Check wether the current device is iPod
        /// </summary>
        /// <returns></returns>
        ValueTask<bool> iPod();
        /// <summary>
        /// Check wether the current device is on landscape orientation
        /// </summary>
        /// <returns></returns>
        ValueTask<bool> Landscape();
        /// <summary>
        /// Check wether the current device is MacOs
        /// </summary>
        /// <returns></returns>
        ValueTask<bool> MacOs();
        /// <summary>
        /// Check wether the current device is MeeGo
        /// </summary>
        /// <returns></returns>
        ValueTask<bool> MeeGo();
        /// <summary>
        /// Check wether the current device is mobile
        /// </summary>
        /// <returns></returns>
        ValueTask<bool> Mobile();
        /// <summary>
        /// Check wether the current device is running on NodeWebkit
        /// </summary>
        /// <returns></returns>
        ValueTask<bool> NodeWebkit();
        /// <summary>
        /// Gets the current device orientation
        /// </summary>
        /// <returns></returns>
        ValueTask<string> Orientation();
        /// <summary>
        /// Gets the current device operating system. Posible return values 'landscape', 'portrait', or 'unknown'
        /// </summary>
        /// <returns></returns>
        ValueTask<string> OS();
        /// <summary>
        /// Checks wether the current device is portrait orientation. Posible return values 'ios', 'iphone', 'ipad', 'ipod', 'android', 'blackberry', 'windows', 'macos', 'fxos', 'meego', 'television', or 'unknown'
        /// </summary>
        /// <returns></returns>
        ValueTask<bool> Portrait();
        /// <summary>
        /// Check wether the current device is tablet
        /// </summary>
        /// <returns></returns>
        ValueTask<bool> Tablet();
        /// <summary>
        /// Check wether the current device is television
        /// </summary>
        /// <returns></returns>
        ValueTask<bool> Television();
        /// <summary>
        /// Gets the current device type. Posible return values 'mobile', 'tablet', 'desktop', or 'unknown'
        /// </summary>
        /// <returns></returns>
        ValueTask<string> Type();
        /// <summary>
        /// Check wether the current device is windows
        /// </summary>
        /// <returns></returns>
        ValueTask<bool> Windows();
        /// <summary>
        /// Check wether the current device is windows phone
        /// </summary>
        /// <returns></returns>
        ValueTask<bool> WindowsPhone();
        /// <summary>
        /// Check wether the current device is tablet
        /// </summary>
        /// <returns></returns>
        ValueTask<bool> WindowsTablet();
    }
}
