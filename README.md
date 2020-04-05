# BlazorCurrentDevice
Device detection for blazor using current-device.js

This is a wrapper around current-device.js

## Installation

`Install-Package BlazorCurrentDevice -Version 1.0.1`

## Add _Imports.razor reference

`@using BlazorCurrentDevice`

## Add the service

`services.AddBlazorCurrentDevice();`

## Add Javascript lib reference
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
