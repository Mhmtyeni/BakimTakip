#pragma checksum "C:\Users\mehmetyen\source\repos\RobotMaintenance\RobotMaintenanceMvc\Views\Project\AddProject.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6e6486ad00149b35b1ed2f0f2d2ba58f3e33854c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Project_AddProject), @"mvc.1.0.view", @"/Views/Project/AddProject.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e6486ad00149b35b1ed2f0f2d2ba58f3e33854c", @"/Views/Project/AddProject.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"82c112082cfbb1c52093a18ca25afab572666c79", @"/Views/_ViewImports.cshtml")]
    public class Views_Project_AddProject : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            <h2 class=""page-title"" style=""text-align:center""><strong>PROJE EKLE</strong></h2>
            <div class=""row"">
                <div class=""col-md-12"">
                    <div class=""panel"">
                        <div class=""panel-body"">
                            <div class=""panel-heading"">
                                <h3 class=""panel-title"" style=""text-align:center""><strong>Proje Bilgileri</strong></h3>
                            </div>
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6e6486ad00149b35b1ed2f0f2d2ba58f3e33854c8717", async() => {
                WriteLiteral(@"
                                <div class=""row"">
                                    <div class=""col-md-12"">
                                        <div class=""col-md-6"">
                                            <label>Proje İsmi</label>
                                            <input type=""text"" id=""name"" class=""form-control"" placeholder=""Proje İsmi"" required>
                                            <br />
                                            <label>Fabrika Seç</label>
                                            <div id=""factoryDiv"">
                                                <select name=""select"" id=""factory"" class=""form-control"" required>
                                                </select>
                                            </div>
                                            <br />
                                            <label>Bölüm Seç</label>
                                            <div id=""factoryDepartmentDiv"">
                             ");
                WriteLiteral(@"                   <select name=""select"" id=""factoryDepartment"" class=""form-control"" required>
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
                                            <button style=""border-radius:10px;"" type=""button"" onclick=""addFactory()"" class=""btn btn-default""><i class=""fa fa-plus-square""></i> Fabrika Ekle </button>
                                            <br />
                                            <br />
                                            <br />
      ");
                WriteLiteral(@"                                      <button style=""margin-top:5px;border-radius:10px;width:131.81px;"" onclick=""addFactoryDepartment()"" type=""button"" class=""btn btn-default""><i class=""fa fa-plus-square""></i> Bölüm Ekle </button>
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
    $(document).ready(function () {
        getFactories();

        $('#factory').on(""change"", function () {
            getFactoryDepartment();
        })
    });

    // ===============================
    // Factory
    // ===============================
    function getFactories() {
        $.ajax({
            type: ""GET"",
            url: ""/Factory/GetAll"",
            data: ""{}"",
            success: function (data) {
                var s = '';
                for (var i = 0; i < data.factories.$values.length; i++) {
                    s += '<option value=""' + data.factories.$values[i].id + '"">' + data.factories.$values[i].name + '</option>';
                }
                $(""#factory"").html(s);
                getFactoryDepartment();
            }
        });
    }
    // ===============================
    function add");
            WriteLiteral(@"Factory() {
        var name = '';
        Swal.fire({
            title: 'Fabrika adını giriniz!',
            input: 'text',
            inputAttributes: {
                autocapitalize: 'off'
            },
            showCancelButton: true,
            cancelButtonText: 'Vazgeç',
            confirmButtonText: 'Ekle',
            showLoaderOnConfirm: true,
            preConfirm: (login) => {
                if (login != '') {
                    name = login;
                }
                else {
                    Swal.showValidationMessage(
                        `İsim alanı boş bırakılamaz!`
                    )
                }
            },
            allowOutsideClick: () => !Swal.isLoading()
        }).then((result) => {
            if (result.isConfirmed) {
                $.ajax({
                    url: '/Factory/Add/',
                    type: 'POST',
                    dataType: 'json',
                    data: {
                        'Name': nam");
            WriteLiteral(@"e,
                    },
                    success: function (data) {
                        Swal.fire({
                            position: 'center',
                            icon: 'success',
                            title: 'Başarıyla eklenmiştir!',
                            showConfirmButton: false,
                            timer: 800
                        }).then(() => {
                            $(""#factoryDiv"").load(getFactories());
                        })
                    },
                    error: function (data) {
                    }
                });
            }
        })
    }
    // ===============================
    // FactoryDepartment
    // ===============================
    function getFactoryDepartment() {
        $.ajax({
            type: ""GET"",
            url: ""/FactoryDepartment/GetByFactoryId?factoryId="" + $(""#factory"").val(),
            success: function (data) {
                $('#factoryDepartment').empty();
       ");
            WriteLiteral(@"         for (var i = 0; i < data.factoryDepartments.$values.length; i++) {
                    var select = document.getElementById(""factoryDepartment"");
                    select.appendChild(new Option(data.factoryDepartments.$values[i].name, data.factoryDepartments.$values[i].id));
                }
            }
        });
    }
    // ===============================
    function addFactoryDepartment() {
        var name = '';
        Swal.fire({
            title: 'Bölüm adını giriniz!',
            input: 'text',
            inputAttributes: {
                autocapitalize: 'off'
            },
            showCancelButton: true,
            cancelButtonText: 'Vazgeç',
            confirmButtonText: 'Ekle',
            showLoaderOnConfirm: true,
            preConfirm: (login) => {
                if (login != '') {
                    name = login;
                }
                else {
                    Swal.showValidationMessage(
                        `İsim alanı bo");
            WriteLiteral(@"ş bırakılamaz!`
                    )
                }
            },
            allowOutsideClick: () => !Swal.isLoading()
        }).then((result) => {
            if (result.isConfirmed) {
                $.ajax({
                    url: '/FactoryDepartment/Add/',
                    type: 'POST',
                    dataType: 'json',
                    data: {
                        'Name': name,
                        'FactoryId': $(""#factory"").val(),
                    },
                    success: function (data) {
                        Swal.fire({
                            position: 'center',
                            icon: 'success',
                            title: 'Başarıyla eklenmiştir!',
                            showConfirmButton: false,
                            timer: 800
                        }).then(() => {
                            $(""#factoryDepartmentDiv"").load(getFactoryDepartment());
                        })
                    },
   ");
            WriteLiteral(@"                 error: function (data) {
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
#line 212 "C:\Users\mehmetyen\source\repos\RobotMaintenance\RobotMaintenanceMvc\Views\Project\AddProject.cshtml"
                 Write(Url.Action("Add", "Project"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
                type: 'POST',
                dataType: 'json',
                data: {
                    'Name': $(""#name"").val(),
                    'FactoryDepartmentId': $(""#factoryDepartment"").val(),
                },
                success: function (data) {
                    if (data == true) {
                        Swal.fire({
                            position: 'center',
                            icon: 'success',
                            title: 'Başarıyla eklenmiştir!',
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
                            title: 'Bir hata oluştu.',
                            showConfirmButton: false,
    ");
            WriteLiteral(@"                        timer: 1500
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
