# GettingStarted Sample - CheckBox (Xamarin.iOS)

This repository contains a small Xamarin.iOS sample app demonstrating a custom CheckBox control and how to integrate it into a basic iOS application. The sample is intended for developers who want a practical starting point to learn how to implement, style, and handle checkbox interactions in Xamarin.iOS using C# and Xamarin's UI patterns.

## Overview

- Purpose: Provide a simple, fully-documented example of a CheckBox control in a Xamarin.iOS app.
- Target audience: Mobile developers familiar with C# and Xamarin who want a lightweight example to adapt into their projects.

## Features

- Custom `CheckBox` control with toggled state and accessibility labels.
- Example usage in a sample form with state persistence (in-memory for demo).
- Basic UI layout using Auto Layout constraints and programmatic views.

## Build & Run

1. Open the solution in Visual Studio 2026.
2. Restore NuGet packages: `Restore NuGet Packages` from the solution explorer or run `nuget restore`.
3. Select an iOS simulator or device and choose `Build` → `Run`.

On Windows, you will need a Mac build host connected to deploy to an iOS simulator or device.

## Project Structure

- `AppDelegate.cs` — Application lifecycle and initial window/controller setup.
- `MainViewController.cs` — Demonstrates the `CheckBox` usage in a sample UI.
- `Controls/CheckBox.cs` — Implementation of the custom checkbox control including state management and public events.

# Adding SfCheckBox reference
You can add SfCheckBox reference using one of the following methods:

## Method 1: Adding SfCheckBox reference from nuget.org

Syncfusion Xamarin components are available in nuget.org. To add SfCheckBox to your project, open the NuGet package manager in Visual Studio, search for Syncfusion.Xamarin.Buttons, and then install it.

## Method 2: Adding SfCheckBox reference from toolbox

Syncfusion also provides Xamarin Toolbox. Using this toolbox, you can drag the SfCheckBox control to the XAML page. It will automatically install the required NuGet packages and add the namespace to the page. To install Syncfusion Xamarin Toolbox, refer to Toolbox.

## Method 3: Adding SfCheckBox assemblies manually from the installed location

If you prefer to manually reference the assemblies instead referencing from NuGet, add the following assemblies in respective projects.

# Additional step for iOS
To launch SfCheckBox in iOS, call the SfCheckBoxRenderer.Init() in FinishedLaunching overridden method of AppDelegate class in iOS Project, as demonstrated in the following code example.

**[C#]**
```
public override bool FinishedLaunching(UIApplication app, NSDictionary options)
{
    global::Xamarin.Forms.Forms.Init();
    LoadApplication(new App());
    Syncfusion.XForms.iOS.Buttons.SfCheckBoxRenderer.Init();
    return base.FinishedLaunching(app, options);
}
```
## How to run this application?

To run this application, you need to first clone the GettingStarted-Sample-CheckBox-Xamarin.iOS repository and then open it in Visual Studio 2022. Now, simply build and run your project to view the output.

## <a name="troubleshooting"></a>Troubleshooting ##
### Path too long exception
If you are facing path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.

## License

Syncfusion has no liability for any damage or consequence that may arise by using or viewing the samples. The samples are for demonstrative purposes, and if you choose to use or access the samples, you agree to not hold Syncfusion liable, in any form, for any damage that is related to use, for accessing, or viewing the samples. By accessing, viewing, or seeing the samples, you acknowledge and agree Syncfusion’s samples will not allow you seek injunctive relief in any form for any claim related to the sample. If you do not agree to this, do not view, access, utilize, or otherwise do anything with Syncfusion’s samples.