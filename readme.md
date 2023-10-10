
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