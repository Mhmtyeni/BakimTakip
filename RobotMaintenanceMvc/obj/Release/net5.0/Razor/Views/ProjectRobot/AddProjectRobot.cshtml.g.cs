#pragma checksum "C:\Users\mehmetyen\source\repos\RobotMaintenance\RobotMaintenanceMvc\Views\ProjectRobot\AddProjectRobot.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0c349ca80c6a049b333c60af44f9ce7078c02a24"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ProjectRobot_AddProjectRobot), @"mvc.1.0.view", @"/Views/ProjectRobot/AddProjectRobot.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c349ca80c6a049b333c60af44f9ce7078c02a24", @"/Views/ProjectRobot/AddProjectRobot.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"82c112082cfbb1c52093a18ca25afab572666c79", @"/Views/_ViewImports.cshtml")]
    public class Views_ProjectRobot_AddProjectRobot : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form_id"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"<div class=""main"">
    <!-- MAIN CONTENT -->
    <div class=""main-content"">
        <div class=""container-fluid"">
            <h2 class=""page-title"" style=""text-align:center""><strong>PROJEYE ROBOT EKLE</strong></h2>
            <div class=""row"">
                <div class=""col-md-12"">
                    <div class=""panel"">
                        <div class=""panel-body"">
                            <div class=""panel-heading"">
                                <h3 class=""panel-title"" style=""text-align:center""><strong>Proje ve Robot Bilgileri</strong></h3>
                            </div>
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0c349ca80c6a049b333c60af44f9ce7078c02a248784", async() => {
                WriteLiteral(@"
                                <div class=""row"">
                                    <div class=""col-md-12"">
                                        <div class=""col-md-6"">
                                            <label>Proje Se??</label>
                                            <select name=""select"" id=""project"" class=""form-control"" required>
                                            </select>
                                            <br />
                                            <label>Kategori Se??</label>
                                            <div id=""categoryDiv"">
                                                <select name=""select"" id=""robotCategory"" class=""form-control"" required>
                                                </select>
                                            </div>
                                            <br />
                                            <label>Robot Se??</label>
                                            <div id=""robotDiv"">");
                WriteLiteral(@"
                                                <select name=""select"" id=""robot"" class=""form-control"" required>
                                                </select>
                                            </div>
                                            <br />
                                            <br />
                                        </div>
                                        <br />
                                        <br />
                                        <br />
                                        <br />
                                        <br />
                                        <div class=""col-md-6"">
                                            <button style=""border-radius:10px;width:156.2px;"" type=""button"" onclick=""addRobotCategory()"" class=""btn btn-default""><i class=""fa fa-plus-square""></i> Kategori Ekle </button>
                                            <br />
                                            <br />
                  ");
                WriteLiteral(@"                          <br />
                                            <button style=""margin-top:5px;border-radius:10px;width:156.2px;"" onclick=""addRobot()"" type=""button"" class=""btn btn-default""><i class=""fa fa-plus-square""></i> Robot Ekle </button>
                                        </div>
                                    </div>
                                </div>
                                <div class=""col-md-4"">
                                </div>
                                <div class=""col-md-4"">
                                    <button id=""add"" onclick=""postData()"" style=""border-radius:10px;"" type=""button"" class=""btn btn-success btn-block"">EKLE</button>
                                </div>
                                <div class=""col-md-4"">
                                </div>
                            ");
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
                </div>
            </div>
        </div>
    </div>
</div>
<script>
    function isNumberKey(evt) {
        var charCode = (evt.which) ? evt.which : event.keyCode;
        if (charCode > 31 && (charCode < 48 || charCode > 57))
            return false;
        return true;
    }
    $(document).ready(function () {
        getProjects();
        getRobotCategories();

        $('#robotCategory').on(""change"", function () {
            getRobots();
        })
    });

    // ===============================
    // Project
    // ===============================
    function getProjects() {
        $.ajax({
            type: ""GET"",
            url: ""/Project/GetAll"",
            data: ""{}"",
            success: function (data) {
                var s = '';
                for (var i = 0; i < data.projects.$values.length; i++) {
                    s += '<option value=""' + data.projects.$values[i].id + '"">' ");
            WriteLiteral(@"+ data.projects.$values[i].name + '</option>';
                }
                $(""#project"").html(s);
            }
        });
    }

    // ===============================
    // RobotCategory
    // ===============================
    function addRobotCategory() {
        var name = '';
        Swal.fire({
            title: 'Kategori ad??n?? giriniz!',
            input: 'text',
            inputAttributes: {
                autocapitalize: 'off'
            },
            showCancelButton: true,
            cancelButtonText: 'Vazge??',
            confirmButtonText: 'Ekle',
            showLoaderOnConfirm: true,
            preConfirm: (login) => {
                if (login != '') {
                    name = login;
                }
                else {
                    Swal.showValidationMessage(
                        `??sim alan?? bo?? b??rak??lamaz!`
                    )
                }
            },
            allowOutsideClick: () => !Swal.isLoading()
        ");
            WriteLiteral(@"}).then((result) => {
            if (result.isConfirmed) {
                $.ajax({
                    url: '/RobotCategory/Add/',
                    type: 'POST',
                    dataType: 'json',
                    data: {
                        'Name': name,
                    },
                    success: function (data) {
                        Swal.fire({
                            position: 'center',
                            icon: 'success',
                            title: 'Ba??ar??yla eklenmi??tir!',
                            showConfirmButton: false,
                            timer: 800
                        }).then(() => {
                            $(""#robotDiv"").load(getRobotCategories());
                        })
                    },
                    error: function (data) {
                    }
                });
            }
        })
    }
    // ===============================
    function getRobotCategories() {

        $.ajax({");
            WriteLiteral(@"
            type: ""GET"",
            url: ""/RobotCategory/GetAll"",
            data: ""{}"",
            success: function (data) {
                var s = '';
                for (var i = 0; i < data.robotCategories.$values.length; i++) {
                    s += '<option value=""' + data.robotCategories.$values[i].id + '"">' + data.robotCategories.$values[i].name + '</option>';
                }
                $(""#robotCategory"").html(s);
                getRobots();
            }
        });
    }
    // ===============================
    function getRobots() {
        $.ajax({
            type: ""GET"",
            url: ""/Robot/GetByRobotCategoryId?robotCategoryId="" + $(""#robotCategory"").val(),
            success: function (data) {
                $('#robot').empty();
                for (var i = 0; i < data.robots.$values.length; i++) {
                    var select = document.getElementById(""robot"");
                    select.appendChild(new Option(data.robots.$values[i].name, dat");
            WriteLiteral(@"a.robots.$values[i].id));
                }
            }
        });
    }
    // ===============================
    function addRobot() {
        Swal.fire({
            title: 'Robot Ekleme',
            html:
                '<input type=""text"" style=""width:230px;"" id=""swal-input1"" class=""swal2-input"" placeholder=""Robot ??smi"" autocomplete=""off"">' +
                '<input type=""text"" style=""width:230px;"" id=""swal-input2"" class=""swal2-input"" placeholder=""Robot A????klamas??"" autocomplete=""off"">' ,
            showCancelButton: true,
            cancelButtonText: 'Vazge??',
            confirmButtonText: 'Onayla',
            showLoaderOnConfirm: true,
            preConfirm: (login) => {
                var Name = $('#swal-input1').val();
                if (Name != '') {

                }
                else {
                    Swal.showValidationMessage(
                        `??sim alan?? bo?? b??rak??lamaz!`
                    )
                }
            },
            all");
            WriteLiteral(@"owOutsideClick: () => !Swal.isLoading()
        }).then((result) => {
            if (result.isConfirmed) {
                $.ajax({
                    url: '/Robot/Add/',
                    type: 'POST',
                    dataType: 'json',
                    data: {
                        'Name': $('#swal-input1').val(),                        
                        'RobotCategoryId': $(""#robotCategory"").val(),
                        'Note': $('#swal-input2').val(),
                    },
                    success: function (data) {
                        Swal.fire({
                            position: 'center',
                            icon: 'success',
                            title: 'Ba??ar??yla eklenmi??tir!',
                            showConfirmButton: false,
                            timer: 800
                        }).then(() => {
                            $(""#robotDiv"").load(getRobots());
                        })
                    },
               ");
            WriteLiteral(@"     error: function (data) {
                    }
                });
            }
        })
    }
    // ===============================
    function postData() {
        if (document.forms['form_id'].reportValidity()) {
            document.getElementById(""add"").disabled = true;
            $.ajax({
                url: '");
#nullable restore
#line 237 "C:\Users\mehmetyen\source\repos\RobotMaintenance\RobotMaintenanceMvc\Views\ProjectRobot\AddProjectRobot.cshtml"
                 Write(Url.Action("Add", "ProjectRobot"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
                type: 'POST',
                dataType: 'json',
                data: {
                    'ProjectId': $(""#project"").val(),
                    'RobotId': $(""#robot"").val(),
                },
                success: function (data) {
                    if (data == true) {
                        Swal.fire({
                            position: 'center',
                            icon: 'success',
                            title: 'Ba??ar??yla eklenmi??tir!',
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
                            title: 'Bu projeye daha ??nce bu ekipman eklenmi??tir.',
                            showConfirmButton: ");
            WriteLiteral(@"false,
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
