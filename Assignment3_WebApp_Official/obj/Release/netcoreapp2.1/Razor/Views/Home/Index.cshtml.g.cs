#pragma checksum "C:\Users\mhhod\source\repos\SWTestingQA\Assignment3_WebApp_Official\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0f1419e2d0d30f35a3bf245822b1ec4e9c3e5de6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\mhhod\source\repos\SWTestingQA\Assignment3_WebApp_Official\Views\_ViewImports.cshtml"
using Assignment3_WebApp_Official;

#line default
#line hidden
#line 2 "C:\Users\mhhod\source\repos\SWTestingQA\Assignment3_WebApp_Official\Views\_ViewImports.cshtml"
using Assignment3_WebApp_Official.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f1419e2d0d30f35a3bf245822b1ec4e9c3e5de6", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"34943b45e75f92c8855db56968dde89a58ffb4af", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\mhhod\source\repos\SWTestingQA\Assignment3_WebApp_Official\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(45, 1352, true);
            WriteLiteral(@"
<div class=""jumbotron"">
    <h1>Assignment 3</h1>
    <p class=""lead"">
        The functionality from previous assignments have been augmented to be accesable
        via a web interface using the ASP.NET framework. Deployed onto AWS with Elastic Beanstalk DID THIS WORK PART TWO.
    </p>
    <p><a href=""https://github.com/Mark-Hodge/SWTestingQA"" class=""btn btn-primary btn-lg"">Get Started &raquo;</a></p>
</div>

<div class=""row"">
    <div class=""col-md-4"">
        <h2>Documentation</h2>
        <p>
            View full assignment documentation on Github. Including submission report outlining specifications on how the project was developed,
            tested, and deployed.
        </p>
        <p><a class=""btn btn-default"" href=""https://github.com/Mark-Hodge/SWTestingQA"">Learn more &raquo;</a></p>
    </div>
    <div class=""col-md-4"">
        <h2>Source Code</h2>
        <p>View the full source code on GitHub.</p>
        <p><a class=""btn btn-default"" href=""https://github.com/Mark-Hodg");
            WriteLiteral(@"e/SWTestingQA"">Learn more &raquo;</a></p>
    </div>
    <div class=""col-md-4"">
        <h2>Pipeline Tools</h2>
        <p>See all the tools/products/services used in this project.</p>
        <p><a class=""btn btn-default"" href=""https://go.microsoft.com/fwlink/?LinkId=301867"">Learn more &raquo;</a></p>
    </div>
</div>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
