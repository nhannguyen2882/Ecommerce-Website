#pragma checksum "C:\Users\Nhàn Nguyễn\source\repos\MyWebsite\Ecommerce-Website\src\EcomWeb\EcomWeb.Identity4\Views\Shared\_ScopeListItem.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "956d70b9d3023d25a766d2e09577ee5ef3a4ff04"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__ScopeListItem), @"mvc.1.0.view", @"/Views/Shared/_ScopeListItem.cshtml")]
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
#line 1 "C:\Users\Nhàn Nguyễn\source\repos\MyWebsite\Ecommerce-Website\src\EcomWeb\EcomWeb.Identity4\Views\_ViewImports.cshtml"
using IdentityServerHost.Quickstart.UI;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"956d70b9d3023d25a766d2e09577ee5ef3a4ff04", @"/Views/Shared/_ScopeListItem.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a00496e1714fb62801584a343cc1019e13a800a", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__ScopeListItem : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ScopeViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<li class=\"list-group-item\">\r\n    <label>\r\n        <input class=\"consent-scopecheck\"\r\n               type=\"checkbox\"\r\n               name=\"ScopesConsented\"");
            BeginWriteAttribute("id", "\r\n               id=\"", 180, "\"", 220, 2);
            WriteAttributeValue("", 201, "scopes_", 201, 7, true);
#nullable restore
#line 8 "C:\Users\Nhàn Nguyễn\source\repos\MyWebsite\Ecommerce-Website\src\EcomWeb\EcomWeb.Identity4\Views\Shared\_ScopeListItem.cshtml"
WriteAttributeValue("", 208, Model.Value, 208, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("value", "\r\n               value=\"", 221, "\"", 257, 1);
#nullable restore
#line 9 "C:\Users\Nhàn Nguyễn\source\repos\MyWebsite\Ecommerce-Website\src\EcomWeb\EcomWeb.Identity4\Views\Shared\_ScopeListItem.cshtml"
WriteAttributeValue("", 245, Model.Value, 245, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("checked", "\r\n               checked=\"", 258, "\"", 298, 1);
#nullable restore
#line 10 "C:\Users\Nhàn Nguyễn\source\repos\MyWebsite\Ecommerce-Website\src\EcomWeb\EcomWeb.Identity4\Views\Shared\_ScopeListItem.cshtml"
WriteAttributeValue("", 284, Model.Checked, 284, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("disabled", "\r\n               disabled=\"", 299, "\"", 341, 1);
#nullable restore
#line 11 "C:\Users\Nhàn Nguyễn\source\repos\MyWebsite\Ecommerce-Website\src\EcomWeb\EcomWeb.Identity4\Views\Shared\_ScopeListItem.cshtml"
WriteAttributeValue("", 326, Model.Required, 326, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 12 "C:\Users\Nhàn Nguyễn\source\repos\MyWebsite\Ecommerce-Website\src\EcomWeb\EcomWeb.Identity4\Views\Shared\_ScopeListItem.cshtml"
         if (Model.Required)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <input type=\"hidden\"\r\n                   name=\"ScopesConsented\"");
            BeginWriteAttribute("value", "\r\n                   value=\"", 463, "\"", 503, 1);
#nullable restore
#line 16 "C:\Users\Nhàn Nguyễn\source\repos\MyWebsite\Ecommerce-Website\src\EcomWeb\EcomWeb.Identity4\Views\Shared\_ScopeListItem.cshtml"
WriteAttributeValue("", 491, Model.Value, 491, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 17 "C:\Users\Nhàn Nguyễn\source\repos\MyWebsite\Ecommerce-Website\src\EcomWeb\EcomWeb.Identity4\Views\Shared\_ScopeListItem.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <strong>");
#nullable restore
#line 18 "C:\Users\Nhàn Nguyễn\source\repos\MyWebsite\Ecommerce-Website\src\EcomWeb\EcomWeb.Identity4\Views\Shared\_ScopeListItem.cshtml"
           Write(Model.DisplayName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n");
#nullable restore
#line 19 "C:\Users\Nhàn Nguyễn\source\repos\MyWebsite\Ecommerce-Website\src\EcomWeb\EcomWeb.Identity4\Views\Shared\_ScopeListItem.cshtml"
         if (Model.Emphasize)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <span class=\"glyphicon glyphicon-exclamation-sign\"></span>\r\n");
#nullable restore
#line 22 "C:\Users\Nhàn Nguyễn\source\repos\MyWebsite\Ecommerce-Website\src\EcomWeb\EcomWeb.Identity4\Views\Shared\_ScopeListItem.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </label>\r\n");
#nullable restore
#line 24 "C:\Users\Nhàn Nguyễn\source\repos\MyWebsite\Ecommerce-Website\src\EcomWeb\EcomWeb.Identity4\Views\Shared\_ScopeListItem.cshtml"
     if (Model.Required)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <span><em>(required)</em></span>\r\n");
#nullable restore
#line 27 "C:\Users\Nhàn Nguyễn\source\repos\MyWebsite\Ecommerce-Website\src\EcomWeb\EcomWeb.Identity4\Views\Shared\_ScopeListItem.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Users\Nhàn Nguyễn\source\repos\MyWebsite\Ecommerce-Website\src\EcomWeb\EcomWeb.Identity4\Views\Shared\_ScopeListItem.cshtml"
     if (Model.Description != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"consent-description\">\r\n            <label");
            BeginWriteAttribute("for", " for=\"", 891, "\"", 916, 2);
            WriteAttributeValue("", 897, "scopes_", 897, 7, true);
#nullable restore
#line 31 "C:\Users\Nhàn Nguyễn\source\repos\MyWebsite\Ecommerce-Website\src\EcomWeb\EcomWeb.Identity4\Views\Shared\_ScopeListItem.cshtml"
WriteAttributeValue("", 904, Model.Value, 904, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 31 "C:\Users\Nhàn Nguyễn\source\repos\MyWebsite\Ecommerce-Website\src\EcomWeb\EcomWeb.Identity4\Views\Shared\_ScopeListItem.cshtml"
                                        Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n        </div>\r\n");
#nullable restore
#line 33 "C:\Users\Nhàn Nguyễn\source\repos\MyWebsite\Ecommerce-Website\src\EcomWeb\EcomWeb.Identity4\Views\Shared\_ScopeListItem.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ScopeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
