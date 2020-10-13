[![Build Status](https://travis-ci.org/andrei-m-code/net-core-html-to-image.svg?branch=master)](https://travis-ci.org/andrei-m-code/net-core-html-to-image) [![NuGet](https://img.shields.io/nuget/v/CoreHtmlToImage.svg)](https://www.nuget.org/packages/CoreHtmlToImage/)

# .NET Core HTML to Image converter

This is a .NET Core HTML to Image converter. It helps converting HTML strings or URLs to image bytes. Please see the examples:

## Installation Instructions
Nuget package available (https://www.nuget.org/packages/CoreHtmlToImage/)
```
Install-Package CoreHtmlToImage
```
dotnet cli:
```
dotnet add package CoreHtmlToImage
```
## Convert HTML string to image bytes
```
var converter = new HtmlConverter();
var html = "<div><strong>Hello</strong> World!</div>";
var bytes = converter.FromHtmlString(html);
File.WriteAllBytes("image.jpg", bytes);
```
            
## Convert URL to image bytes
```
var converter = new HtmlConverter();
var bytes = converter.FromUrl("http://google.com");
File.WriteAllBytes("image.jpg", bytes);
```

## Optional parameters
1. OutputSize - output image size, default is (1024, 768).
2. OutputFormat - output image format. Default is Jpg.
3. Quality - output image quality from 1 to 100. Default is 100.
4. DisableSmartWidth - Disabling smart-width makes the process to listen to exact passes width

## Roadmap
* Async methods
* Non-Windows support

## More about this library
Because I couldn't find a free implementation of .NET Core HTML to Image library, I've developed my own and hope it will help other people as well. This library wraps very nice wkhtmltoimage tool (https://wkhtmltopdf.org/). I have wkhtmltoimage.exe embedded into my library. This is a very simple implementation. Your contributions are very welcome!
