#pragma checksum "C:\Users\mehmetyen\Desktop\RobotMaintenance\RobotMaintenanceMvc\Views\RobotToBeMaintained\RobotMaintenance.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5ef057a189867ecc1e6850c7290710d710e00185"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_RobotToBeMaintained_RobotMaintenance), @"mvc.1.0.view", @"/Views/RobotToBeMaintained/RobotMaintenance.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ef057a189867ecc1e6850c7290710d710e00185", @"/Views/RobotToBeMaintained/RobotMaintenance.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"82c112082cfbb1c52093a18ca25afab572666c79", @"/Views/_ViewImports.cshtml")]
    public class Views_RobotToBeMaintained_RobotMaintenance : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RobotToBeMaintainedListDto>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/excel-bootstrap-table-filter-bundle.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/excel-bootstrap-table-filter-style.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5ef057a189867ecc1e6850c7290710d710e001858685", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5ef057a189867ecc1e6850c7290710d710e001859724", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            WriteLiteral(@"<div class=""main"">
    <!-- MAIN CONTENT -->
    <div class=""main-content"">
        <div class=""container-fluid"">
            <h2 class=""page-title"" style=""text-align:center""><strong>ONAYLANACAK ROBOT BAKIMLARI</strong></h2>
            <div class=""row"">
                <div class=""col-md-12"">
                    <div class=""panel"">
                        <div class=""panel-body"">
                            <div class=""panel-heading"">
                                <h3 class=""panel-title"" style=""text-align:center""><strong>Robot Bak??m Bilgileri</strong></h3>
                                <br />
");
#nullable restore
#line 16 "C:\Users\mehmetyen\Desktop\RobotMaintenance\RobotMaintenanceMvc\Views\RobotToBeMaintained\RobotMaintenance.cshtml"
                                 if (Model.RobotToBeMaintained.Count > 0)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    <table class=""table table-striped"" id=""table"">
                                        <thead>
                                            <tr>
                                                <th class=""filter"">Proje ??smi</th>
                                                <th class=""filter"">Robot ??smi</th>
                                                <th>Bak??m Ad??</th>
                                                <th>Bak??m Periodu</th>
                                                <th class=""filter"">Bak??m Yap??lma Tarihi</th>
                                                <th>Bak??m Notu</th>
                                                <th>Bak??m Onay</th>
                                            </tr>
                                        </thead>
                                        <tbody>
");
#nullable restore
#line 31 "C:\Users\mehmetyen\Desktop\RobotMaintenance\RobotMaintenanceMvc\Views\RobotToBeMaintained\RobotMaintenance.cshtml"
                                             foreach (var item in Model.RobotToBeMaintained)
                                            {
                                                DateTime date = new DateTime();
                                                if (item.DoneOrNotDone)
                                                    date = item.MaintenanceDate.AddDays(item.RobotMaintenance.Maintenance.Period);
                                                else
                                                    date = item.MaintenanceDate;


#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <tr>\r\n                                                    <td>");
#nullable restore
#line 40 "C:\Users\mehmetyen\Desktop\RobotMaintenance\RobotMaintenanceMvc\Views\RobotToBeMaintained\RobotMaintenance.cshtml"
                                                   Write(item.ProjectRobot.Project.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                    <td>");
#nullable restore
#line 41 "C:\Users\mehmetyen\Desktop\RobotMaintenance\RobotMaintenanceMvc\Views\RobotToBeMaintained\RobotMaintenance.cshtml"
                                                   Write(item.RobotMaintenance.Robot.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                    <td>");
#nullable restore
#line 42 "C:\Users\mehmetyen\Desktop\RobotMaintenance\RobotMaintenanceMvc\Views\RobotToBeMaintained\RobotMaintenance.cshtml"
                                                   Write(item.RobotMaintenance.Maintenance.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                    <td>");
#nullable restore
#line 43 "C:\Users\mehmetyen\Desktop\RobotMaintenance\RobotMaintenanceMvc\Views\RobotToBeMaintained\RobotMaintenance.cshtml"
                                                   Write(item.RobotMaintenance.Maintenance.Period);

#line default
#line hidden
#nullable disable
            WriteLiteral(" G??n</td>\r\n                                                    <td>");
#nullable restore
#line 44 "C:\Users\mehmetyen\Desktop\RobotMaintenance\RobotMaintenanceMvc\Views\RobotToBeMaintained\RobotMaintenance.cshtml"
                                                   Write(item.MaintenanceDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                    <td>");
#nullable restore
#line 45 "C:\Users\mehmetyen\Desktop\RobotMaintenance\RobotMaintenanceMvc\Views\RobotToBeMaintained\RobotMaintenance.cshtml"
                                                   Write(item.Note);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                    <td>\r\n                                                        <a style=\"height:30px;width:30px\" class=\"btn btn-success\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3154, "\"", 3192, 3);
            WriteAttributeValue("", 3164, "confirmMaintenance(", 3164, 19, true);
#nullable restore
#line 47 "C:\Users\mehmetyen\Desktop\RobotMaintenance\RobotMaintenanceMvc\Views\RobotToBeMaintained\RobotMaintenance.cshtml"
WriteAttributeValue("", 3183, item.Id, 3183, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3191, ")", 3191, 1, true);
            EndWriteAttribute();
            WriteLiteral(@">
                                                            <i class=""fa fa-check-circle"" style=""color:White;margin-left:-7px""></i>
                                                        </a>
                                                        <a style=""height:30px;width:30px"" class=""btn btn-danger""");
            BeginWriteAttribute("onclick", " onclick=\"", 3503, "\"", 3540, 3);
            WriteAttributeValue("", 3513, "deniedMaintenance(", 3513, 18, true);
#nullable restore
#line 50 "C:\Users\mehmetyen\Desktop\RobotMaintenance\RobotMaintenanceMvc\Views\RobotToBeMaintained\RobotMaintenance.cshtml"
WriteAttributeValue("", 3531, item.Id, 3531, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3539, ")", 3539, 1, true);
            EndWriteAttribute();
            WriteLiteral(@">
                                                            <i class=""fa fa-times-circle"" style=""color:White;margin-left:-7px""></i>
                                                        </a>
                                                    </td>
                                                </tr>
");
#nullable restore
#line 55 "C:\Users\mehmetyen\Desktop\RobotMaintenance\RobotMaintenanceMvc\Views\RobotToBeMaintained\RobotMaintenance.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        </tbody>\r\n                                    </table>\r\n");
#nullable restore
#line 58 "C:\Users\mehmetyen\Desktop\RobotMaintenance\RobotMaintenanceMvc\Views\RobotToBeMaintained\RobotMaintenance.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <center><i>Ekipman bak??m?? bulunamad??!</i></center>\r\n");
#nullable restore
#line 62 "C:\Users\mehmetyen\Desktop\RobotMaintenance\RobotMaintenanceMvc\Views\RobotToBeMaintained\RobotMaintenance.cshtml"
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
<script>
    var equipmentMaintenanceDate;
    $(document).ready(function () {
        getDateTime()
    });
    // =======================
    // SEARCH
    // =======================
    $('#table').excelTableFilter({
        columnSelector: '.filter',    // (optional) if present, will only select <th> with specified class
        sort: true,                         // (optional) default true
        search: true                    // (optional) default { a_to_z: 'A to Z', z_to_a: 'Z to A', search: 'Search', select_all: 'Select All' }
    });
    // ========================
    // DATETIME.NOW
    // ========================
    function getDateTime() {
            var now = new Date();
            var year = now.getFullYear();
            var month = now.getMonth() + 1;
            var day = now.getDate();
      ");
            WriteLiteral(@"      if (month.toString().length == 1) {
                month = '0' + month;
            }
            if (day.toString().length == 1) {
                day = '0' + day;
            }
            equipmentMaintenanceDate = year + '-' + month + '-' + day;
        }
    // ==========================
    function confirmMaintenance(Id) {
        Swal.fire({
            title: 'Bak??m?? onaylamak istiyor musunuz?',
            text: ""Bak??m onayland??ktan sonra tekrar geri al??namaz!"",
            icon: 'warning',
            showCancelButton: true,
            confirmButtonColor: '#3085d6',
            cancelButtonColor: '#d33',
            confirmButtonText: 'Evet, onayl??yorum',
            cancelButtonText: '??ptal'
        }).then((result) => {
            if (result.isConfirmed) {
               $.ajax({
                url: '");
#nullable restore
#line 114 "C:\Users\mehmetyen\Desktop\RobotMaintenance\RobotMaintenanceMvc\Views\RobotToBeMaintained\RobotMaintenance.cshtml"
                 Write(Url.Action("Edit", "RobotToBeMaintained"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
                type: 'POST',
                dataType: 'json',
                data: {
                    'Id': Id,
                    'MaintenanceDate': equipmentMaintenanceDate,
                    'DoneOrNotDone': 'True',
                },
                success: function (data) {
                    if (data == true) {
                        Swal.fire({
                            position: 'center',
                            icon: 'success',
                            title: 'Ba??ar??yla g??ncellenmi??tir!',
                            showConfirmButton: false,
                            timer: 800
                        }).then(() => {
                            location.reload();
                        })
                    }
                    else {
                        Swal.fire({
                            position: 'center',
                            icon: 'error',
                            title: 'Ayn?? isimde bir ekipman mevcut!',
                   ");
            WriteLiteral(@"         showConfirmButton: false,
                            timer: 1500
                        }).then(() => {
                            location.reload();
                        })
                    }
                },
                error: function (data) {
                }
            });
            }
        })
    }
       // ==========================
    function deniedMaintenance(Id) {
        var note = '';
        Swal.fire({
            title: 'Bak??m red nedenini giriniz!',
            text: ""Bak??m reddedildikten sonra tekrar geri al??namaz!"",
            input: 'text',
            icon: 'warning',
            showCancelButton: true,
            confirmButtonColor: '#3085d6',
            cancelButtonColor: '#d33',
            confirmButtonText: 'Evet, reddediyorum',
            cancelButtonText: '??ptal',
            preConfirm: (login) => {
                if (login != '') {
                    note = login;
                }
                else {
       ");
            WriteLiteral(@"             Swal.showValidationMessage(
                        `L??tfen red nedenini giriniz!`
                    )
                }
            }
        }).then((result) => {
            if (result.isConfirmed) {
               $.ajax({
                url: '");
#nullable restore
#line 178 "C:\Users\mehmetyen\Desktop\RobotMaintenance\RobotMaintenanceMvc\Views\RobotToBeMaintained\RobotMaintenance.cshtml"
                 Write(Url.Action("Denied", "RobotToBeMaintained"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
                type: 'POST',
                dataType: 'json',
                data: {
                    'Id': Id,
                    'Note': note,
                },
                success: function (data) {
                    if (data == true) {
                        Swal.fire({
                            position: 'center',
                            icon: 'success',
                            title: 'Ba??ar??yla reddedilmi??tir!',
                            showConfirmButton: false,
                            timer: 800
                        }).then(() => {
                            location.reload();
                        })
                    }
                    else {
                        Swal.fire({
                            position: 'center',
                            icon: 'error',
                            title: 'Ayn?? isimde bir ekipman mevcut!',
                            showConfirmButton: false,
                            timer: 1500
 ");
            WriteLiteral(@"                       }).then(() => {
                            location.reload();
                        })
                    }
                },
                error: function (data) {
                }
            });
            }
        })
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RobotToBeMaintainedListDto> Html { get; private set; }
    }
}
#pragma warning restore 1591
