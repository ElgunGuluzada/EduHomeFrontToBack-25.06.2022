#pragma checksum "D:\Asp.NetCore\EduHomeFrontToBack25062022\EduHomeFrontToBack25062022\Views\Shared\Components\Event\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4aa1338e557399cd859e8bbb0222e12d765c2cdd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Event_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Event/Default.cshtml")]
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
#line 1 "D:\Asp.NetCore\EduHomeFrontToBack25062022\EduHomeFrontToBack25062022\Views\_ViewImports.cshtml"
using EduHomeFrontToBack25062022.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Asp.NetCore\EduHomeFrontToBack25062022\EduHomeFrontToBack25062022\Views\_ViewImports.cshtml"
using EduHomeFrontToBack25062022.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4aa1338e557399cd859e8bbb0222e12d765c2cdd", @"/Views/Shared/Components/Event/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b94b9e002193b50af18a14f38e29f0522064a44", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_Event_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Event>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Asp.NetCore\EduHomeFrontToBack25062022\EduHomeFrontToBack25062022\Views\Shared\Components\Event\Default.cshtml"
     foreach (var item in Model)
   {

#line default
#line hidden
#nullable disable
            WriteLiteral("          <div class=\"single-event mb-35\">\r\n                            <div class=\"event-date\">\r\n                                <h3><a href=\"event-details.html\">");
#nullable restore
#line 7 "D:\Asp.NetCore\EduHomeFrontToBack25062022\EduHomeFrontToBack25062022\Views\Shared\Components\Event\Default.cshtml"
                                                            Write(item.StartTime.Day);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" <span>June</span></a></h3>
                            </div>
                            <div class=""event-content text-left"">
                                <div class=""event-content-left"">
                                    <h4><a href=""event-details.html"">");
#nullable restore
#line 11 "D:\Asp.NetCore\EduHomeFrontToBack25062022\EduHomeFrontToBack25062022\Views\Shared\Components\Event\Default.cshtml"
                                                                Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h4>\r\n                                    <ul>\r\n                                        <li><i class=\"fa fa-clock-o\"></i>");
#nullable restore
#line 13 "D:\Asp.NetCore\EduHomeFrontToBack25062022\EduHomeFrontToBack25062022\Views\Shared\Components\Event\Default.cshtml"
                                                                    Write(item.StartTime.Hour);

#line default
#line hidden
#nullable disable
            WriteLiteral(".");
#nullable restore
#line 13 "D:\Asp.NetCore\EduHomeFrontToBack25062022\EduHomeFrontToBack25062022\Views\Shared\Components\Event\Default.cshtml"
                                                                                         Write(item.StartTime.Minute);

#line default
#line hidden
#nullable disable
            WriteLiteral(" AM - ");
#nullable restore
#line 13 "D:\Asp.NetCore\EduHomeFrontToBack25062022\EduHomeFrontToBack25062022\Views\Shared\Components\Event\Default.cshtml"
                                                                                                                     Write(item.EndTime.Hour);

#line default
#line hidden
#nullable disable
            WriteLiteral(".");
#nullable restore
#line 13 "D:\Asp.NetCore\EduHomeFrontToBack25062022\EduHomeFrontToBack25062022\Views\Shared\Components\Event\Default.cshtml"
                                                                                                                                        Write(item.EndTime.Minute);

#line default
#line hidden
#nullable disable
            WriteLiteral(" PM</li>\r\n                                        <li><i class=\"fa fa-map-marker\"></i>");
#nullable restore
#line 14 "D:\Asp.NetCore\EduHomeFrontToBack25062022\EduHomeFrontToBack25062022\Views\Shared\Components\Event\Default.cshtml"
                                                                       Write(item.Location);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</li>
                                    </ul>
                                </div>
                                <div class=""event-content-right"">
                                    <a class=""default-btn"" href=""event-details.html"">join now</a>
                                </div>
                            </div>
                        </div>
");
#nullable restore
#line 22 "D:\Asp.NetCore\EduHomeFrontToBack25062022\EduHomeFrontToBack25062022\Views\Shared\Components\Event\Default.cshtml"
   }

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Event>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
