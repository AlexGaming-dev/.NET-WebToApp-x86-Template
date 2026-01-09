# 🛠 .NET WebToApp x86 Template

A professional foundation for developers to transform web surfaces into native Windows desktop applications. This template is designed to provide a lightweight, high-performance wrapper for any web-based dashboard, tool, or site.

## 🌟 Key Features
- **Native x86 Architecture:** Specifically optimized for standard Windows environments and compatibility.
- **WebView2 Engine:** High-performance rendering via the modern Microsoft Edge (Chromium) engine.
- **Deployment Ready:** Clean project structure, prepared for integration with WiX Toolset to create `.msi` installers.
- **Lightweight:** Minimal boilerplate, focusing on performance and ease of use.

---

## 🚀 Getting Started

Follow these steps to create your own wrapper application using this template:

### 1. Template Setup
Click the **"Use this template"** button at the top of this repository to create your own copy of this project under your account or organization.

### 2. Development Environment
- Open the solution (`.sln`) in **Visual Studio 2022**.
- Ensure the **.NET Desktop Development** workload is installed in your Visual Studio instance.
- Restore NuGet packages to ensure **Microsoft.Web.WebView2** is correctly loaded.

### 3. Customization
Navigate to the `MainWindow.cs` file and replace the placeholder URL with your target website address:

```csharp
// Locate this line in MainWindow.cs
webView.CoreWebView2.Navigate("[https://alexgaming.netlify.app](https://alexgaming.netlify.app)");
```

### 4. Build & Deploy
- Set your build configuration in Visual Studio to **Release**.
- Set the platform to **x86**.
- Build the solution to generate your standalone executable.

---

## 🛠 Technical Details
- **Framework:** .NET 6.0 (Windows)
- **Platform:** x86
- **Dependencies:** Microsoft.Web.WebView2
- **Installer Support:** Compatible with WiX Toolset v3.11+

---

## ⚖️ License
Distributed under the **MIT License**. This means you are free to use, modify, and distribute this template for private and commercial projects.

**Created and maintained by Alex Studios**
