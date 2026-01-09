# 🛠 .NET WebToApp x86 Template

Professional foundation for developers to transform web surfaces into native Windows desktop applications.

## 🌟 Key Features
- **Native x86 Architecture:** Optimized for standard Windows environments.
- **WebView2 Engine:** High-performance rendering via Microsoft Edge (Chromium).
- **Deployment Ready:** Structured to be easily used with WiX Toolset for `.msi` creation.

---

## 🚀 Getting Started

Follow these steps to create your own wrapper application:

### 1. Template Setup
Click the **"Use this template"** button at the top of this repository to create your own project instance.

### 2. Development Environment
- Open the solution in **Visual Studio 2022**.
- Ensure the **.NET Desktop Development** workload is installed.
- Restore NuGet packages (especially `Microsoft.Web.WebView2`).

### 3. Customization
Navigate to `MainWindow.cs` and replace the placeholder URL with your target website:
```csharp
webView.CoreWebView2.Navigate("[https://your-website.com](https://your-website.com)");
