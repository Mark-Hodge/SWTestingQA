#pragma checksum "C:\Users\mhhod\source\repos\SWTestingQA\Assignment3_WebApp_Official\Views\Home\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "96f5be3312817bcb7c6d2ea3202dc5248d81243a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_About), @"mvc.1.0.view", @"/Views/Home/About.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/About.cshtml", typeof(AspNetCore.Views_Home_About))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"96f5be3312817bcb7c6d2ea3202dc5248d81243a", @"/Views/Home/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"34943b45e75f92c8855db56968dde89a58ffb4af", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_About : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(78, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(85, 17, false);
#line 4 "C:\Users\mhhod\source\repos\SWTestingQA\Assignment3_WebApp_Official\Views\Home\About.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(102, 11, true);
            WriteLiteral("</h2>\r\n<h3>");
            EndContext();
            BeginContext(114, 19, false);
#line 5 "C:\Users\mhhod\source\repos\SWTestingQA\Assignment3_WebApp_Official\Views\Home\About.cshtml"
Write(ViewData["Message"]);

#line default
#line hidden
            EndContext();
            BeginContext(133, 2221, true);
            WriteLiteral(@"</h3>

<p>
    This website containts two pages 'BMI Calculator' and 'Retirement Calculator' which are designed
    to calculate body mass index and an age<br />
    at which one can retire respective to the inputs submitted.
    Below are the intructions for operating these calculators.
</p>
<br />

<h4>BMI Calculator</h4>
<h5>Input Values</h5>
<p style=""margin-left: 40px"">Enter your height in feet and in inches separately</p>
<p style=""margin-left: 70px"">-Note: feet must be a positive integer value</p>
<p style=""margin-left: 70px"">-Note: inches must be a positive integer value between 0-12 inclusive</p>
<p style=""margin-left: 40px"">Enter your weight in pounds</p>
<p style=""margin-left: 70px"">-Note: weight must be a positive integer value</p>
<h5>Submit and Calculate</h5>
<p style=""margin-left: 40px"">Once all values are entered click the 'Calculate' button</p>
<p style=""margin-left: 70px"">
    -Note: if the values are unacceptable, a message will<br />
    appear and your BMI will not be");
            WriteLiteral(@" calculated</p>
<h5>View Result</h5>
<p style=""margin-left: 40px"">Your result BMI and category will be displayed at the top of the screen</p><br />

<h4>Retirement Calculator</h4>
<h5>Input Values</h5>
<p style=""margin-left: 40px"">Enter your age, salary, percentage of salary saved, and savings goal separately</p>
<p style=""margin-left: 70px"">-Note: age must be a positive interger between 0-99 inclusive</p>
<p style=""margin-left: 70px"">-Note: salary must be a positive integer</p>
<p style=""margin-left: 70px"">
    -Note: percent saved must be a positive integer between 0-100 inclusive<br />
    (do not enter the percent '%' symbol)
</p>
<p style=""margin-left: 70px"">-Note: savings goal must be a positive interger</p>
<h5>Submit and Calculate</h5>
<p style=""margin-left: 40px"">Once all values are entered click the 'Calculate' button</p>
<p style=""margin-left: 70px"">
    -Note: if the values are unacceptable, a message will<br />
    appear and your Retirement Age will not be calculated</p>
<h5>V");
            WriteLiteral("iew Result</h5>\r\n<p style=\"margin-left: 40px\">Your result Retirement Age and whether you<br />\r\n    will meet your goal or not will be displayed at the top of the screen</p>");
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
