#pragma checksum "C:\Users\mehmetyen\Desktop\RobotMaintenance\RobotMaintenanceMvc\Views\Project\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "60868f4d0efebb9ad8a174735e412b52fb5c6f15"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Project_Edit), @"mvc.1.0.view", @"/Views/Project/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60868f4d0efebb9ad8a174735e412b52fb5c6f15", @"/Views/Project/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"82c112082cfbb1c52093a18ca25afab572666c79", @"/Views/_ViewImports.cshtml")]
    public class Views_Project_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProjectDto>
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
#line 2 "C:\Users\mehmetyen\Desktop\RobotMaintenance\RobotMaintenanceMvc\Views\Project\Edit.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""modal fade"" id=""editProjectModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""scrollmodalLabel"" aria-hidden=""true"" style=""margin-top: 2%;width:auto; height:auto"">
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "60868f4d0efebb9ad8a174735e412b52fb5c6f158917", async() => {
                WriteLiteral("\r\n                            <div class=\"col-md-12\">\r\n                                <label>Proje ??smi</label>\r\n                                <input type=\"text\" id=\"projectNameEdit\" class=\"form-control\" placeholder=\"Proje ??smi\" required");
                BeginWriteAttribute("value", " value=\"", 1053, "\"", 1080, 1);
#nullable restore
#line 20 "C:\Users\mehmetyen\Desktop\RobotMaintenance\RobotMaintenanceMvc\Views\Project\Edit.cshtml"
WriteAttributeValue("", 1061, Model.Project.Name, 1061, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                                <br />
                                <label>Fabrika</label>
                                <select name=""select"" id=""factory"" class=""form-control"">
                                </select>
                                <br />
                                <label>B??l??m</label>
                                <select name=""select"" id=""factoryDepartment"" class=""form-control"">
                                </select>
                                <br />
                                <label>Ekipmanlar</label>
                                <div id=""equipmentDiv"">
                                    <select name=""select"" id=""equipment"" class=""form-control"">
                                    </select>
                                </div>
                                <br />
                                <label>Robotlar</label>
                                <div id=""robotDiv"">
                                    <select name=""select"" id=""robo");
                WriteLiteral("t\" class=\"form-control\">\r\n                                    </select>\r\n                                </div>\r\n                                <br />\r\n                            </div>\r\n                        ");
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
            WriteLiteral("\r\n");
            WriteLiteral(@"                    </div>
                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">??ptal</button>
                    <button id=""updateBtn"" onclick=""updateProject()"" class=""btn btn-success"">Kaydet</button>
                </div>
            </div>
        </div>
    </div>
</div>

<script>
    var bLoad = true
    $(document).ready(function () {
        getFactories(true);
        getProjectRobots();
        getProjectEquipments();
        bLoad = false;
        $('#factory').on(""change"", function () {
            getFactoryDepartment();
        })
    });
    // ===============================
    // Factory
    // ===============================
    function getFactories(bLoad) {
        $.ajax({
            type: ""GET"",
            url: ""/Factory/GetAll"",
            data: ""{}"",
            success: function (data) {
                for (var i = 0; i < data.factories.$values.le");
            WriteLiteral("ngth; i++) {\r\n                    var select = document.getElementById(\"factory\");\r\n                     if (");
#nullable restore
#line 81 "C:\Users\mehmetyen\Desktop\RobotMaintenance\RobotMaintenanceMvc\Views\Project\Edit.cshtml"
                    Write(Model.Project.FactoryDepartment.FactoryId);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" == data.factories.$values[i].id && bLoad)
                        select.appendChild(new Option(data.factories.$values[i].name, data.factories.$values[i].id, true, true));
                    else
                        select.appendChild(new Option(data.factories.$values[i].name, data.factories.$values[i].id));
                }
                getFactoryDepartment(bLoad);
            }
        });
    }
    // ===============================
    // FactoryDepartment
    // ===============================
    function getFactoryDepartment(bLoad) {
        $.ajax({
            type: ""GET"",
            url: ""/FactoryDepartment/GetByFactoryId?factoryId="" + $(""#factory"").val(),
            success: function (data) {
                $('#factoryDepartment').empty();
                for (var i = 0; i < data.factoryDepartments.$values.length; i++) {
                    var select = document.getElementById(""factoryDepartment"");
                    if (");
#nullable restore
#line 101 "C:\Users\mehmetyen\Desktop\RobotMaintenance\RobotMaintenanceMvc\Views\Project\Edit.cshtml"
                   Write(Model.Project.FactoryDepartmentId);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" == data.factoryDepartments.$values[i].id && bLoad)
                        select.appendChild(new Option(data.factoryDepartments.$values[i].name, data.factoryDepartments.$values[i].id, true, true));
                    else
                        select.appendChild(new Option(data.factoryDepartments.$values[i].name, data.factoryDepartments.$values[i].id));
                }
            }
        });
    }
    // ===============================
    // ProjecRobots
    // ===============================
    function getProjectRobots() {
        $.ajax({
            type: ""GET"",
            url: ""/ProjectRobot/GetByProjectId?projectId="" + ");
#nullable restore
#line 115 "C:\Users\mehmetyen\Desktop\RobotMaintenance\RobotMaintenanceMvc\Views\Project\Edit.cshtml"
                                                        Write(Model.Project.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@",
            data: ""{}"",
            success: function (data) {
                $(""#robot"").empty();
                for (var i = 0; i < data.length; i++) {
                    var select = document.getElementById(""robot"");
                    var start = data[i].indexOf(""?"");
                    var end = data[i].length;
                    robotId = data[i].substring(start + 1, end);
                    robotName = data[i].substring(0, start);
                    select.appendChild(new Option(robotName, robotId));
                }
            }
        });
    }
    // ===============================
    // ProjectEquipments
    // ===============================
    function getProjectEquipments() {
        $.ajax({
            type: ""GET"",
            url: ""/ProjectEquipment/GetByProjectId?projectId="" + ");
#nullable restore
#line 136 "C:\Users\mehmetyen\Desktop\RobotMaintenance\RobotMaintenanceMvc\Views\Project\Edit.cshtml"
                                                            Write(Model.Project.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@",
            data: ""{}"",
            success: function (data) {
                $(""#equipment"").empty();
                for (var i = 0; i < data.length; i++) {
                    var select = document.getElementById(""equipment"");
                    var start = data[i].indexOf(""?"");
                    var end = data[i].length;
                    equipmentId = data[i].substring(start + 1, end);
                    equipmentName = data[i].substring(0, start);
                    select.appendChild(new Option(equipmentName, equipmentId));
                }
            }
        });
    }
    // ===============================
    // ===============================
    function updateProject() {
        if (document.forms['updateForm'].reportValidity()) {
            document.getElementById(""updateBtn"").disabled = true;
         $.ajax({
                 url: '/Project/Edit/',
                 type: 'POST',
                 dataType :'json',
                 data: {
                 ");
            WriteLiteral("    \'Id\' : ");
#nullable restore
#line 161 "C:\Users\mehmetyen\Desktop\RobotMaintenance\RobotMaintenanceMvc\Views\Project\Edit.cshtml"
                       Write(Model.Project.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(",\r\n                     \'Name\': $(\"#projectNameEdit\").val(),\r\n                     \'FactoryDepartmentId\': $(\"#factoryDepartment\").val(),\r\n                     \'CreatedDate\': \'");
#nullable restore
#line 164 "C:\Users\mehmetyen\Desktop\RobotMaintenance\RobotMaintenanceMvc\Views\Project\Edit.cshtml"
                                Write(Model.Project.CreatedDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("\',\r\n                     \'CreatedByName\': \'");
#nullable restore
#line 165 "C:\Users\mehmetyen\Desktop\RobotMaintenance\RobotMaintenanceMvc\Views\Project\Edit.cshtml"
                                  Write(Model.Project.CreatedByName);

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProjectDto> Html { get; private set; }
    }
}
#pragma warning restore 1591
