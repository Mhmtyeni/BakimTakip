#pragma checksum "C:\Users\mehmetyen\source\repos\RobotMaintenance\RobotMaintenanceMvc\Views\Equipment\Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6480e9f1f20425876c915013f9138b1056b7d474"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Equipment_Search), @"mvc.1.0.view", @"/Views/Equipment/Search.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6480e9f1f20425876c915013f9138b1056b7d474", @"/Views/Equipment/Search.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"82c112082cfbb1c52093a18ca25afab572666c79", @"/Views/_ViewImports.cshtml")]
    public class Views_Equipment_Search : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EquipmentListDto>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""main"">
    <!-- MAIN CONTENT -->
    <div class=""main-content"">
        <div class=""container-fluid"">
            <h2 class=""page-title"" style=""text-align:center""><strong>EKİPMANLAR</strong></h2>
            <div class=""row"">
                <div class=""col-md-12"">
                    <div class=""panel"">
                        <div class=""panel-body"">
                            <div class=""panel-heading"">
                                <h3 class=""panel-title"" style=""text-align:center""><strong>Ekipman Bilgileri</strong></h3>
                                <br />
");
#nullable restore
#line 14 "C:\Users\mehmetyen\source\repos\RobotMaintenance\RobotMaintenanceMvc\Views\Equipment\Search.cshtml"
                                 if (Model != null)
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\mehmetyen\source\repos\RobotMaintenance\RobotMaintenanceMvc\Views\Equipment\Search.cshtml"
                                     if (Model.Equipments.Count > 0)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                        <table class=""table table-striped"">
                                            <thead>
                                                <tr>
                                                    <th>Ekipman İsmi</th>
                                                    <th>Ekipman Kategorisi</th>
                                                    <th>Period</th>
                                                    <th>Bakım İsmi</th>
                                                    <th>Bakım Açıklaması</th>
");
#nullable restore
#line 26 "C:\Users\mehmetyen\source\repos\RobotMaintenance\RobotMaintenanceMvc\Views\Equipment\Search.cshtml"
                                                     if (User.IsInRole("Engineer") || User.IsInRole("Admin") || User.IsInRole("SuperAdmin"))
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <th>Araçlar</th>\r\n");
#nullable restore
#line 29 "C:\Users\mehmetyen\source\repos\RobotMaintenance\RobotMaintenanceMvc\Views\Equipment\Search.cshtml"
                                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                </tr>\r\n                                            </thead>\r\n                                            <tbody>\r\n");
#nullable restore
#line 33 "C:\Users\mehmetyen\source\repos\RobotMaintenance\RobotMaintenanceMvc\Views\Equipment\Search.cshtml"
                                                 foreach (var item in Model.Equipments)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <tr>\r\n                                                        <td");
            BeginWriteAttribute("onclick", " onclick=\"", 2120, "\"", 2155, 3);
            WriteAttributeValue("", 2130, "selectEquipment(", 2130, 16, true);
#nullable restore
#line 36 "C:\Users\mehmetyen\source\repos\RobotMaintenance\RobotMaintenanceMvc\Views\Equipment\Search.cshtml"
WriteAttributeValue("", 2146, item.Id, 2146, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2154, ")", 2154, 1, true);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 36 "C:\Users\mehmetyen\source\repos\RobotMaintenance\RobotMaintenanceMvc\Views\Equipment\Search.cshtml"
                                                                                           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                        <td>");
#nullable restore
#line 37 "C:\Users\mehmetyen\source\repos\RobotMaintenance\RobotMaintenanceMvc\Views\Equipment\Search.cshtml"
                                                       Write(item.EquipmentCategory.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                        <td>");
#nullable restore
#line 38 "C:\Users\mehmetyen\source\repos\RobotMaintenance\RobotMaintenanceMvc\Views\Equipment\Search.cshtml"
                                                       Write(item.Period);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                        <td>");
#nullable restore
#line 39 "C:\Users\mehmetyen\source\repos\RobotMaintenance\RobotMaintenanceMvc\Views\Equipment\Search.cshtml"
                                                       Write(item.MaintenanceName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                        <td>");
#nullable restore
#line 40 "C:\Users\mehmetyen\source\repos\RobotMaintenance\RobotMaintenanceMvc\Views\Equipment\Search.cshtml"
                                                       Write(item.MaintenanceComment);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 41 "C:\Users\mehmetyen\source\repos\RobotMaintenance\RobotMaintenanceMvc\Views\Equipment\Search.cshtml"
                                                         if (User.IsInRole("Engineer") || User.IsInRole("Admin") || User.IsInRole("SuperAdmin"))
                                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <td>\r\n                                                            <a class=\"btn btn-warning\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2880, "\"", 2913, 3);
            WriteAttributeValue("", 2890, "editEquipment(", 2890, 14, true);
#nullable restore
#line 44 "C:\Users\mehmetyen\source\repos\RobotMaintenance\RobotMaintenanceMvc\Views\Equipment\Search.cshtml"
WriteAttributeValue("", 2904, item.Id, 2904, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2912, ")", 2912, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                                Düzenle\r\n                                                            </a>\r\n                                                            <a class=\"btn btn-primary\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3142, "\"", 3172, 3);
            WriteAttributeValue("", 3152, "addProject(", 3152, 11, true);
#nullable restore
#line 47 "C:\Users\mehmetyen\source\repos\RobotMaintenance\RobotMaintenanceMvc\Views\Equipment\Search.cshtml"
WriteAttributeValue("", 3163, item.Id, 3163, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3171, ")", 3171, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                                Projeye Ekle\r\n                                                            </a>\r\n                                                        </td>\r\n");
#nullable restore
#line 51 "C:\Users\mehmetyen\source\repos\RobotMaintenance\RobotMaintenanceMvc\Views\Equipment\Search.cshtml"
                                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    </tr>\r\n");
#nullable restore
#line 53 "C:\Users\mehmetyen\source\repos\RobotMaintenance\RobotMaintenanceMvc\Views\Equipment\Search.cshtml"
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            </tbody>\r\n                                        </table>\r\n");
#nullable restore
#line 56 "C:\Users\mehmetyen\source\repos\RobotMaintenance\RobotMaintenanceMvc\Views\Equipment\Search.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <center><i>Ekipman bulunamadı!</i></center>\r\n");
#nullable restore
#line 60 "C:\Users\mehmetyen\source\repos\RobotMaintenance\RobotMaintenanceMvc\Views\Equipment\Search.cshtml"
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 60 "C:\Users\mehmetyen\source\repos\RobotMaintenance\RobotMaintenanceMvc\Views\Equipment\Search.cshtml"
                                     
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <center><i>Ekipman bulunamadı!</i></center>\r\n");
#nullable restore
#line 65 "C:\Users\mehmetyen\source\repos\RobotMaintenance\RobotMaintenanceMvc\Views\Equipment\Search.cshtml"
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
<div id=""editEquipmentModalPage""></div>
<div id=""editAddProjectModalPage""></div>
<script>
    // =======================
    function selectEquipment(equipmentId) {
        $.ajax({
            url: '/Equipment/Select/?Id=' + equipmentId,
            success: function (data) {
                $('#selectProjectModalPage').html(data);
                $('#selectProjectModal').modal('show');
            }
        });
    }
    // =======================
    function editEquipment(equipmentId) {
        $.ajax({
            url: '/Equipment/Edit/?Id=' + equipmentId,
            success: function (data) {
                $('#editEquipmentModalPage').html(data);
                $('#editEquipmentModal').modal('show');
            }
        });
    }
    // =======================
");
            WriteLiteral(@"    // =======================
    function addProject(equipmentId) {
        $.ajax({
            url: '/Equipment/AddProjectEquipment/?Id=' + equipmentId,
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EquipmentListDto> Html { get; private set; }
    }
}
#pragma warning restore 1591
