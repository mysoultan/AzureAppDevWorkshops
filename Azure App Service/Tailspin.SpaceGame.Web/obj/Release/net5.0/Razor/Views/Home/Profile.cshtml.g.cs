#pragma checksum "C:\Users\msoultan\source\repos\AzureAppDevWorkshops\Azure App Service\Tailspin.SpaceGame.Web\Views\Home\Profile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4aff22a3d4ac46aef1f9cfea3d96cce515915487"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Profile), @"mvc.1.0.view", @"/Views/Home/Profile.cshtml")]
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
#line 1 "C:\Users\msoultan\source\repos\AzureAppDevWorkshops\Azure App Service\Tailspin.SpaceGame.Web\Views\_ViewImports.cshtml"
using TailSpin.SpaceGame.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\msoultan\source\repos\AzureAppDevWorkshops\Azure App Service\Tailspin.SpaceGame.Web\Views\_ViewImports.cshtml"
using TailSpin.SpaceGame.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4aff22a3d4ac46aef1f9cfea3d96cce515915487", @"/Views/Home/Profile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b7b33b2f6980307f496d0875abd65e772ce9ec93", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Profile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TailSpin.SpaceGame.Web.Models.ProfileViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\msoultan\source\repos\AzureAppDevWorkshops\Azure App Service\Tailspin.SpaceGame.Web\Views\Home\Profile.cshtml"
  
    ViewData["Title"] = "@Model.Profile.UserName Profile";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"modal fade profile\"");
            BeginWriteAttribute("id", " id=\"", 153, "\"", 183, 2);
            WriteAttributeValue("", 158, "profile-modal-", 158, 14, true);
#nullable restore
#line 5 "C:\Users\msoultan\source\repos\AzureAppDevWorkshops\Azure App Service\Tailspin.SpaceGame.Web\Views\Home\Profile.cshtml"
WriteAttributeValue("", 172, Model.Rank, 172, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" tabindex=""-1"" role=""dialog"" aria-labelledby=""myModalLabel"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header no-border"">
                <button type=""button"" class=""close"" data-dismiss=""modal"">&times;</button>
            </div>
            <div class=""modal-body"">
                <div class=""row"">
                    <div class=""col-sm-4"">
                        <div class=""avatar"">
                            <div");
            BeginWriteAttribute("style", " style=\"", 687, "\"", 744, 3);
            WriteAttributeValue("", 695, "background-image:url(\'", 695, 22, true);
#nullable restore
#line 15 "C:\Users\msoultan\source\repos\AzureAppDevWorkshops\Azure App Service\Tailspin.SpaceGame.Web\Views\Home\Profile.cshtml"
WriteAttributeValue("", 717, Model.Profile.AvatarUrl, 717, 24, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 741, "\');", 741, 3, true);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"col-sm-8\">\r\n                        <div class=\"content\">\r\n                            <h1>");
#nullable restore
#line 20 "C:\Users\msoultan\source\repos\AzureAppDevWorkshops\Azure App Service\Tailspin.SpaceGame.Web\Views\Home\Profile.cshtml"
                           Write(Model.Profile.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                            <b>Rank #");
#nullable restore
#line 21 "C:\Users\msoultan\source\repos\AzureAppDevWorkshops\Azure App Service\Tailspin.SpaceGame.Web\Views\Home\Profile.cshtml"
                                Write(Model.Rank);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n                            <h2>Achievements</h2>\r\n                            <ul>\r\n");
#nullable restore
#line 24 "C:\Users\msoultan\source\repos\AzureAppDevWorkshops\Azure App Service\Tailspin.SpaceGame.Web\Views\Home\Profile.cshtml"
                                 foreach (var achievement in Model.Profile.Achievements)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li>");
#nullable restore
#line 26 "C:\Users\msoultan\source\repos\AzureAppDevWorkshops\Azure App Service\Tailspin.SpaceGame.Web\Views\Home\Profile.cshtml"
                                   Write(achievement);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 27 "C:\Users\msoultan\source\repos\AzureAppDevWorkshops\Azure App Service\Tailspin.SpaceGame.Web\Views\Home\Profile.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </ul>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TailSpin.SpaceGame.Web.Models.ProfileViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
