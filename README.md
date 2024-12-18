
# Plugin.Toolkit.Fonts.MaterialIcons

![icon](https://handityo.my.id/icon_nuget.png)

[![NuGet](https://img.shields.io/nuget/v/Plugin.Toolkit.Fonts.MaterialIcons)](https://www.nuget.org/packages/Plugin.Toolkit.Fonts.MaterialIcons)
[![.NET MAUI](https://img.shields.io/badge/.NET%20MAUI-512BD4?style=flat&logo=dotnet&label=.NET%20MAUI)](https://dotnet.microsoft.com/en-us/apps/maui)

**A comprehensive Material Icons font library for MAUI C# applications.**

## Overview
This repository provides a convenient way to incorporate Google's Material Icons into your MAUI C# projects. Whether you're building mobile, desktop, or web applications, this library offers a wide range of icons to enhance your user interface.

## Features
* **Easy to use:** Seamless integration into your MAUI projects.
* **Comprehensive:** Includes a vast collection of Material Icons.
* **Customizable:** Customize the appearance of icons to match your branding.
* **Performance optimized:** Ensures smooth performance in your applications.


## Installation

You can install the plugin via NuGet:

```bash
Install-Package Plugin.Toolkit.Fonts.MaterialIcons
```

## Usage

1.  **Register the font:**

    In your `MauiProgram.cs` file:

    ```csharp
    using Plugin.Toolkit.Fonts.MaterialIcons;

    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
    		fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
    		fonts.AddMaterialIconsFonts();  // <-- add this if using this font to global. using: FontFamily="Icon" (Icon or IconFilled)
                    // fonts.AddMaterialIconsFontsPartial(); // <-- add this if using this font as partial. using: FontFamily="MaterialIcon" (MaterialIcon or MaterialIconFilled)
                });

            return builder.Build();
        }
    }
    ```

2.  **Use the font in XAML:**

    ```xml
    <Label Text="notifications" FontFamily="Icon" FontSize="32" />
    <Label Text="notifications" FontFamily="IconFilled" FontSize="32" />
    ```

    Or with *Style*:

    ```xml
    <Style TargetType="Label" x:Key="IconLabelStyle">
        <Setter Property="FontFamily" Value="Icon"/>
        <Setter Property="FontSize" Value="32"/>
    </Style>

    <Label Text="notifications" Style="{StaticResource IconLabelStyle}"/>
    ```

## Example Project
The repository includes a sample MAUI project demonstrating the usage of the plugin. You can find it in the `samples` directory.

## Contributing
Contributions are welcome! Please open an issue or submit a pull request.

## Contact
If you have any questions or suggestions, please feel free to contact me at andyapin@gmail.com
