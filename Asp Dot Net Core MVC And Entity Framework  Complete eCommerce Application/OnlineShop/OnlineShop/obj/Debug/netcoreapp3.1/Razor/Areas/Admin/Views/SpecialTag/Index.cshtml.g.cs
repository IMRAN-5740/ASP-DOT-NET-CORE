#pragma checksum "E:\ASP DOT NET CORE\Asp Dot Net Core MVC And Entity Framework  Complete eCommerce Application\OnlineShop\OnlineShop\Areas\Admin\Views\SpecialTag\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5b415d72549a74727423d502317ea0c3470b1a2a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_SpecialTag_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/SpecialTag/Index.cshtml")]
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
#nullable restore
#line 1 "E:\ASP DOT NET CORE\Asp Dot Net Core MVC And Entity Framework  Complete eCommerce Application\OnlineShop\OnlineShop\Areas\Admin\Views\_ViewImports.cshtml"
using OnlineShop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "E:\ASP DOT NET CORE\Asp Dot Net Core MVC And Entity Framework  Complete eCommerce Application\OnlineShop\OnlineShop\Areas\Admin\Views\SpecialTag\Index.cshtml"
using OnlineShop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b415d72549a74727423d502317ea0c3470b1a2a", @"/Areas/Admin/Views/SpecialTag/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d90dc07541a5c6d64c93e024fee34b85f8e0e69", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_SpecialTag_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SpecialTag>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ButtonPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "E:\ASP DOT NET CORE\Asp Dot Net Core MVC And Entity Framework  Complete eCommerce Application\OnlineShop\OnlineShop\Areas\Admin\Views\SpecialTag\Index.cshtml"
  
    ViewData["Title"] = "Index";
    int serialNo = 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("<style>\r\n    .table-info th {\r\n        text-align: center;\r\n    }\r\n</style>\r\n<br /><br />\r\n<div class=\"row\">\r\n    <div class=\"col-6\">\r\n        <h2 class=\"text-info\">Special Tag List</h2>\r\n    </div>\r\n    <div class=\"col-6 text-right\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5b415d72549a74727423d502317ea0c3470b1a2a5098", async() => {
                WriteLiteral("<i class=\"fa-solid fa-plus\"></i>&nbsp; New Special Tag");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n<br />\r\n\r\n\r\n\r\n<div>\r\n    <table class=\"table table-bordered\">\r\n        <tr class=\"table-info\">\r\n            <th>Serial No</th>\r\n            <th>");
#nullable restore
#line 29 "E:\ASP DOT NET CORE\Asp Dot Net Core MVC And Entity Framework  Complete eCommerce Application\OnlineShop\OnlineShop\Areas\Admin\Views\SpecialTag\Index.cshtml"
           Write(Html.DisplayNameFor(c=>c.SpecialTagName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <th>Action</th>\r\n\r\n        </tr>\r\n");
#nullable restore
#line 33 "E:\ASP DOT NET CORE\Asp Dot Net Core MVC And Entity Framework  Complete eCommerce Application\OnlineShop\OnlineShop\Areas\Admin\Views\SpecialTag\Index.cshtml"
         foreach (var data in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n               \r\n                <td>");
#nullable restore
#line 37 "E:\ASP DOT NET CORE\Asp Dot Net Core MVC And Entity Framework  Complete eCommerce Application\OnlineShop\OnlineShop\Areas\Admin\Views\SpecialTag\Index.cshtml"
                Write(serialNo++);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 38 "E:\ASP DOT NET CORE\Asp Dot Net Core MVC And Entity Framework  Complete eCommerce Application\OnlineShop\OnlineShop\Areas\Admin\Views\SpecialTag\Index.cshtml"
               Write(data.SpecialTagName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                \r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5b415d72549a74727423d502317ea0c3470b1a2a8038", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#nullable restore
#line 40 "E:\ASP DOT NET CORE\Asp Dot Net Core MVC And Entity Framework  Complete eCommerce Application\OnlineShop\OnlineShop\Areas\Admin\Views\SpecialTag\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = data.Id;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("                \r\n\r\n            </tr>\r\n");
#nullable restore
#line 43 "E:\ASP DOT NET CORE\Asp Dot Net Core MVC And Entity Framework  Complete eCommerce Application\OnlineShop\OnlineShop\Areas\Admin\Views\SpecialTag\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </table>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n   \r\n    <script type=\"text/javascript\">\r\n        $(function () {\r\n            var add = \'");
#nullable restore
#line 53 "E:\ASP DOT NET CORE\Asp Dot Net Core MVC And Entity Framework  Complete eCommerce Application\OnlineShop\OnlineShop\Areas\Admin\Views\SpecialTag\Index.cshtml"
                  Write(TempData["add"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\'\r\n            if (add != \'\') {\r\n                alertify.success(add);\r\n\r\n            }\r\n        })\r\n    </script>\r\n\r\n    <script type=\"text/javascript\">\r\n        $(function () {\r\n            var edit = \'");
#nullable restore
#line 63 "E:\ASP DOT NET CORE\Asp Dot Net Core MVC And Entity Framework  Complete eCommerce Application\OnlineShop\OnlineShop\Areas\Admin\Views\SpecialTag\Index.cshtml"
                   Write(TempData["edit"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\'\r\n            if (edit != \'\') {\r\n                alertify.warning(edit);\r\n            }\r\n        })\r\n    </script>\r\n    <script type=\"text/javascript\">\r\n        $(function () {\r\n            var done = \'");
#nullable restore
#line 71 "E:\ASP DOT NET CORE\Asp Dot Net Core MVC And Entity Framework  Complete eCommerce Application\OnlineShop\OnlineShop\Areas\Admin\Views\SpecialTag\Index.cshtml"
                   Write(TempData["done"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\'\r\n            if (done != \'\') {\r\n                alertify.error(done);\r\n\r\n            }\r\n        })\r\n    </script>\r\n\r\n");
            }
            );
            WriteLiteral("\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SpecialTag>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
