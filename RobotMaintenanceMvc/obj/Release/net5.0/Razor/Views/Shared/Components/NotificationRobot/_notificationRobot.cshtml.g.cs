#pragma checksum "C:\Users\mehmetyen\source\repos\RobotMaintenance\RobotMaintenanceMvc\Views\Shared\Components\NotificationRobot\_notificationRobot.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "60b596faccdd084f1c9592c1992b7e407a91e7ea"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_NotificationRobot__notificationRobot), @"mvc.1.0.view", @"/Views/Shared/Components/NotificationRobot/_notificationRobot.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60b596faccdd084f1c9592c1992b7e407a91e7ea", @"/Views/Shared/Components/NotificationRobot/_notificationRobot.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"82c112082cfbb1c52093a18ca25afab572666c79", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_NotificationRobot__notificationRobot : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RobotToBeMaintainedListDto>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:30px;height:30px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/roboticon.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\mehmetyen\source\repos\RobotMaintenance\RobotMaintenanceMvc\Views\Shared\Components\NotificationRobot\_notificationRobot.cshtml"
      
    int notificationCount = 0;    
 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div id=""navbar-menu"">
            <ul class=""nav navbar-nav navbar-right"">
                <li class=""dropdown"">
                    <a style=""background-color:transparent"" href=""#"" class=""dropdown-toggle icon-menu"" data-toggle=""dropdown"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "60b596faccdd084f1c9592c1992b7e407a91e7ea9067", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 10 "C:\Users\mehmetyen\source\repos\RobotMaintenance\RobotMaintenanceMvc\Views\Shared\Components\NotificationRobot\_notificationRobot.cshtml"
                         if (Model.RobotToBeMaintained.Count > 0)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span style=\"margin-right:-4px\" class=\"badge bg-danger\">");
#nullable restore
#line 12 "C:\Users\mehmetyen\source\repos\RobotMaintenance\RobotMaintenanceMvc\Views\Shared\Components\NotificationRobot\_notificationRobot.cshtml"
                                                                       Write(Model.RobotToBeMaintained.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>");
#nullable restore
#line 12 "C:\Users\mehmetyen\source\repos\RobotMaintenance\RobotMaintenanceMvc\Views\Shared\Components\NotificationRobot\_notificationRobot.cshtml"
                                                                                                                   }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </a>\n                    <ul class=\"dropdown-menu notifications\">\n                        <li><a style=\"font-weight:bold\">ROBOT BAKIM ONAY BİLDİRİMLERİ</a></li>\n");
#nullable restore
#line 16 "C:\Users\mehmetyen\source\repos\RobotMaintenance\RobotMaintenanceMvc\Views\Shared\Components\NotificationRobot\_notificationRobot.cshtml"
                         foreach (var item in Model.RobotToBeMaintained)
                        {
                            if (notificationCount < 6)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li>\n                        <a href=\"/RobotToBeMaintained/RobotMaintenance\" class=\"notification-item\">\n                            <span class=\"dot bg-danger\"></span>\n                            <span style=\"font-weight:bold\">");
#nullable restore
#line 23 "C:\Users\mehmetyen\source\repos\RobotMaintenance\RobotMaintenanceMvc\Views\Shared\Components\NotificationRobot\_notificationRobot.cshtml"
                                                      Write(item.ProjectRobot.Project.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n                            <span>projesindeki</span>  <span style=\"font-weight:bold\">");
#nullable restore
#line 24 "C:\Users\mehmetyen\source\repos\RobotMaintenance\RobotMaintenanceMvc\Views\Shared\Components\NotificationRobot\_notificationRobot.cshtml"
                                                                                 Write(item.RobotMaintenance.Robot.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n                            <span>adlı robotun </span>\n                            <span style=\"font-weight:bold\">");
#nullable restore
#line 26 "C:\Users\mehmetyen\source\repos\RobotMaintenance\RobotMaintenanceMvc\Views\Shared\Components\NotificationRobot\_notificationRobot.cshtml"
                                                      Write(item.RobotMaintenance.Maintenance.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n                            <span>bakım onayı gelmiştir!</span>\n                        </a>\n                    </li>\n");
#nullable restore
#line 30 "C:\Users\mehmetyen\source\repos\RobotMaintenance\RobotMaintenanceMvc\Views\Shared\Components\NotificationRobot\_notificationRobot.cshtml"
                        notificationCount++;
                                        }
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\Users\mehmetyen\source\repos\RobotMaintenance\RobotMaintenanceMvc\Views\Shared\Components\NotificationRobot\_notificationRobot.cshtml"
                         if (Model.RobotToBeMaintained.Count == 0)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li><a href=\"#\" class=\"notification-item\"><span class=\"dot bg-success\"></span>Onaylanacak robot bakımı bulunmamaktadır.</a></li>\n");
#nullable restore
#line 36 "C:\Users\mehmetyen\source\repos\RobotMaintenance\RobotMaintenanceMvc\Views\Shared\Components\NotificationRobot\_notificationRobot.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li><a href=\"/RobotToBeMaintained/RobotMaintenance\" class=\"more\">Tüm bildirimler</a></li>\r\n");
#nullable restore
#line 40 "C:\Users\mehmetyen\source\repos\RobotMaintenance\RobotMaintenanceMvc\Views\Shared\Components\NotificationRobot\_notificationRobot.cshtml"
                        }                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </ul>\n                </li>\n            </ul>\n        </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RobotToBeMaintainedListDto> Html { get; private set; }
    }
}
#pragma warning restore 1591