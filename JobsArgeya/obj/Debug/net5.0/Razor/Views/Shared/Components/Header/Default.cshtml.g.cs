#pragma checksum "C:\Users\Freeman\source\repos\JobsArgeya\JobsArgeya\Views\Shared\Components\Header\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "41b3b64014d0ff08ab4380c405b16fb7d257cc86"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Header_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Header/Default.cshtml")]
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
#line 1 "C:\Users\Freeman\source\repos\JobsArgeya\JobsArgeya\Views\_ViewImports.cshtml"
using JobsArgeya;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Freeman\source\repos\JobsArgeya\JobsArgeya\Views\_ViewImports.cshtml"
using JobsArgeya.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Freeman\source\repos\JobsArgeya\JobsArgeya\Views\_ViewImports.cshtml"
using JobsArgeya.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Freeman\source\repos\JobsArgeya\JobsArgeya\Views\_ViewImports.cshtml"
using JobsArgeya.Controllers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"41b3b64014d0ff08ab4380c405b16fb7d257cc86", @"/Views/Shared/Components/Header/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2367a732b4f84062c0df738a061f503c1dff067a", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Header_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SettingsModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""toolbar-area hidden-md"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-5"">
                <div class=""toolbar-contact"">
                    <ul>
                        <li><i class=""flaticon-email""></i><a");
            BeginWriteAttribute("href", " href=\"", 285, "\"", 311, 2);
            WriteAttributeValue("", 292, "mailto:", 292, 7, true);
#nullable restore
#line 8 "C:\Users\Freeman\source\repos\JobsArgeya\JobsArgeya\Views\Shared\Components\Header\Default.cshtml"
WriteAttributeValue("", 299, Model.email, 299, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 8 "C:\Users\Freeman\source\repos\JobsArgeya\JobsArgeya\Views\Shared\Components\Header\Default.cshtml"
                                                                                   Write(Model.email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n                        <li><i class=\"flaticon-call\"></i><a");
            BeginWriteAttribute("href", " href=\"", 395, "\"", 418, 2);
            WriteAttributeValue("", 402, "tel:", 402, 4, true);
#nullable restore
#line 9 "C:\Users\Freeman\source\repos\JobsArgeya\JobsArgeya\Views\Shared\Components\Header\Default.cshtml"
WriteAttributeValue("", 406, Model.phone, 406, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 9 "C:\Users\Freeman\source\repos\JobsArgeya\JobsArgeya\Views\Shared\Components\Header\Default.cshtml"
                                                                               Write(Model.phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n                    </ul>\r\n                </div>\r\n            </div>\r\n            <div class=\"col-md-7\">\r\n                <div class=\"toolbar-sl-share\">\r\n                    <ul>\r\n                        <li><a");
            BeginWriteAttribute("href", " href=\"", 654, "\"", 676, 1);
#nullable restore
#line 16 "C:\Users\Freeman\source\repos\JobsArgeya\JobsArgeya\Views\Shared\Components\Header\Default.cshtml"
WriteAttributeValue("", 661, Model.facebook, 661, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-facebook\"></i></a></li>\r\n                        <li><a");
            BeginWriteAttribute("href", " href=\"", 749, "\"", 772, 1);
#nullable restore
#line 17 "C:\Users\Freeman\source\repos\JobsArgeya\JobsArgeya\Views\Shared\Components\Header\Default.cshtml"
WriteAttributeValue("", 756, Model.instagram, 756, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-instagram\"></i></a></li>\r\n                        <li><a");
            BeginWriteAttribute("href", " href=\"", 846, "\"", 867, 1);
#nullable restore
#line 18 "C:\Users\Freeman\source\repos\JobsArgeya\JobsArgeya\Views\Shared\Components\Header\Default.cshtml"
WriteAttributeValue("", 853, Model.twitter, 853, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-twitter\"></i></a></li>\r\n                        <li><a");
            BeginWriteAttribute("href", " href=\"", 939, "\"", 961, 1);
#nullable restore
#line 19 "C:\Users\Freeman\source\repos\JobsArgeya\JobsArgeya\Views\Shared\Components\Header\Default.cshtml"
WriteAttributeValue("", 946, Model.linkedin, 946, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"><i class=""fa fa-linkedin""></i></a></li>
                    </ul>
                </div>
            </div>
        </div>
    </div>
</div>
<header id=""rs-header"" class=""rs-header"">
    <div class=""menu-area menu-sticky"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-8"">
                    <div class=""logo-area"">
                        <a href=""/""><img");
            BeginWriteAttribute("src", " src=\"", 1384, "\"", 1410, 2);
            WriteAttributeValue("", 1390, "/uploads/", 1390, 9, true);
#nullable restore
#line 32 "C:\Users\Freeman\source\repos\JobsArgeya\JobsArgeya\Views\Shared\Components\Header\Default.cshtml"
WriteAttributeValue("", 1399, Model.logo, 1399, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" alt=""logo"" style=""max-height:40px; height:40px;""></a>
                    </div>
                </div>
                <div class=""col-lg-4 text-right"">
                    <div class=""rs-menu-area"">
                        <div class=""main-menu"">
                            <div class=""mobile-menu"">
                                <a class=""rs-menu-toggle"" style=""color: #dc3545 !important;"">
                                    <i class=""fa fa-bars""></i>
                                </a>
                            </div>
                            <nav class=""rs-menu pr-65"">
                                <ul class=""nav-menu"">
                                    <li>
                                        <a href=""/"">Ana Sayfa</a>
                                    </li>

                                    <li>
                                        <a href=""https://argeya.com/tr/iletisim"">Bize Ulaşın</a>
                                    </li>
                               ");
            WriteLiteral(" </ul>\r\n                            </nav>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</header>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SettingsModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
