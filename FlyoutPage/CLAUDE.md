# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## Project Overview

This is a .NET MAUI learning project repository (`ExemplosApp`) containing educational examples for mobile app development. The current project (`FlyoutPage`) demonstrates the FlyoutPage navigation pattern, similar to the existing `appUsandoTabbedPage` project which showcases TabbedPage navigation.

**Repository Structure:**
- `appUsandoTabbedPage/` — TabbedPage navigation example (completed reference)
- `exercicio01Grupo05/` — Group exercise 01 
- `FlyoutPage/` — Current FlyoutPage project (to be implemented)
- `.vscode/` — Shared VS Code configuration

## Build and Development Commands

### Building the Project
```bash
# From project directory
dotnet clean
dotnet build -p:TargetFramework=net10.0-windows10.0.19041.0

# Run on Windows (default platform)
dotnet run
```

### Resource Management
```bash
# Check required images exist in Resources/Images/
ls Resources/Images/

# Verify SVG to PNG conversion (Resizetizer handles automatically)
# SVG files in Resources/ must be referenced as .png in XAML
```

### Git Workflow
```bash
# Standard commit pattern
git add .
git commit -m "feat: description of changes"
```

## Architecture

### Project Structure (Standard MAUI Pattern)
```
appUsandoFlyoutPage/
├── App.xaml + App.xaml.cs          # Application entry point
├── MauiProgram.cs                  # MAUI app configuration
├── Views/                          # All page components
│   ├── Dandara.xaml + .xaml.cs     # ContentPage for Dandara
│   ├── Oprah.xaml + .xaml.cs       # ContentPage for Oprah  
│   ├── Menu.xaml + .xaml.cs        # Flyout menu page
│   └── FlyoutPageMenu.xaml + .xaml.cs  # Main FlyoutPage
├── Resources/
│   ├── AppIcon/                    # App icons (SVG)
│   ├── Images/                     # Images (PNG/SVG)
│   ├── Fonts/                      # Custom fonts
│   └── Splash/                     # Splash screens (SVG)
├── Platforms/                      # Platform-specific code
└── [ProjectName].csproj            # Project configuration
```

### Key Architecture Patterns

**1. FlyoutPage Navigation Pattern**
- **FlyoutPageMenu.xaml** — Main container with `FlyoutLayoutBehavior="Popover"`
- **Flyout property** — References the Menu page (left sidebar)
- **Detail property** — References NavigationPage containing content pages
- **Navigation** — Change Detail property to switch between content pages

**2. Resource Loading (Resizetizer)**
- SVG files in `Resources/` are automatically converted to PNG at build
- **Critical:** Always reference SVG resources with `.png` extension in XAML
- Example: `BackgroundImageSource="fundo.png"` (even though source is `fundo.svg`)

**3. Application Bootstrap**
- `App.xaml.cs` → `CreateWindow()` returns root navigation structure
- For FlyoutPage: `return new Window(new FlyoutPageMenu());`
- For TabbedPage: `return new Window(new NavigationPage(new Principal()));`

**4. Page Navigation**
- Menu.xaml.cs contains methods like `irPaginaDandara()` and `irPaginaOprah()`
- These methods update `Application.Current.MainPage.Detail` property
- Always wrap content pages in `NavigationPage` for proper navigation stack

### Code-Behind Pattern
```csharp
// Standard page class inheritance
public partial class Dandara : ContentPage  // ContentPage for regular pages
public partial class FlyoutPageMenu : FlyoutPage  // FlyoutPage for main container
```

### XAML Namespaces
```xml
xmlns:paginas="clr-namespace:appUsandoFlyoutPage.Views"
```

## Configuration Files

### .csproj Key Settings
```xml
<ApplicationTitle>Usando FlyoutPage</ApplicationTitle>
<ApplicationId>br.edu.udf</ApplicationId>
<ApplicationDisplayVersion>1.0.0</ApplicationDisplayVersion>
<ApplicationVersion>100</ApplicationVersion>

<!-- App Icon -->
<MauiIcon Include="Resources\AppIcon\iconemulher.svg" ForegroundFile="..." TintColor="#FFFFFF" />

<!-- Splash Screen -->
<MauiSplashScreen Include="Resources\Splash\splash.svg" Color="#00AB37" BaseSize="178,178" />
```

## Accessibility Requirements (WCAG 2.1 AA)

### Color Contrast Standards
- **Background:** `#FEDEDD` (Rosa Claro — from fundo.svg)
- **Minimum Contrast Ratio:** 4.5:1 for normal text
- **Valid Colors** (tested against #FEDEDD):
  - `Maroon` (#800000) → 8.71 ✅
  - `Brown` (#A52A2A) → 5.64 ✅
  - `SaddleBrown` (#8B4513) → 5.65 ✅
  - `DarkRed` → 7.34 ✅
  - `Purple` → 6.82 ✅
  - `DarkGreen` → 7.12 ✅
  - `Indigo` → 7.05 ✅
  - `DarkViolet` → 6.91 ✅

### Invalid Colors (FAIL)
- `OrangeRed` (#FF4500) → 2.74 ❌
- `DarkOrange` (#FF8C00) → 1.86 ❌

## Content Pages Structure

### Standard Page Layout Pattern
```xml
<ContentPage Title="Nome" IconImageSource="icone.png" BackgroundImageSource="fundo.png">
    <ScrollView>
        <StackLayout Padding="5, 25">
            <!-- Header -->
            <Label Text="Nome: Pessoa" FontAttributes="Bold" FontSize="Large" 
                   TextColor="[ValidColor]" HorizontalOptions="Center" />
            <Label Text="Anos · País" FontSize="Small" 
                   TextColor="[ValidColor]" HorizontalOptions="Center" />
            
            <!-- Image -->
            <Image Source="photo.png" WidthRequest="250" HeightRequest="250" />
            
            <!-- Content -->
            <StackLayout Padding="50, 10">
                <Label Text="Biography text..." 
                       HorizontalOptions="FillAndExpand"
                       FontAttributes="Bold" FontSize="Medium"
                       TextColor="[ValidColor]" />
            </StackLayout>
        </StackLayout>
    </ScrollView>
</ContentPage>
```

## Required Resources

### Images for FlyoutPage Project
- `iconemulher.svg` — App icon
- `splash.svg` — Splash screen
- `dandarazumbi.png` — Dandara photo
- `oprahwinfrey.png` — Oprah photo
- `fundo.png` — Background (referenced as .png in XAML)
- `logomulher.png` — Menu logo

## Common Issues and Solutions

### Issue: Images not displaying
**Solution:** Verify SVG files are referenced with `.png` extension in XAML (Resizetizer requirement)

### Issue: Navigation not working
**Solution:** Ensure Detail property is set to `new NavigationPage(new ContentPage())` not just `new ContentPage()`

### Issue: Text encoding problems
**Solution:** Ensure all .xaml files are saved with UTF-8 encoding (check for `mÃ£e` instead of `mãe`)

### Issue: Colors fail WCAG contrast
**Solution:** Use only validated colors from the WCAG 2.1 AA compliant list above

## Development Workflow

1. **Setup:** Remove default `MainPage.xaml` and `AppShell.xaml`, create `Views/` folder
2. **Create Pages:** Build ContentPages in Views/ following the standard layout pattern
3. **Configure FlyoutPage:** Set up FlyoutPageMenu with proper Flyout/Detail properties
4. **Update Bootstrap:** Modify App.xaml.cs CreateWindow() to return FlyoutPageMenu
5. **Test Accessibility:** Verify all TextColor values against WCAG AA standards
6. **Build & Validate:** Run `dotnet clean && dotnet build` to check for errors
7. **Commit:** Use conventional commits with descriptive messages

## Reference Projects

Use `appUsandoTabbedPage` as the primary reference for:
- Project structure and organization
- Resource management patterns
- Accessibility-compliant color schemes
- XAML layout patterns
- Content page structure
- MAUI best practices

The TabbedPage project demonstrates 9 content pages with proper WCAG AA compliance and can serve as a template for creating similar FlyoutPage content.