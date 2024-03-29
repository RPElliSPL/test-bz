## Ellicium Blazor is a set of 70+ free native Blazor UI controls packed with DataGrid, Scheduler, Charts and robust theming including Material design and Fluent UI.

![Ellicium Blazor Components](https://raw.githubusercontent.com/Elliciumhq/Ellicium-blazor/master/ElliciumBlazorDemos/wwwroot/images/Ellicium-blazor-components.png)

## Why choose Ellicium Blazor Components?

### :sparkles: Free

Ellicium Blazor Components are open source and free for commercial use. You can install them from [nuget](https://www.nuget.org/packages/Ellicium.Blazor) or build your own copy from source.

Paid support is available as part of the [Ellicium Professional subscription](https://www.Ellicium.com/blazor-studio/pricing/).

### :computer: Native

The components are implemented in C# and take full advantage of the Blazor framework. They do not depend on or wrap existing JavaScript frameworks or libraries.

Blazor Server and Blazor WebAssembly are fully supported.

### :seedling: Growing

We add new components and features on a regular basis.

Short development cycle. We release as soon as new stuff is available. No more quarterly releases.

## Support exceeding your expectations

### :speech_balloon: Community Support
Everybody is welcome to visit the [Ellicium Community forum](https://forum.Ellicium.com/). Join the growing community and participate in the discussions!

### :dart: Dedicated Support

The Ellicium team monitors the forum threads, but does not guarantee a response to every question. For guaranteed responses you may consider the dedicated support option.

Dedicated support for the Ellicium Blazor Components is available as part of the [Ellicium Professional subscription](https://www.Ellicium.com/blazor-studio/pricing/).

Our flagship product [Ellicium Blazor Studio](https://www.Ellicium.com/blazor-studio/) provides tons of productivity features for Blazor developers:
- An industry-leading WYSIWYG Blazor design time canvas
- Scaffolding a complete CRUD applications from a database
- Built-in security - authentication and authorization
- Visual Studio Code and Professional support
- Deployment to IIS and Azure
- Dedicated support with 24 hour guaranteed response time

## Get started with Ellicium Blazor Components

### 1. Install

Ellicium Blazor Components are distributed as a [Ellicium.Blazor nuget package](https://www.nuget.org/packages/Ellicium.Blazor). You can add them to your project in one of the following ways
- Install the package from command line by running `dotnet add package Ellicium.Blazor`
- Add the project from the Visual Nuget Package Manager
- Manually edit the .csproj file and add a project reference

### 2. Import the namespace

Open the `_Imports.razor` file of your Blazor application and add this line `@using Ellicium.Blazor`.

### 3. Include a theme
Ellicium Blazor components come with five free themes: Material, Standard, Default, Dark, Software and Humanistic.

To use a theme
1. Pick a theme. The [online demos](https://blazor.Ellicium.com/colors) allow you to preview the available options via the theme dropdown located in the header. The Material theme is currently selected by default.
1. Include the theme CSS file in your Blazor application. Open `Pages\_Layout.cshtml` (Blazor Server .NET 6), `Pages\_Host.cshtml` (Blazor Server .NET 7) or `wwwroot/index.html` (Blazor WebAssembly) and include a theme CSS file by adding this snippet
   ```html
   <link rel="stylesheet" href="_content/Ellicium.Blazor/css/material-base.css">
   ```

To include a different theme (i.e. Standard) just change the name of the CSS file:
```
<link rel="stylesheet" href="_content/Ellicium.Blazor/css/standard-base.css">
```

### 4. Include Ellicium.Blazor.js

Open `Pages\_Layout.cshtml` (Blazor Server .NET 6), `Pages\_Host.cshtml` (Blazor Server .NET 7) or `wwwroot/index.html` (Blazor WebAssembly) and include this snippet:

```html
<script src="_content/Ellicium.Blazor/Ellicium.Blazor.js?v=@(typeof(Ellicium.Colors).Assembly.GetName().Version)"></script>
```

### 5. Use a component
Use any Ellicium Blazor component by typing its tag name in a Blazor page e.g.
```html
<ElliciumButton Text="Hi"></ElliciumButton>
```

#### Data-binding a property
```razor
<ElliciumButton Text=@text />
<ElliciumTextBox @bind-Value=@text />
@code {
  string text = "Hi";
}
```

#### Handing events

```razor
<ElliciumButton Click="@ButtonClicked" Text="Hi"></ElliciumButton>
@code {
  void ButtonClicked()
  {

  }
}
```