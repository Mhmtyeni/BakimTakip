#pragma checksum "C:\Users\mehmetyen\Desktop\RobotMaintenance\RobotMaintenanceMvc\Views\Project\Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2833e7fd6ce1de8a2c6192db13996dd4a6fc99d6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Project_Search), @"mvc.1.0.view", @"/Views/Project/Search.cshtml")]
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
#line 1 "C:\Users\mehmetyen\Desktop\RobotMaintenance\RobotMaintenanceMvc\Views\_ViewImports.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mehmetyen\Desktop\RobotMaintenance\RobotMaintenanceMvc\Views\_ViewImports.cshtml"
using EntityLayer.Dtos.AppUserDtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\mehmetyen\Desktop\RobotMaintenance\RobotMaintenanceMvc\Views\_ViewImports.cshtml"
using EntityLayer.Dtos.CompleteMaintenanceEquipmentDtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\mehmetyen\Desktop\RobotMaintenance\RobotMaintenanceMvc\Views\_ViewImports.cshtml"
using EntityLayer.Dtos.CompleteMaintenanceRobotDtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\mehmetyen\Desktop\RobotMaintenance\RobotMaintenanceMvc\Views\_ViewImports.cshtml"
using EntityLayer.Dtos.EquipmentCategoryDtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\mehmetyen\Desktop\RobotMaintenance\RobotMaintenanceMvc\Views\_ViewImports.cshtml"
using EntityLayer.Dtos.EquipmentDtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\mehmetyen\Desktop\RobotMaintenance\RobotMaintenanceMvc\Views\_ViewImports.cshtml"
using EntityLayer.Dtos.EquipmentMaintenanceDtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\mehmetyen\Desktop\RobotMaintenance\RobotMaintenanceMvc\Views\_ViewImports.cshtml"
using EntityLayer.Dtos.EquipmentMaintenanceUserDtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\mehmetyen\Desktop\RobotMaintenance\RobotMaintenanceMvc\Views\_ViewImports.cshtml"
using EntityLayer.Dtos.FactoryDepartmentDtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\mehmetyen\Desktop\RobotMaintenance\RobotMaintenanceMvc\Views\_ViewImports.cshtml"
using EntityLayer.Dtos.FactoryDtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\mehmetyen\Desktop\RobotMaintenance\RobotMaintenanceMvc\Views\_ViewImports.cshtml"
using EntityLayer.Dtos.ProjectDtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\mehmetyen\Desktop\RobotMaintenance\RobotMaintenanceMvc\Views\_ViewImports.cshtml"
using EntityLayer.Dtos.ProjectEquipmentDtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\mehmetyen\Desktop\RobotMaintenance\RobotMaintenanceMvc\Views\_ViewImports.cshtml"
using EntityLayer.Dtos.ProjectResponsibleDtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\mehmetyen\Desktop\RobotMaintenance\RobotMaintenanceMvc\Views\_ViewImports.cshtml"
using EntityLayer.Dtos.ProjectRobotDtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\mehmetyen\Desktop\RobotMaintenance\RobotMaintenanceMvc\Views\_ViewImports.cshtml"
using EntityLayer.Dtos.RobotCategoryDtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\mehmetyen\Desktop\RobotMaintenance\RobotMaintenanceMvc\Views\_ViewImports.cshtml"
using EntityLayer.Dtos.RobotDtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\mehmetyen\Desktop\RobotMaintenance\RobotMaintenanceMvc\Views\_ViewImports.cshtml"
using EntityLayer.Dtos.RobotMaintenanceDtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\mehmetyen\Desktop\RobotMaintenance\RobotMaintenanceMvc\Views\_ViewImports.cshtml"
using EntityLayer.Dtos.RobotToBeMaintainedDtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\mehmetyen\Desktop\RobotMaintenance\RobotMaintenanceMvc\Views\_ViewImports.cshtml"
using EntityLayer.Dtos.RobotToBeMaintainedUserDtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\mehmetyen\Desktop\RobotMaintenance\RobotMaintenanceMvc\Views\_ViewImports.cshtml"
using EntityLayer.Dtos.FaultReportDtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\mehmetyen\Desktop\RobotMaintenance\RobotMaintenanceMvc\Views\_ViewImports.cshtml"
using EntityLayer.Dtos.ProjectReportDtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\mehmetyen\Desktop\RobotMaintenance\RobotMaintenanceMvc\Views\_ViewImports.cshtml"
using RobotMaintenanceMvc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2833e7fd6ce1de8a2c6192db13996dd4a6fc99d6", @"/Views/Project/Search.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"82c112082cfbb1c52093a18ca25afab572666c79", @"/Views/_ViewImports.cshtml")]
    public class Views_Project_Search : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProjectListDto>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""main"">
    <!-- MAIN CONTENT -->
    <div class=""main-content"">
        <div class=""container-fluid"">
            <h2 class=""page-title"" style=""text-align:center""><strong>PROJELER</strong></h2>
            <div class=""row"">
                <div class=""col-md-12"">
                    <div class=""panel"">
                        <div class=""panel-body"">
                            <div class=""panel-heading"">
                                <h3 class=""panel-title"" style=""text-align:center""><strong>Proje Bilgileri</strong></h3>
                                <br />
");
#nullable restore
#line 14 "C:\Users\mehmetyen\Desktop\RobotMaintenance\RobotMaintenanceMvc\Views\Project\Search.cshtml"
                                 if (Model != null)
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\mehmetyen\Desktop\RobotMaintenance\RobotMaintenanceMvc\Views\Project\Search.cshtml"
                                     if (Model.Projects.Count > 0)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                        <table class=""table table-striped"">
                                            <thead>
                                                <tr>
                                                    <th>Proje İsmi</th>
                                                    <th>Fabrika İsmi</th>
                                                    <th>Bölüm İsmi</th>
");
#nullable restore
#line 24 "C:\Users\mehmetyen\Desktop\RobotMaintenance\RobotMaintenanceMvc\Views\Project\Search.cshtml"
                                                     if (User.IsInRole("Engineer") || User.IsInRole("Admin") || User.IsInRole("SuperAdmin"))
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <th>Araçlar</th>\r\n");
#nullable restore
#line 27 "C:\Users\mehmetyen\Desktop\RobotMaintenance\RobotMaintenanceMvc\Views\Project\Search.cshtml"
                                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                </tr>\r\n                                            </thead>\r\n                                            <tbody>\r\n");
#nullable restore
#line 31 "C:\Users\mehmetyen\Desktop\RobotMaintenance\RobotMaintenanceMvc\Views\Project\Search.cshtml"
                                                 foreach (var item in Model.Projects)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <tr>\r\n                                                        <td");
            BeginWriteAttribute("onclick", " onclick=\"", 1954, "\"", 1987, 3);
            WriteAttributeValue("", 1964, "selectProject(", 1964, 14, true);
#nullable restore
#line 34 "C:\Users\mehmetyen\Desktop\RobotMaintenance\RobotMaintenanceMvc\Views\Project\Search.cshtml"
WriteAttributeValue("", 1978, item.Id, 1978, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1986, ")", 1986, 1, true);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 34 "C:\Users\mehmetyen\Desktop\RobotMaintenance\RobotMaintenanceMvc\Views\Project\Search.cshtml"
                                                                                         Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                        <td>");
#nullable restore
#line 35 "C:\Users\mehmetyen\Desktop\RobotMaintenance\RobotMaintenanceMvc\Views\Project\Search.cshtml"
                                                       Write(item.FactoryDepartment.Factory.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                        <td>");
#nullable restore
#line 36 "C:\Users\mehmetyen\Desktop\RobotMaintenance\RobotMaintenanceMvc\Views\Project\Search.cshtml"
                                                       Write(item.FactoryDepartment.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 37 "C:\Users\mehmetyen\Desktop\RobotMaintenance\RobotMaintenanceMvc\Views\Project\Search.cshtml"
                                                         if (User.IsInRole("Engineer") || User.IsInRole("Admin") || User.IsInRole("SuperAdmin"))
                                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <td>\r\n                                                            <a class=\"btn btn-warning\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2557, "\"", 2588, 3);
            WriteAttributeValue("", 2567, "editProject(", 2567, 12, true);
#nullable restore
#line 40 "C:\Users\mehmetyen\Desktop\RobotMaintenance\RobotMaintenanceMvc\Views\Project\Search.cshtml"
WriteAttributeValue("", 2579, item.Id, 2579, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2587, ")", 2587, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                                Düzenle\r\n                                                            </a>\r\n                                                            <a class=\"btn btn-primary\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2817, "\"", 2850, 3);
            WriteAttributeValue("", 2827, "editEquipment(", 2827, 14, true);
#nullable restore
#line 43 "C:\Users\mehmetyen\Desktop\RobotMaintenance\RobotMaintenanceMvc\Views\Project\Search.cshtml"
WriteAttributeValue("", 2841, item.Id, 2841, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2849, ")", 2849, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                                Ekipman Ekle/Çıkar\r\n                                                            </a>\r\n                                                            <a class=\"btn btn-success\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3090, "\"", 3119, 3);
            WriteAttributeValue("", 3100, "editRobot(", 3100, 10, true);
#nullable restore
#line 46 "C:\Users\mehmetyen\Desktop\RobotMaintenance\RobotMaintenanceMvc\Views\Project\Search.cshtml"
WriteAttributeValue("", 3110, item.Id, 3110, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3118, ")", 3118, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                                Robot Ekle/Çıkar\r\n                                                            </a>\r\n                                                        </td>\r\n");
#nullable restore
#line 50 "C:\Users\mehmetyen\Desktop\RobotMaintenance\RobotMaintenanceMvc\Views\Project\Search.cshtml"
                                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    </tr>\r\n");
#nullable restore
#line 52 "C:\Users\mehmetyen\Desktop\RobotMaintenance\RobotMaintenanceMvc\Views\Project\Search.cshtml"
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            </tbody>\r\n                                        </table>\r\n");
#nullable restore
#line 55 "C:\Users\mehmetyen\Desktop\RobotMaintenance\RobotMaintenanceMvc\Views\Project\Search.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <center><i>Proje bulunamadı!</i></center>\r\n");
#nullable restore
#line 59 "C:\Users\mehmetyen\Desktop\RobotMaintenance\RobotMaintenanceMvc\Views\Project\Search.cshtml"
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 59 "C:\Users\mehmetyen\Desktop\RobotMaintenance\RobotMaintenanceMvc\Views\Project\Search.cshtml"
                                     
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <center><i>Proje bulunamadı!</i></center>\r\n");
#nullable restore
#line 64 "C:\Users\mehmetyen\Desktop\RobotMaintenance\RobotMaintenanceMvc\Views\Project\Search.cshtml"
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
<div id=""selectProjectModalPage""></div>
<div id=""editProjectModalPage""></div>
<div id=""editProjectEquipmentModalPage""></div>
<div id=""editProjectRobotModalPage""></div>
<script>
    // =======================
    function selectProject(projectId) {
        $.ajax({
            url: '/Project/Select/?Id=' + projectId,
            success: function (data) {
                $('#selectProjectModalPage').html(data);
                $('#selectProjectModal').modal('show');
            }
        });
    }
    // =======================
    var projectId = 0;
    function editProject(projectId) {
        $.ajax({
            url: '/Project/Edit/?Id=' + projectId,
            success: function (data) {
                $('#editProjectModalPage').html(data);
                $('#editProjectModal').modal('show');
            }
");
            WriteLiteral(@"        });
    }
    // =======================
    function editEquipment(projectId) {
        $.ajax({
            url: '/Project/EquipmentEdit/?Id=' + projectId,
            success: function (data) {
                $('#editProjectEquipmentModalPage').html(data);
                $('#editProjectEquipmentModal').modal('show');
            }
        });
    }
    // =======================
    // =======================
    function editRobot(projectId) {
        $.ajax({
            url: '/Project/RobotEdit/?Id=' + projectId,
            success: function (data) {
                $('#editProjectRobotModalPage').html(data);
                $('#editProjectRobotModal').modal('show');
            }
        });
    }
    // =======================
</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProjectListDto> Html { get; private set; }
    }
}
#pragma warning restore 1591
