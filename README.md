# NotifyLib

[![NuGet Version](https://img.shields.io/nuget/v/NotifyLib.svg)](https://www.nuget.org/packages/YourLibraryName/)
[![License](https://img.shields.io/github/license/DiyRex/NotifyLib.svg)](https://opensource.org/licenses/MIT)

## Overview

Notifylib is a .NET library that provides a simple and customizable notification popup for Windows Forms applications.

- Easily display informative popups with customizable duration and appearance.
- Supports displaying images, setting background color, and customizing text color.

## Compatibility

- Minimum .NET Version: .NET Framework 4.6

## Installation

Install the library via NuGet Package Manager Console:

```bash
nuget install NotifyLib
```

## Usage

You can customize various properties of the NotifyPopup class to suit your application's needs.

```bash
using Notify;

// ...

NotifyPopup np = new NotifyPopup(
    duration: 2000,           //adjust wait time
    timerInterval: 10,        //adjust moving speed
    title: "Message Title",
    messageBody: "Message Body",
    opacity: 1,
    notifyImage: @"path\to\your\image",
    imgSize: 50,              //adjust notify image size
    bodyColor: Color.LightPink,
    textColor: Color.Black
);

np.Show();
```

## Contributing
- If you have suggestions or found issues, feel free to create an issue or submit a pull request.

## Author
- [DiyRex](https://github.com/DiyRex)

## License
- Notifylib is licensed under the MIT License.

