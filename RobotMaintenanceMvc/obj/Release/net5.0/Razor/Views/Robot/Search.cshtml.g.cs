#pragma checksum "C:\Users\mehmetyen\source\repos\RobotMaintenance\RobotMaintenanceMvc\Views\Robot\Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b259cd3431d74a86216fed61d0ec7035fbd9898d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Robot_Search), @"mvc.1.0.view", @"/Views/Robot/Search.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b259cd3431d74a86216fed61d0ec7035fbd9898d", @"/Views/Robot/Search.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"82c112082cfbb1c52093a18ca25afab572666c79", @"/Views/_ViewImports.cshtml")]
    public class Views_Robot_Search : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RobotListDto>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""main"">
    <!-- MAIN CONTENT -->
    <div class=""main-content"">
        <div class=""container-fluid"">
            <h2 class=""page-title"" style=""text-align:center""><strong>ROBOTLAR</strong></h2>
            <div class=""row"">
                <div class=""col-md-12"">
                    <div class=""panel"">
                        <div class=""panel-body"">
                            <div class=""panel-heading"">
                                <h3 class=""panel-title"" style=""text-align:center""><strong>Robot Bilgileri</strong></h3>
                                <br />
");
#nullable restore
#line 14 "C:\Users\mehmetyen\source\repos\RobotMaintenance\RobotMaintenanceMvc\Views\Robot\Search.cshtml"
                                 if (Model != null)
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\mehmetyen\source\repos\RobotMaintenance\RobotMaintenanceMvc\Views\Robot\Search.cshtml"
                                     if (Model.Robots.Count > 0)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                        <table class=""table table-striped"">
                                            <thead>
                                                <tr>
                                                    <th>Robot İsmi</th>
                                                    <th>Robot Kategorisi</th>
                                                    <th>Robot Açıklaması</th>
");
#nullable restore
#line 24 "C:\Users\mehmetyen\source\repos\RobotMaintenance\RobotMaintenanceMvc\Views\Robot\Search.cshtml"
                                                     if (User.IsInRole("Engineer") || User.IsInRole("Admin") || User.IsInRole("SuperAdmin"))
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <th>Araçlar</th>\r\n");
#nullable restore
#line 27 "C:\Users\mehmetyen\source\repos\RobotMaintenance\RobotMaintenanceMvc\Views\Robot\Search.cshtml"
                                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                </tr>\r\n                                            </thead>\r\n                                            <tbody>\r\n");
#nullable restore
#line 31 "C:\Users\mehmetyen\source\repos\RobotMaintenance\RobotMaintenanceMvc\Views\Robot\Search.cshtml"
                                                 foreach (var item in Model.Robots)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <tr>\r\n                                                        <td>");
#nullable restore
#line 34 "C:\Users\mehmetyen\source\repos\RobotMaintenance\RobotMaintenanceMvc\Views\Robot\Search.cshtml"
                                                       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                        <td>");
#nullable restore
#line 35 "C:\Users\mehmetyen\source\repos\RobotMaintenance\RobotMaintenanceMvc\Views\Robot\Search.cshtml"
                                                       Write(item.RobotCategory.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                        <td>");
#nullable restore
#line 36 "C:\Users\mehmetyen\source\repos\RobotMaintenance\RobotMaintenanceMvc\Views\Robot\Search.cshtml"
                                                       Write(item.Note);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 37 "C:\Users\mehmetyen\source\repos\RobotMaintenance\RobotMaintenanceMvc\Views\Robot\Search.cshtml"
                                                         if (User.IsInRole("Engineer") || User.IsInRole("Admin") || User.IsInRole("SuperAdmin"))
                                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <td>\r\n                                                            <a class=\"btn btn-warning\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2497, "\"", 2526, 3);
            WriteAttributeValue("", 2507, "editRobot(", 2507, 10, true);
#nullable restore
#line 40 "C:\Users\mehmetyen\source\repos\RobotMaintenance\RobotMaintenanceMvc\Views\Robot\Search.cshtml"
WriteAttributeValue("", 2517, item.Id, 2517, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2525, ")", 2525, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                                Düzenle\r\n                                                            </a>\r\n                                                            <a class=\"btn btn-primary\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2755, "\"", 2785, 3);
            WriteAttributeValue("", 2765, "addProject(", 2765, 11, true);
#nullable restore
#line 43 "C:\Users\mehmetyen\source\repos\RobotMaintenance\RobotMaintenanceMvc\Views\Robot\Search.cshtml"
WriteAttributeValue("", 2776, item.Id, 2776, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2784, ")", 2784, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                                Projeye Ekle\r\n                                                            </a>\r\n                                                        </td>\r\n");
#nullable restore
#line 47 "C:\Users\mehmetyen\source\repos\RobotMaintenance\RobotMaintenanceMvc\Views\Robot\Search.cshtml"
                                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    </tr>\r\n");
#nullable restore
#line 49 "C:\Users\mehmetyen\source\repos\RobotMaintenance\RobotMaintenanceMvc\Views\Robot\Search.cshtml"
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            </tbody>\r\n                                        </table>\r\n");
#nullable restore
#line 52 "C:\Users\mehmetyen\source\repos\RobotMaintenance\RobotMaintenanceMvc\Views\Robot\Search.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <center><i>Robot bulunamadı!</i></center>\r\n");
#nullable restore
#line 56 "C:\Users\mehmetyen\source\repos\RobotMaintenance\RobotMaintenanceMvc\Views\Robot\Search.cshtml"
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 56 "C:\Users\mehmetyen\source\repos\RobotMaintenance\RobotMaintenanceMvc\Views\Robot\Search.cshtml"
                                     
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <center><i>Robot bulunamadı!</i></center>\r\n");
#nullable restore
#line 61 "C:\Users\mehmetyen\source\repos\RobotMaintenance\RobotMaintenanceMvc\Views\Robot\Search.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<div id=""editRobotModalPage""></div>
<div id=""editAddProjectModalPage""></div>
<script>
    // =======================
    function editRobot(robotId) {
        $.ajax({
            url: '/Robot/Edit/?Id=' + robotId,
            success: function (data) {
                $('#editRobotModalPage').html(data);
                $('#editRobotModal').modal('show');
            }
        });
    }
    // =======================
    // =======================
    function addProject(robotId) {
        $.ajax({
            url: '/Robot/AddProjectRobot/?Id=' + robotId,
            success: function (data) {
                $('#editAddProjectModalPage').html(data);
                $('#editAddProjectModal').modal('show');
            }
        });
    }
    // =======================
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RobotListDto> Html { get; private set; }
    }
}
#pragma warning restore 1591
