#pragma checksum "C:\Users\Livi\Desktop\C#\ORM\ChefsDishes\Views\Home\allchefs.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "73aa20bba644e7a66465c3786b9ea00e389412fe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MyApp.Namespace.Home.Views_Home_allchefs), @"mvc.1.0.view", @"/Views/Home/allchefs.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/allchefs.cshtml", typeof(MyApp.Namespace.Home.Views_Home_allchefs))]
namespace MyApp.Namespace.Home
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 2 "C:\Users\Livi\Desktop\C#\ORM\ChefsDishes\Views\_ViewImports.cshtml"
using ChefsDishes.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"73aa20bba644e7a66465c3786b9ea00e389412fe", @"/Views/Home/allchefs.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b3ae46ab5d9b91528dfcf84873663e2ce6e65813", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_allchefs : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Chef>>
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(19, 37, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            EndContext();
            BeginContext(56, 373, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "73aa20bba644e7a66465c3786b9ea00e389412fe3245", async() => {
                BeginContext(62, 360, true);
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <title>Chefs and Dishes</title>
    <link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/css/bootstrap.min.css"" integrity=""sha384-9aIt2nRpC12Uk9gS9baDl411NQApFmC26EwAOH8WgZl5MYYxFfc+NcPb1dKGj7Sk"" crossorigin=""anonymous"">
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(429, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(431, 1151, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "73aa20bba644e7a66465c3786b9ea00e389412fe4799", async() => {
                BeginContext(437, 566, true);
                WriteLiteral(@"


    <div class = ""row"">
        <h1 class = ""col-sm-12 text-center""> Chefs | <a href = ""alldishes"">Dishes</a> </h1>
        <div class = ""container"">
            <h3>Check out our roster of chefs!</h3>
        
        <p><a href = ""addchef""> Add a Chef </a></p>
        
            <div class=""row"">
                <table class=""table"">
                    <thead>
                        <th>Name</th>
                        <th>Age</th>
                        <th># of Dishes</th>
                    </thead>
                    <tbody>
");
                EndContext();
#line 29 "C:\Users\Livi\Desktop\C#\ORM\ChefsDishes\Views\Home\allchefs.cshtml"
                         foreach(Chef trait in Model)
                        {
                            int age = DateTime.Today.Year - trait.DateOfBirth.Year;

#line default
#line hidden
                BeginContext(1170, 70, true);
                WriteLiteral("                            <tr>\r\n                                <td>");
                EndContext();
                BeginContext(1241, 15, false);
#line 33 "C:\Users\Livi\Desktop\C#\ORM\ChefsDishes\Views\Home\allchefs.cshtml"
                               Write(trait.FirstName);

#line default
#line hidden
                EndContext();
                BeginContext(1256, 1, true);
                WriteLiteral(" ");
                EndContext();
                BeginContext(1258, 14, false);
#line 33 "C:\Users\Livi\Desktop\C#\ORM\ChefsDishes\Views\Home\allchefs.cshtml"
                                                Write(trait.LastName);

#line default
#line hidden
                EndContext();
                BeginContext(1272, 43, true);
                WriteLiteral("</td>\r\n                                <td>");
                EndContext();
                BeginContext(1316, 3, false);
#line 34 "C:\Users\Livi\Desktop\C#\ORM\ChefsDishes\Views\Home\allchefs.cshtml"
                               Write(age);

#line default
#line hidden
                EndContext();
                BeginContext(1319, 43, true);
                WriteLiteral("</td>\r\n                                <td>");
                EndContext();
                BeginContext(1363, 29, false);
#line 35 "C:\Users\Livi\Desktop\C#\ORM\ChefsDishes\Views\Home\allchefs.cshtml"
                               Write(trait.ThisChefsDishes.Count());

#line default
#line hidden
                EndContext();
                BeginContext(1392, 42, true);
                WriteLiteral("</td>\r\n                            </tr>\r\n");
                EndContext();
#line 37 "C:\Users\Livi\Desktop\C#\ORM\ChefsDishes\Views\Home\allchefs.cshtml"
                        }

#line default
#line hidden
                BeginContext(1461, 114, true);
                WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n            </div>\r\n        </div>\r\n\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Chef>> Html { get; private set; }
    }
}
#pragma warning restore 1591
