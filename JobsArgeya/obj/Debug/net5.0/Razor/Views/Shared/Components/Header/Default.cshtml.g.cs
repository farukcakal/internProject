#pragma checksum "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Views\Shared\Components\Header\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ec4bf2c61086947b03ec81d053a6c2f294ff3d22"
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
#line 1 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Views\_ViewImports.cshtml"
using JobsArgeya;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Views\_ViewImports.cshtml"
using JobsArgeya.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Views\_ViewImports.cshtml"
using JobsArgeya.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Views\_ViewImports.cshtml"
using JobsArgeya.Controllers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec4bf2c61086947b03ec81d053a6c2f294ff3d22", @"/Views/Shared/Components/Header/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2367a732b4f84062c0df738a061f503c1dff067a", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Header_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SettingsModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"toolbar-area hidden-md\"");
            BeginWriteAttribute("style", " style=\"", 57, "\"", 105, 3);
            WriteAttributeValue("", 65, "background:", 65, 11, true);
#nullable restore
#line 2 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Views\Shared\Components\Header\Default.cshtml"
WriteAttributeValue(" ", 76, Model.SiteColor, 77, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 93, "!important;", 94, 12, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"col-md-5\">\r\n                <div class=\"toolbar-contact\">\r\n                    <ul>\r\n                        <li><i class=\"flaticon-email\"></i><a");
            BeginWriteAttribute("href", " href=\"", 334, "\"", 360, 2);
            WriteAttributeValue("", 341, "mailto:", 341, 7, true);
#nullable restore
#line 8 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Views\Shared\Components\Header\Default.cshtml"
WriteAttributeValue("", 348, Model.Email, 348, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 8 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Views\Shared\Components\Header\Default.cshtml"
                                                                                   Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n                        <li><i class=\"flaticon-call\"></i><a");
            BeginWriteAttribute("href", " href=\"", 444, "\"", 467, 2);
            WriteAttributeValue("", 451, "tel:", 451, 4, true);
#nullable restore
#line 9 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Views\Shared\Components\Header\Default.cshtml"
WriteAttributeValue("", 455, Model.Phone, 455, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 9 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Views\Shared\Components\Header\Default.cshtml"
                                                                               Write(Model.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n                    </ul>\r\n                </div>\r\n            </div>\r\n            <div class=\"col-md-7\">\r\n                <div class=\"toolbar-sl-share\">\r\n                    <ul>\r\n                        <li><a");
            BeginWriteAttribute("href", " href=\"", 703, "\"", 725, 1);
#nullable restore
#line 16 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Views\Shared\Components\Header\Default.cshtml"
WriteAttributeValue("", 710, Model.Facebook, 710, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\"><i class=\"fa-brands fa-facebook\"></i></a></li>\r\n                        <li><a");
            BeginWriteAttribute("href", " href=\"", 821, "\"", 844, 1);
#nullable restore
#line 17 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Views\Shared\Components\Header\Default.cshtml"
WriteAttributeValue("", 828, Model.Instagram, 828, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\"><i class=\"fa-brands fa-instagram\"></i></a></li>\r\n                        <li><a");
            BeginWriteAttribute("href", " href=\"", 941, "\"", 962, 1);
#nullable restore
#line 18 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Views\Shared\Components\Header\Default.cshtml"
WriteAttributeValue("", 948, Model.Twitter, 948, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\"><i class=\"fa-brands fa-twitter\"></i></a></li>\r\n                        <li><a");
            BeginWriteAttribute("href", " href=\"", 1057, "\"", 1079, 1);
#nullable restore
#line 19 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Views\Shared\Components\Header\Default.cshtml"
WriteAttributeValue("", 1064, Model.Linkedin, 1064, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" target=""_blank""><i class=""fa-brands fa-linkedin""></i></a></li>
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
            BeginWriteAttribute("src", " src=\"", 1525, "\"", 1551, 2);
            WriteAttributeValue("", 1531, "/uploads/", 1531, 9, true);
#nullable restore
#line 32 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Views\Shared\Components\Header\Default.cshtml"
WriteAttributeValue("", 1540, Model.Logo, 1540, 11, false);

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
                                <a class=""rs-menu-toggle""");
            BeginWriteAttribute("style", " style=\"", 1920, "\"", 1963, 3);
            WriteAttributeValue("", 1928, "color:", 1928, 6, true);
#nullable restore
#line 39 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Views\Shared\Components\Header\Default.cshtml"
WriteAttributeValue(" ", 1934, Model.SiteColor, 1935, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 1951, "!important;", 1952, 12, true);
            EndWriteAttribute();
            WriteLiteral(@">
                                    <i class=""fa fa-bars""></i>
                                </a>
                            </div>
                            <nav class=""rs-menu pr-65"">
                                <ul class=""nav-menu"">
                                    <li>
                                        <a href=""/"">A????k Pozisyonlar</a>
                                    </li>
                                    <li>
                                        <a href=""/contact"">Bize Ula????n</a>
                                    </li>
                                </ul>
                            </nav>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</header>");
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
