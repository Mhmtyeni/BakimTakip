#pragma checksum "C:\Users\mehmetyen\Desktop\RobotMaintenance\RobotMaintenanceMvc\Views\ProjectReport\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "903cb46c7fb030459726d8e6e3065ab612138844"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ProjectReport_Edit), @"mvc.1.0.view", @"/Views/ProjectReport/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"903cb46c7fb030459726d8e6e3065ab612138844", @"/Views/ProjectReport/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"82c112082cfbb1c52093a18ca25afab572666c79", @"/Views/_ViewImports.cshtml")]
    public class Views_ProjectReport_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProjectReportDto>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("updateForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\mehmetyen\Desktop\RobotMaintenance\RobotMaintenanceMvc\Views\ProjectReport\Edit.cshtml"
  
    Layout = null;
    DateTime dateTime = Convert.ToDateTime(Model.ProjectReport.Deadline.ToShortDateString());
    string year, mounth, day;
    year = dateTime.Year.ToString();
    mounth = dateTime.Month.ToString();
    day = dateTime.Day.ToString();
    if (day.Length == 1)
    {
        day = "0" + day;
    }
    if (mounth.Length == 1)
    {
        mounth = "0" + mounth;
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""modal fade"" id=""editProjectReportModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""scrollmodalLabel"" aria-hidden=""true"" style=""margin-top: 2%;width:auto; height:auto"">
    <div class=""modal-dialog modal-lg"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <label class=""modal-title"" id=""scrollmodalLabel"">Proje D??zenleme</label>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <div class=""row"">
                    <div class=""col-md-12"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "903cb46c7fb030459726d8e6e3065ab6121388449347", async() => {
                WriteLiteral("\r\n                            <div class=\"col-md-12\">\r\n                                <label>Fabrika ??smi</label>\r\n                                <input type=\"text\" id=\"projectName\" class=\"form-control\" placeholder=\"Proje ??smi\" required");
                BeginWriteAttribute("value", " value=\"", 1445, "\"", 1512, 1);
#nullable restore
#line 33 "C:\Users\mehmetyen\Desktop\RobotMaintenance\RobotMaintenanceMvc\Views\ProjectReport\Edit.cshtml"
WriteAttributeValue("", 1453, Model.ProjectReport.Project.FactoryDepartment.Factory.Name, 1453, 59, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" readonly>\r\n                                <br />\r\n                                <label>B??l??m ??smi</label>\r\n                                <input type=\"text\" id=\"projectName\" class=\"form-control\" placeholder=\"Proje ??smi\" required");
                BeginWriteAttribute("value", " value=\"", 1746, "\"", 1805, 1);
#nullable restore
#line 36 "C:\Users\mehmetyen\Desktop\RobotMaintenance\RobotMaintenanceMvc\Views\ProjectReport\Edit.cshtml"
WriteAttributeValue("", 1754, Model.ProjectReport.Project.FactoryDepartment.Name, 1754, 51, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" readonly>\r\n                                <br />\r\n                                <label>Proje ??smi</label>\r\n                                <select name=\"select\" id=\"project\" class=\"form-control\" required>\r\n                                </select>\r\n");
                WriteLiteral("                                <br />\r\n                                <label>Proje ile ??lgili Madde</label>\r\n                                <input type=\"text\" id=\"fault\" class=\"form-control\" placeholder=\"Proje ile ??lgili Madde\" required");
                BeginWriteAttribute("value", " value=\"", 2476, "\"", 2510, 1);
#nullable restore
#line 44 "C:\Users\mehmetyen\Desktop\RobotMaintenance\RobotMaintenanceMvc\Views\ProjectReport\Edit.cshtml"
WriteAttributeValue("", 2484, Model.ProjectReport.Fault, 2484, 26, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                <br />\r\n                                <label>A????klama</label>\r\n                                <input type=\"text\" id=\"comment\" class=\"form-control\" placeholder=\"A????klama\" required");
                BeginWriteAttribute("value", " value=\"", 2727, "\"", 2763, 1);
#nullable restore
#line 47 "C:\Users\mehmetyen\Desktop\RobotMaintenance\RobotMaintenanceMvc\Views\ProjectReport\Edit.cshtml"
WriteAttributeValue("", 2735, Model.ProjectReport.Comment, 2735, 28, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                <br />\r\n                                <label>Sorumlu</label>\r\n                                <input type=\"text\" id=\"users\" class=\"form-control\" placeholder=\"Sorumlular\" required");
                BeginWriteAttribute("value", " value=\"", 2979, "\"", 3062, 1);
#nullable restore
#line 50 "C:\Users\mehmetyen\Desktop\RobotMaintenance\RobotMaintenanceMvc\Views\ProjectReport\Edit.cshtml"
WriteAttributeValue("", 2987, Model.ProjectReport.Note.Substring(0, Model.ProjectReport.Note.Length - 2), 2987, 75, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" readonly>\r\n                                <br />\r\n                                <button");
                BeginWriteAttribute("onclick", " onclick=\"", 3154, "\"", 3197, 3);
                WriteAttributeValue("", 3164, "editUser(", 3164, 9, true);
#nullable restore
#line 52 "C:\Users\mehmetyen\Desktop\RobotMaintenance\RobotMaintenanceMvc\Views\ProjectReport\Edit.cshtml"
WriteAttributeValue("", 3173, Model.ProjectReport.Id, 3173, 23, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 3196, ")", 3196, 1, true);
                EndWriteAttribute();
                WriteLiteral(@" style=""width:150px"" type=""button"" class=""btn btn-primary"">Sorumlu De??i??tir</button>
                                <br />
                                <br />
                                <label>Termin</label>
                                <br />
                                <input style=""width:200px"" type=""date"" id=""deadlineDate"" name=""deadlineDate""");
                BeginWriteAttribute("value", " value=\"", 3567, "\"", 3593, 5);
#nullable restore
#line 57 "C:\Users\mehmetyen\Desktop\RobotMaintenance\RobotMaintenanceMvc\Views\ProjectReport\Edit.cshtml"
WriteAttributeValue("", 3575, year, 3575, 5, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 3580, "-", 3580, 1, true);
#nullable restore
#line 57 "C:\Users\mehmetyen\Desktop\RobotMaintenance\RobotMaintenanceMvc\Views\ProjectReport\Edit.cshtml"
WriteAttributeValue("", 3581, mounth, 3581, 7, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 3588, "-", 3588, 1, true);
#nullable restore
#line 57 "C:\Users\mehmetyen\Desktop\RobotMaintenance\RobotMaintenanceMvc\Views\ProjectReport\Edit.cshtml"
WriteAttributeValue("", 3589, day, 3589, 4, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" max=\"2025-12-31\" required>\r\n                                <br />\r\n                                <br />\r\n                            </div>\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </div>
                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">??ptal</button>
                    <button id=""updateBtn"" onclick=""updateFaultReport()"" class=""btn btn-success"">Kaydet</button>
                </div>
            </div>
        </div>
    </div>
</div>

<div id=""editUserModalPage""></div>
<script>
    $(document).ready(function () {
        getProjects();
    });
    function editUser(Id) {
        $.ajax({
            url: '/ProjectReport/EditUser/?Id=' + Id,
            success: function (data) {
                $('#editUserModalPage').html(data);
                $('#editUserModal').modal('show');
            }
        });
    }
    // ===============================
    // ===============================
    // Project
    // ===============================
    function getProjects() {
        $.ajax({
            type: ""GET"",
            url: ");
            WriteLiteral(@"""/Project/GetAll"",
            data: ""{}"",
            success: function (data) {
                //var s = '';
                //for (var i = 0; i < data.projects.$values.length; i++) {
                //    s += '<option value=""' + data.projects.$values[i].id + '"">' + data.projects.$values[i].name + '</option>';
                //}
                for (var i = 0; i < data.projects.$values.length; i++) {
                    var select = document.getElementById(""project"");
                    if (");
#nullable restore
#line 103 "C:\Users\mehmetyen\Desktop\RobotMaintenance\RobotMaintenanceMvc\Views\ProjectReport\Edit.cshtml"
                   Write(Model.ProjectReport.ProjectId);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" == data.projects.$values[i].id)
                        select.appendChild(new Option(data.projects.$values[i].name, data.projects.$values[i].id, true, true));
                    else
                        select.appendChild(new Option(data.projects.$values[i].name, data.projects.$values[i].id));
                }
            }
        });
    }
    // ===============================
    function updateFaultReport() {
            if (document.forms['updateForm'].reportValidity()) {
                document.getElementById(""updateBtn"").disabled = true;
             $.ajax({
                     url: '/ProjectReport/Edit2/',
                     type: 'POST',
                     dataType :'json',
                     data: {
                         'Id' : ");
#nullable restore
#line 120 "C:\Users\mehmetyen\Desktop\RobotMaintenance\RobotMaintenanceMvc\Views\ProjectReport\Edit.cshtml"
                           Write(Model.ProjectReport.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@",
                         'ProjectId': $(""#project"").val(),
                         'Fault': $(""#fault"").val(),
                         'AppUserId': 2,
                         'Comment': $(""#comment"").val(),
                         'Deadline': $(""#deadlineDate"").val(),
                         'Completed': '");
#nullable restore
#line 126 "C:\Users\mehmetyen\Desktop\RobotMaintenance\RobotMaintenanceMvc\Views\ProjectReport\Edit.cshtml"
                                  Write(Model.ProjectReport.Completed);

#line default
#line hidden
#nullable disable
            WriteLiteral("\',\r\n                         \'CreatedDate\': \'");
#nullable restore
#line 127 "C:\Users\mehmetyen\Desktop\RobotMaintenance\RobotMaintenanceMvc\Views\ProjectReport\Edit.cshtml"
                                    Write(Model.ProjectReport.CreatedDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("\',\r\n                         \'CreatedByName\': \'");
#nullable restore
#line 128 "C:\Users\mehmetyen\Desktop\RobotMaintenance\RobotMaintenanceMvc\Views\ProjectReport\Edit.cshtml"
                                      Write(Model.ProjectReport.CreatedByName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
                    },
                 success: function (data) {
                     Swal.fire({
                         position: 'center',
                         icon: 'success',
                         title: 'Ba??ar??yla kaydedilmi??tir!',
                         showConfirmButton: false,
                         timer: 800
                     }).then(() => {
                         location.reload();
                     })

                    },
                    error: function (data) {
                        document.getElementById(""updateBtn"").disabled = false;
                    }
                });
            }

        };
    // =====================================================



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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProjectReportDto> Html { get; private set; }
    }
}
#pragma warning restore 1591
