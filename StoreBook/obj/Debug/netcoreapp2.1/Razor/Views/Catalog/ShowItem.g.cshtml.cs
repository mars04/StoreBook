#pragma checksum "C:\Users\Andrey\source\repos\StoreBook\StoreBook\Views\Catalog\ShowItem.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "13797161bee332ae53a7c7287e34ae769b106559"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Catalog_ShowItem), @"mvc.1.0.view", @"/Views/Catalog/ShowItem.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Catalog/ShowItem.cshtml", typeof(AspNetCore.Views_Catalog_ShowItem))]
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
#line 1 "C:\Users\Andrey\source\repos\StoreBook\StoreBook\Views\_ViewImports.cshtml"
using StoreBook;

#line default
#line hidden
#line 2 "C:\Users\Andrey\source\repos\StoreBook\StoreBook\Views\_ViewImports.cshtml"
using StoreBook.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13797161bee332ae53a7c7287e34ae769b106559", @"/Views/Catalog/ShowItem.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a073da7e78a8bd6988169c5e015590fd708eb219", @"/Views/_ViewImports.cshtml")]
    public class Views_Catalog_ShowItem : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<StoreBook.Models.Book>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Catalog", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(30, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Andrey\source\repos\StoreBook\StoreBook\Views\Catalog\ShowItem.cshtml"
  
    ViewData["Title"] = "Информация о книге";

#line default
#line hidden
            BeginContext(86, 48, true);
            WriteLiteral("\r\n<h2>Информация о книге</h2>\r\n\r\n<div>\r\n    <h3>");
            EndContext();
            BeginContext(135, 36, false);
#line 10 "C:\Users\Andrey\source\repos\StoreBook\StoreBook\Views\Catalog\ShowItem.cshtml"
   Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(171, 84, true);
            WriteLiteral("</h3>\r\n    <hr />\r\n    <table>\r\n        <tr>\r\n            <td>\r\n                <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 255, "\"", 308, 2);
            WriteAttributeValue("", 261, "../../", 261, 6, true);
#line 15 "C:\Users\Andrey\source\repos\StoreBook\StoreBook\Views\Catalog\ShowItem.cshtml"
WriteAttributeValue("", 267, Html.DisplayFor(model => model.ImageURL), 267, 41, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(309, 92, true);
            WriteLiteral(" alt=\"\" />\r\n            </td>\r\n            <td style=\"padding-left:30px;\">\r\n                ");
            EndContext();
            BeginContext(402, 43, false);
#line 18 "C:\Users\Andrey\source\repos\StoreBook\StoreBook\Views\Catalog\ShowItem.cshtml"
           Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(445, 170, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n    </table>\r\n\r\n    <br>\r\n    <br>\r\n    <table>\r\n        <tr>\r\n            <td width=\"100\">\r\n                <b>\r\n                    ");
            EndContext();
            BeginContext(616, 40, false);
#line 29 "C:\Users\Andrey\source\repos\StoreBook\StoreBook\Views\Catalog\ShowItem.cshtml"
               Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(656, 77, true);
            WriteLiteral("\r\n                </b>\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(734, 36, false);
#line 33 "C:\Users\Andrey\source\repos\StoreBook\StoreBook\Views\Catalog\ShowItem.cshtml"
           Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(770, 109, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n        <tr>\r\n            <td>\r\n                <b>\r\n                    ");
            EndContext();
            BeginContext(880, 42, false);
#line 39 "C:\Users\Andrey\source\repos\StoreBook\StoreBook\Views\Catalog\ShowItem.cshtml"
               Write(Html.DisplayNameFor(model => model.Author));

#line default
#line hidden
            EndContext();
            BeginContext(922, 77, true);
            WriteLiteral("\r\n                </b>\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1000, 43, false);
#line 43 "C:\Users\Andrey\source\repos\StoreBook\StoreBook\Views\Catalog\ShowItem.cshtml"
           Write(Html.DisplayFor(model => model.Author.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1043, 109, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n        <tr>\r\n            <td>\r\n                <b>\r\n                    ");
            EndContext();
            BeginContext(1153, 41, false);
#line 49 "C:\Users\Andrey\source\repos\StoreBook\StoreBook\Views\Catalog\ShowItem.cshtml"
               Write(Html.DisplayNameFor(model => model.Genre));

#line default
#line hidden
            EndContext();
            BeginContext(1194, 77, true);
            WriteLiteral("\r\n                </b>\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1272, 42, false);
#line 53 "C:\Users\Andrey\source\repos\StoreBook\StoreBook\Views\Catalog\ShowItem.cshtml"
           Write(Html.DisplayFor(model => model.Genre.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1314, 109, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n        <tr>\r\n            <td>\r\n                <b>\r\n                    ");
            EndContext();
            BeginContext(1424, 42, false);
#line 59 "C:\Users\Andrey\source\repos\StoreBook\StoreBook\Views\Catalog\ShowItem.cshtml"
               Write(Html.DisplayNameFor(model => model.Editor));

#line default
#line hidden
            EndContext();
            BeginContext(1466, 77, true);
            WriteLiteral("\r\n                </b>\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1544, 43, false);
#line 63 "C:\Users\Andrey\source\repos\StoreBook\StoreBook\Views\Catalog\ShowItem.cshtml"
           Write(Html.DisplayFor(model => model.Editor.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1587, 109, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n        <tr>\r\n            <td>\r\n                <b>\r\n                    ");
            EndContext();
            BeginContext(1697, 43, false);
#line 69 "C:\Users\Andrey\source\repos\StoreBook\StoreBook\Views\Catalog\ShowItem.cshtml"
               Write(Html.DisplayNameFor(model => model.Publish));

#line default
#line hidden
            EndContext();
            BeginContext(1740, 77, true);
            WriteLiteral("\r\n                </b>\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1818, 44, false);
#line 73 "C:\Users\Andrey\source\repos\StoreBook\StoreBook\Views\Catalog\ShowItem.cshtml"
           Write(Html.DisplayFor(model => model.Publish.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1862, 109, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n        <tr>\r\n            <td>\r\n                <b>\r\n                    ");
            EndContext();
            BeginContext(1972, 42, false);
#line 79 "C:\Users\Andrey\source\repos\StoreBook\StoreBook\Views\Catalog\ShowItem.cshtml"
               Write(Html.DisplayNameFor(model => model.Series));

#line default
#line hidden
            EndContext();
            BeginContext(2014, 77, true);
            WriteLiteral("\r\n                </b>\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2092, 43, false);
#line 83 "C:\Users\Andrey\source\repos\StoreBook\StoreBook\Views\Catalog\ShowItem.cshtml"
           Write(Html.DisplayFor(model => model.Series.Name));

#line default
#line hidden
            EndContext();
            BeginContext(2135, 81, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n    </table>\r\n</div>\r\n\r\n<br><br>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(2216, 70, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cc93563d21254d2f94da3c368cc5ade1", async() => {
                BeginContext(2263, 19, true);
                WriteLiteral("Вернуться в каталог");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2286, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<StoreBook.Models.Book> Html { get; private set; }
    }
}
#pragma warning restore 1591