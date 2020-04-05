# BlazorCurrentDevice
Device detection for blazor using current-device.js

This is a wrapper around current-device.js

## Installation

`Install-Package BlazorCurrentDevice -Version 1.0.2`

## Add reference in _Imports.razor

`@using BlazorCurrentDevice`

## Add the service in your services method

`services.AddBlazorCurrentDevice();`

## Add javascript librry reference in your index.html
`<script src="_content/BlazorCurrentDevice/current-device.min.js"></script>`

## Usage
`
[Inject] BlazorCurrentDevice BlazorCurrentDevice { get; set; }
`

Your are good to go.

For reference [https://github.com/matthewhudson/current-device](https://github.com/matthewhudson/current-device)

## TODO
- Implement onChangeOrientation callback

## License
MIT
