#pragma checksum "C:\Users\k\Desktop\CSharp\RazorPractice\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b0383f4b0f4ea59b33ef3c91b18a4bf4627ed013"
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
#line 1 "C:\Users\k\Desktop\CSharp\RazorPractice\Views\_ViewImports.cshtml"
using RazorPractice;

#line default
#line hidden
#line 2 "C:\Users\k\Desktop\CSharp\RazorPractice\Views\_ViewImports.cshtml"
using RazorPractice.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0383f4b0f4ea59b33ef3c91b18a4bf4627ed013", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0f5af25f87d52b4f9bf4ebc6e6064ffbbe37bf0", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\k\Desktop\CSharp\RazorPractice\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(45, 31, true);
            WriteLiteral("<p>Current time and date:</p>\r\n");
            EndContext();
            BeginContext(77, 12, false);
#line 5 "C:\Users\k\Desktop\CSharp\RazorPractice\Views\Home\Index.cshtml"
Write(ViewBag.Time);

#line default
#line hidden
            EndContext();
            BeginContext(89, 43, true);
            WriteLiteral("\r\n<h1>Here are some delicious foods!</h1>\r\n");
            EndContext();
#line 7 "C:\Users\k\Desktop\CSharp\RazorPractice\Views\Home\Index.cshtml"
      
        var FoodList = new List<string>
        {
            "Apple Pie",
            "Burritos",
            "Clams Casino",
            "Donuts"
        };
        char C = 'C';
        foreach(var food in FoodList)
        {

#line default
#line hidden
            BeginContext(379, 19, true);
            WriteLiteral("            <div>\r\n");
            EndContext();
#line 19 "C:\Users\k\Desktop\CSharp\RazorPractice\Views\Home\Index.cshtml"
                 if(food[0] == C)
                {

#line default
#line hidden
            BeginContext(452, 47, true);
            WriteLiteral("                    <p><span style=\"color:red\">");
            EndContext();
            BeginContext(500, 4, false);
#line 21 "C:\Users\k\Desktop\CSharp\RazorPractice\Views\Home\Index.cshtml"
                                          Write(food);

#line default
#line hidden
            EndContext();
            BeginContext(504, 13, true);
            WriteLiteral("</span></p>\r\n");
            EndContext();
#line 22 "C:\Users\k\Desktop\CSharp\RazorPractice\Views\Home\Index.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(577, 23, true);
            WriteLiteral("                    <p>");
            EndContext();
            BeginContext(601, 4, false);
#line 25 "C:\Users\k\Desktop\CSharp\RazorPractice\Views\Home\Index.cshtml"
                  Write(food);

#line default
#line hidden
            EndContext();
            BeginContext(605, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 26 "C:\Users\k\Desktop\CSharp\RazorPractice\Views\Home\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(630, 20, true);
            WriteLiteral("            </div>\r\n");
            EndContext();
#line 28 "C:\Users\k\Desktop\CSharp\RazorPractice\Views\Home\Index.cshtml"
        }
    

#line default
#line hidden
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
