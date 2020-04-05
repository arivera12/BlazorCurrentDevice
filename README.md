# BlazorCurrentDevice
Device detection for blazor using current-device.js

This is a wrapper around current-device.js

## Installation

`Install-Package BlazorCurrentDevice -Version 1.0.2`

## Add reference in _Imports.razor

`@using BlazorCurrentDevice`

## Add the service in your services method

`services.AddBlazorCurrentDevice();`

## Add javascript library reference in your index.html
`<script src="_content/BlazorCurrentDevice/current-device.min.js"></script>`

## Usage
`
[Inject] BlazorCurrentDevice BlazorCurrentDevice { get; set; }
`

#### Device Methods

<table>
	<tr>
		<th>BlazorCurrentDevice</th>
		<th>Method</th>
	</tr>
	<tr>
		<td>Mobile</td>
		<td>BlazorCurrentDevice.Mobile()</td>
	</tr>
	<tr>
		<td>Tablet</td>
		<td>BlazorCurrentDevice.Tablet()</td>
	</tr>
	<tr>
		<td>Desktop</td>
		<td>BlazorCurrentDevice.Desktop()</td>
	</tr>
	<tr>
		<td>iOS</td>
		<td>BlazorCurrentDevice.iOS()</td>
	</tr>
	<tr>
		<td>iPad</td>
		<td>BlazorCurrentDevice.iPad()</td>
	</tr>
	<tr>
		<td>iPhone</td>
		<td>BlazorCurrentDevice.iPhone()</td>
	</tr>
	<tr>
		<td>iPod</td>
		<td>BlazorCurrentDevice.iPod()</td>
	</tr>
	<tr>
		<td>Android</td>
		<td>BlazorCurrentDevice.Android()</td>
	</tr>
	<tr>
		<td>Android Phone</td>
		<td>BlazorCurrentDevice.AndroidPhone()</td>
	</tr>
	<tr>
		<td>Android Tablet</td>
		<td>BlazorCurrentDevice.AndroidTablet()</td>
	</tr>
	<tr>
		<td>BlackBerry</td>
		<td>BlazorCurrentDevice.Blackberry()</td>
	</tr>
	<tr>
		<td>BlackBerry Phone</td>
		<td>BlazorCurrentDevice.BlackberryPhone()</td>
	</tr>
	<tr>
		<td>BlackBerry Tablet</td>
		<td>BlazorCurrentDevice.BlackberryTablet()</td>
	</tr>
	<tr>
		<td>Windows</td>
		<td>BlazorCurrentDevice.Windows()</td>
	</tr>
	<tr>
		<td>Windows Phone</td>
		<td>BlazorCurrentDevice.WindowsPhone()</td>
	</tr>
	<tr>
		<td>Windows Tablet</td>
		<td>BlazorCurrentDevice.WindowsTablet()</td>
	</tr>
	<tr>
		<td>Firefox OS</td>
		<td>BlazorCurrentDevice.FireFoxOs()</td>
	</tr>
	<tr>
		<td>Firefox OS Phone</td>
		<td>BlazorCurrentDevice.FireFoxOsPhone()</td>
	</tr>
	<tr>
		<td>Firefox OS Tablet</td>
		<td>BlazorCurrentDevice.FireFoxOsTablet()</td>
	</tr>
  <tr>
		<td>MacOs</td>
		<td>BlazorCurrentDevice.MacOs()</td>
	</tr>
	<tr>
		<td>MeeGo</td>
		<td>BlazorCurrentDevice.MeeGo()</td>
	</tr>
  <tr>
		<td>NodeWebkit</td>
		<td>BlazorCurrentDevice.NodeWebkit()</td>
	</tr>
   <tr>
		<td>Cordova</td>
		<td>BlazorCurrentDevice.Cordova()</td>
	</tr>
	<tr>
		<td>Television</td>
		<td>BlazorCurrentDevice.Television()</td>
	</tr>
</table>

#### Orientation Methods

<table>
	<tr>
		<th>Orientation</th>
		<th>Method</th>
	</tr>
	<tr>
		<td>Landscape</td>
		<td>BlazorCurrentDevice.Landscape()</td>
	</tr>
	<tr>
		<td>Portrait</td>
		<td>BlazorCurrentDevice.Portrait()</td>
	</tr>
</table>

### Useful Methods

<table>
	<tr>
		<th>Method</th>
		<th>Returns</th>
	</tr>
	<tr>
		<td>BlazorCurrentDevice.Type()</td>
		<td>'mobile', 'tablet', 'desktop', or 'unknown'</td>
	</tr>
	<tr>
		<td>BlazorCurrentDevice.Orientation()</td>
		<td>'landscape', 'portrait', or 'unknown'</td>
	</tr>
	<tr>
		<td>BlazorCurrentDevice.OS()</td>
		<td>'ios', 'iphone', 'ipad', 'ipod', 'android', 'blackberry', 'windows', 'macos', 'fxos', 'meego', 'television', or 'unknown'</td>
	</tr>
</table>

## TODO
- Implement onChangeOrientation callback

## License
MIT
