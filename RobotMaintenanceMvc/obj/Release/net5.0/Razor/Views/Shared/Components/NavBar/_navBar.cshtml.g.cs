#pragma checksum "C:\Users\mehmetyen\source\repos\RobotMaintenance\RobotMaintenanceMvc\Views\Shared\Components\NavBar\_navBar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "26d9743253f9c695f5be7b82116276c2188b97ac"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_NavBar__navBar), @"mvc.1.0.view", @"/Views/Shared/Components/NavBar/_navBar.cshtml")]
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
#line 1 "C:\Users\mehmetyen\source\repos\RobotMaintenance\RobotMaintenanceMvc\Views\_ViewImports.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mehmetyen\source\repos\RobotMaintenance\RobotMaintenanceMvc\Views\_ViewImports.cshtml"
using EntityLayer.Dtos.AppUserDtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\mehmetyen\source\repos\RobotMaintenance\RobotMaintenanceMvc\Views\_ViewImports.cshtml"
using EntityLayer.Dtos.CompleteMaintenanceEquipmentDtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\mehmetyen\source\repos\RobotMaintenance\RobotMaintenanceMvc\Views\_ViewImports.cshtml"
using EntityLayer.Dtos.CompleteMaintenanceRobotDtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\mehmetyen\source\repos\RobotMaintenance\RobotMaintenanceMvc\Views\_ViewImports.cshtml"
using EntityLayer.Dtos.EquipmentCategoryDtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\mehmetyen\source\repos\RobotMaintenance\RobotMaintenanceMvc\Views\_ViewImports.cshtml"
using EntityLayer.Dtos.EquipmentDtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\mehmetyen\source\repos\RobotMaintenance\RobotMaintenanceMvc\Views\_ViewImports.cshtml"
using EntityLayer.Dtos.EquipmentMaintenanceDtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\mehmetyen\source\repos\RobotMaintenance\RobotMaintenanceMvc\Views\_ViewImports.cshtml"
using EntityLayer.Dtos.EquipmentMaintenanceUserDtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\mehmetyen\source\repos\RobotMaintenance\RobotMaintenanceMvc\Views\_ViewImports.cshtml"
using EntityLayer.Dtos.FactoryDepartmentDtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\mehmetyen\source\repos\RobotMaintenance\RobotMaintenanceMvc\Views\_ViewImports.cshtml"
using EntityLayer.Dtos.FactoryDtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\mehmetyen\source\repos\RobotMaintenance\RobotMaintenanceMvc\Views\_ViewImports.cshtml"
using EntityLayer.Dtos.ProjectDtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\mehmetyen\source\repos\RobotMaintenance\RobotMaintenanceMvc\Views\_ViewImports.cshtml"
using EntityLayer.Dtos.ProjectEquipmentDtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\mehmetyen\source\repos\RobotMaintenance\RobotMaintenanceMvc\Views\_ViewImports.cshtml"
using EntityLayer.Dtos.ProjectResponsibleDtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\mehmetyen\source\repos\RobotMaintenance\RobotMaintenanceMvc\Views\_ViewImports.cshtml"
using EntityLayer.Dtos.ProjectRobotDtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\mehmetyen\source\repos\RobotMaintenance\RobotMaintenanceMvc\Views\_ViewImports.cshtml"
using EntityLayer.Dtos.RobotCategoryDtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\mehmetyen\source\repos\RobotMaintenance\RobotMaintenanceMvc\Views\_ViewImports.cshtml"
using EntityLayer.Dtos.RobotDtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\mehmetyen\source\repos\RobotMaintenance\RobotMaintenanceMvc\Views\_ViewImports.cshtml"
using EntityLayer.Dtos.RobotMaintenanceDtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\mehmetyen\source\repos\RobotMaintenance\RobotMaintenanceMvc\Views\_ViewImports.cshtml"
using EntityLayer.Dtos.RobotToBeMaintainedDtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\mehmetyen\source\repos\RobotMaintenance\RobotMaintenanceMvc\Views\_ViewImports.cshtml"
using EntityLayer.Dtos.RobotToBeMaintainedUserDtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\mehmetyen\source\repos\RobotMaintenance\RobotMaintenanceMvc\Views\_ViewImports.cshtml"
using EntityLayer.Dtos.FaultReportDtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\mehmetyen\source\repos\RobotMaintenance\RobotMaintenanceMvc\Views\_ViewImports.cshtml"
using EntityLayer.Dtos.ProjectReportDtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\mehmetyen\source\repos\RobotMaintenance\RobotMaintenanceMvc\Views\_ViewImports.cshtml"
using RobotMaintenanceMvc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26d9743253f9c695f5be7b82116276c2188b97ac", @"/Views/Shared/Components/NavBar/_navBar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"82c112082cfbb1c52093a18ca25afab572666c79", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_NavBar__navBar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NavBarViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height:82px;width:301px;margin-top:-27px;margin-left:-40px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/img/vestel-kirmizi-logo-buyuk1(1).png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Vestel Logo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-responsive logo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("navbar-form navbar-left"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Search", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Project", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/img/VestelMT.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-circle"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Avatar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<nav class=\"navbar navbar-default navbar-fixed-top\">\n    <div style=\"height:81px;\" class=\"brand\">\n        <a href=\"/Home/Index\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "26d9743253f9c695f5be7b82116276c2188b97ac11919", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</a>\n    </div>\n    <div class=\"container-fluid\">\n        <div style=\"margin-left:-60px\" class=\"navbar-btn\">\n            <button type=\"button\" class=\"btn-toggle-fullwidth\"><i class=\"lnr lnr-arrow-left-circle\"></i></button>\n        </div>        \n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "26d9743253f9c695f5be7b82116276c2188b97ac13468", async() => {
                WriteLiteral(@"
            <div class=""input-group"">
                <input type=""text"" name=""searchKey"" id=""searchKey"" class=""form-control"" placeholder=""Arama..."" required>
                <span class=""input-group-btn""><button onclick=""projectSearch()"" type=""button"" class=""btn btn-primary"">Projelerde Ara</button></span>
                <span class=""input-group-btn""><button onclick=""robotSearch()"" type=""button"" class=""btn btn-success"">Robotlarda Ara</button></span>
                <span class=""input-group-btn""><button onclick=""equipmentSearch()"" type=""button"" class=""btn btn-warning"">Ekipmanlarda Ara</button></span>
            </div>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n        <div id=\"navbar-menu\">\n            <ul class=\"nav navbar-nav navbar-right\">\n                <li class=\"dropdown\">\n");
#nullable restore
#line 22 "C:\Users\mehmetyen\source\repos\RobotMaintenance\RobotMaintenanceMvc\Views\Shared\Components\NavBar\_navBar.cshtml"
                     if (User.IsInRole("Admin") || User.IsInRole("SuperAdmin"))
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\mehmetyen\source\repos\RobotMaintenance\RobotMaintenanceMvc\Views\Shared\Components\NavBar\_navBar.cshtml"
                   Write(await Component.InvokeAsync("Notification"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\mehmetyen\source\repos\RobotMaintenance\RobotMaintenanceMvc\Views\Shared\Components\NavBar\_navBar.cshtml"
                                                                    
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </li>\n                <li class=\"dropdown\">\n");
#nullable restore
#line 28 "C:\Users\mehmetyen\source\repos\RobotMaintenance\RobotMaintenanceMvc\Views\Shared\Components\NavBar\_navBar.cshtml"
                       if (User.IsInRole("Admin") || User.IsInRole("SuperAdmin"))
                      {
                         

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\mehmetyen\source\repos\RobotMaintenance\RobotMaintenanceMvc\Views\Shared\Components\NavBar\_navBar.cshtml"
                    Write(await Component.InvokeAsync("NotificationRobot"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\mehmetyen\source\repos\RobotMaintenance\RobotMaintenanceMvc\Views\Shared\Components\NavBar\_navBar.cshtml"
                                                                          
                      }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </li>\n                    <li class=\"dropdown\">\n");
#nullable restore
#line 34 "C:\Users\mehmetyen\source\repos\RobotMaintenance\RobotMaintenanceMvc\Views\Shared\Components\NavBar\_navBar.cshtml"
                     if (User.IsInRole("User") || User.IsInRole("Engineer") || User.IsInRole("Chef") || User.IsInRole("SuperAdmin"))
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "C:\Users\mehmetyen\source\repos\RobotMaintenance\RobotMaintenanceMvc\Views\Shared\Components\NavBar\_navBar.cshtml"
                   Write(await Component.InvokeAsync("NotificationUser"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "C:\Users\mehmetyen\source\repos\RobotMaintenance\RobotMaintenanceMvc\Views\Shared\Components\NavBar\_navBar.cshtml"
                                                                        
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </li>\n                    <li class=\"dropdown\">\n");
#nullable restore
#line 40 "C:\Users\mehmetyen\source\repos\RobotMaintenance\RobotMaintenanceMvc\Views\Shared\Components\NavBar\_navBar.cshtml"
                         if (User.IsInRole("User") || User.IsInRole("Engineer") || User.IsInRole("Chef") || User.IsInRole("SuperAdmin"))
                        {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "C:\Users\mehmetyen\source\repos\RobotMaintenance\RobotMaintenanceMvc\Views\Shared\Components\NavBar\_navBar.cshtml"
               Write(await Component.InvokeAsync("NotificationRobotUser"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "C:\Users\mehmetyen\source\repos\RobotMaintenance\RobotMaintenanceMvc\Views\Shared\Components\NavBar\_navBar.cshtml"
                                                                         }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </li>\n                <li class=\"dropdown\">\n                    <a href=\"#\" class=\"dropdown-toggle\" data-toggle=\"dropdown\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "26d9743253f9c695f5be7b82116276c2188b97ac20309", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" <span style=\"text-transform:uppercase\">");
#nullable restore
#line 45 "C:\Users\mehmetyen\source\repos\RobotMaintenance\RobotMaintenanceMvc\Views\Shared\Components\NavBar\_navBar.cshtml"
                                                                                                                                                                                       Write(Model.AppUser.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 45 "C:\Users\mehmetyen\source\repos\RobotMaintenance\RobotMaintenanceMvc\Views\Shared\Components\NavBar\_navBar.cshtml"
                                                                                                                                                                                                                Write(Model.AppUser.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span> <i class=""icon-submenu lnr lnr-chevron-down""></i></a>
                    <ul class=""dropdown-menu"">
                        <li><a href=""/Account/Settings""><i class=""lnr lnr-cog""></i> <span>Hesap Ayarları</span></a></li>
                        <li><a href=""/Account/Logout""><i class=""lnr lnr-exit""></i> <span>Çıkış Yap</span></a></li>
                    </ul>
                </li>
            </ul>
        </div>
    </div>
</nav>
<script>
    function projectSearch() {
        window.location.href = '/Project/Search/?searchKey=' + $(""#searchKey"").val();
    }
    function robotSearch() {
        window.location.href = '/Robot/Search/?searchKey=' + $(""#searchKey"").val();
    }
    function equipmentSearch() {
        window.location.href = '/Equipment/Search/?searchKey=' + $(""#searchKey"").val();
    }
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NavBarViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
