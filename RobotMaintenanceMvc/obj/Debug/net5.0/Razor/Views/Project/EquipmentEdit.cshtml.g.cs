#pragma checksum "C:\Users\mehmetyen\Desktop\RobotMaintenance\RobotMaintenanceMvc\Views\Project\EquipmentEdit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "42ec46555f0817e24985dfb7351ce0b4ca04dec6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Project_EquipmentEdit), @"mvc.1.0.view", @"/Views/Project/EquipmentEdit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"42ec46555f0817e24985dfb7351ce0b4ca04dec6", @"/Views/Project/EquipmentEdit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"82c112082cfbb1c52093a18ca25afab572666c79", @"/Views/_ViewImports.cshtml")]
    public class Views_Project_EquipmentEdit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProjectDto>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form_add"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\mehmetyen\Desktop\RobotMaintenance\RobotMaintenanceMvc\Views\Project\EquipmentEdit.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""modal fade"" id=""editProjectEquipmentModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""scrollmodalLabel"" aria-hidden=""true"" style=""margin-top: 2%;width:auto; height:auto"">
    <div class=""modal-dialog modal-lg"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <label class=""modal-title"" id=""scrollmodalLabel"">Ekipman Ekle/????kar</label>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <div class=""row"">
                    <div class=""col-md-12"">
                            <div class=""col-md-12"">
                                <label>Proje ??smi</label>
                                <input type=""text"" disabled id=""projectNameEdit"" class=""form-control"" placeholder=""Proje ??smi"" required");
            BeginWriteAttribute("value", " value=\"", 1026, "\"", 1053, 1);
#nullable restore
#line 19 "C:\Users\mehmetyen\Desktop\RobotMaintenance\RobotMaintenanceMvc\Views\Project\EquipmentEdit.cshtml"
WriteAttributeValue("", 1034, Model.Project.Name, 1034, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                <br />
                                <label>Ekipmanlar</label>
                                <div id=""equipmentDiv"">
                                    <select name=""select"" id=""projectEquipment"" class=""form-control"">
                                    </select>
                                </div>
                                <br />
                                <div class=""row"" id=""radioDiv"">
                                    <div class=""col-md-2"">
                                        <label class=""fancy-radio"">
                                            <input id=""radioBtnYes"" name=""radioBtn"" value=""yes"" type=""radio"">
                                            <span><i></i>Ekipman Ekle</span>
                                        </label>
                                    </div>
                                    <div class=""col-md-2"">
                                        <label class=""fancy-radio"">
                             ");
            WriteLiteral(@"               <input id=""radioBtnNo"" name=""radioBtn"" value=""no"" type=""radio"">
                                            <span><i></i>Ekipman Sil</span>
                                        </label>
                                    </div>
                                </div>
                                <br />
                                <div id=""addDiv"" style=""display:none"">
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "42ec46555f0817e24985dfb7351ce0b4ca04dec611141", async() => {
                WriteLiteral(@"
                                        <label>Kategori Se??</label>
                                        <select name=""select"" id=""equipmentCategory"" class=""form-control"" required>
                                        </select>
                                        <br />
                                        <label>Alt Kategori Se??</label>
                                        <select name=""select"" id=""equipmentSubCategory"" class=""form-control"" required>
                                        </select>
                                        <br />
                                        <label>Ekipman Se??</label>
                                        <select name=""select"" id=""equipment"" class=""form-control"" required>
                                        </select>
                                        <br />
                                        <button id=""add"" onclick=""postAddData()"" style=""border-radius:10px;"" type=""button"" class=""btn btn-success btn-block"">EKLE</button");
                WriteLiteral(">\r\n                                    ");
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
                                <div id=""deleteDiv"" style=""display:none"">                 
                                <button id=""add"" onclick=""postDeleteData()"" style=""border-radius:10px;"" type=""button"" class=""btn btn-danger btn-block"">S??L</button>
                                </div>
                                <br />
                            </div>
                    </div>
                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-danger"" data-dismiss=""modal"" >Kapat</button>
                </div>
            </div>
        </div>
    </div>
</div>

<script>
    var bLoad = true;
    var projectEquipmentId;
    $(document).ready(function () {
        getProjectEquipments();
        getEquipmentCategories();
        $('#equipmentCategory').on(""change"", function () {
            getEquipmentSubCategories();
        })
        $('#equipmentSubCategory').on(""change"",");
            WriteLiteral(@" function () {
            getEquipments();
        })
        // ===============================
        // RADIO BUTTON
        $('#radioBtnNo').on(""change"", function () {
            addDiv.style.display = ""none"";
            deleteDiv.style.display = """";
        })
        $('#radioBtnYes').on(""change"", function () {
            addDiv.style.display = """";
            deleteDiv.style.display = ""none"";
        })
    });

    // ===============================
    // ProjectEquipments
    // ===============================
    function getProjectEquipments() {
        $.ajax({
            type: ""GET"",
            url: ""/ProjectEquipment/GetByProjectIdEquipmentId?Id="" + ");
#nullable restore
#line 104 "C:\Users\mehmetyen\Desktop\RobotMaintenance\RobotMaintenanceMvc\Views\Project\EquipmentEdit.cshtml"
                                                                Write(Model.Project.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@",
            data: ""{}"",
            success: function (data) {
                console.log(data);
                $(""#projectEquipment"").empty();
                for (var i = 0; i < data.length; i++) {
                    var select = document.getElementById(""projectEquipment"");
                    var start = data[i].indexOf(""?"");
                    var end = data[i].length;
                    var start2 = data[i].indexOf(""|"");
                    var end2 = data[i].length;
                    equipmentId = data[i].substring(start + 1, end);
                    equipmentName = data[i].substring(0, start);
                    projectEquipmentId = data[i].substring(start2 + 1, end);
                    select.appendChild(new Option(equipmentName, projectEquipmentId));
                }
            }
        });
    }
    // ===============================
    // ===============================
    function getEquipmentCategories() {

        $.ajax({
            type: ""GET"",
      ");
            WriteLiteral(@"      url: ""/EquipmentCategory/GetBySubId?subId="" + 0,
            data: ""{}"",
            success: function (data) {
                var s = '';
                for (var i = 0; i < data.equipmentCategories.$values.length; i++) {
                    s += '<option value=""' + data.equipmentCategories.$values[i].id + '"">' + data.equipmentCategories.$values[i].name + '</option>';
                }
                $(""#equipmentCategory"").html(s);
                getEquipmentSubCategories();
            }
        });
    }
    // ===============================
    function getEquipmentSubCategories() {
        $.ajax({
            type: ""GET"",
            url: ""/EquipmentCategory/GetBySubId?subId="" + $(""#equipmentCategory"").val(),
            success: function (data) {
                $('#equipmentSubCategory').empty();
                for (var i = 0; i < data.equipmentCategories.$values.length; i++) {
                    var select = document.getElementById(""equipmentSubCategory"");
          ");
            WriteLiteral(@"          select.appendChild(new Option(data.equipmentCategories.$values[i].name, data.equipmentCategories.$values[i].id));
                }
                getEquipments();
            }
        });
    }
    // ===============================
    function getEquipments() {
        $.ajax({
            type: ""GET"",
            url: ""/Equipment/GetByEquimentCategoryId?equimentCategoryId="" + $(""#equipmentSubCategory"").val(),
            success: function (data) {
                $('#equipment').empty();
                for (var i = 0; i < data.equipments.$values.length; i++) {
                    var select = document.getElementById(""equipment"");
                    select.appendChild(new Option(data.equipments.$values[i].name, data.equipments.$values[i].id));
                }
            }
        });
    }
    // ===============================
    // ===============================
    // ===============================
    function postAddData() {
        if (document.forms['form_");
            WriteLiteral("add\'].reportValidity()) {\r\n            $.ajax({\r\n                url: \'");
#nullable restore
#line 176 "C:\Users\mehmetyen\Desktop\RobotMaintenance\RobotMaintenanceMvc\Views\Project\EquipmentEdit.cshtml"
                 Write(Url.Action("Add", "ProjectEquipment"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\',\r\n                type: \'POST\',\r\n                dataType: \'json\',\r\n                data: {\r\n                    \'ProjectId\': ");
#nullable restore
#line 180 "C:\Users\mehmetyen\Desktop\RobotMaintenance\RobotMaintenanceMvc\Views\Project\EquipmentEdit.cshtml"
                            Write(Model.Project.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@",
                    'EquipmentId': $(""#equipment"").val(),
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
                            $(""#addDiv"").load(getProjectEquipments());
                        })
                    }
                    else {
                        Swal.fire({
                            position: 'center',
                            icon: 'error',
                            title: 'Bu projeye daha ??nce bu ekipman eklenmi??tir.',
                            showConfirmButton: false,
                            timer: 1500
                        }).then(() => {
                         ");
            WriteLiteral(@"   $(""#addDiv"").load(getProjectEquipments());
                        })
                    }
                },
                error: function (data) {
                }
            });
        }
    }
    // ===============================
    function postDeleteData() {
        Swal.fire({
            title: 'Silmek istedi??inize emin misiniz?',
            text: ""Silme i??lemi geri al??namaz! Bu projeye ait bu ekipman silinecektir!"",
            icon: 'warning',
            showCancelButton: true,
            confirmButtonColor: '#d33',
            cancelButtonColor: '#3085d6',
            cancelButtonText: 'Vazge??',
            confirmButtonText: 'Evet, sil!'
        }).then((result) => {
            if (result.isConfirmed) {
                $.ajax({
                    type: ""POST"",
                    url: ""/ProjectEquipment/Delete?Id="" + $(""#projectEquipment"").val(),
                    success: function (result) {
                        Swal.fire({
                         ");
            WriteLiteral(@"   position: 'center',
                            icon: 'success',
                            title: 'Ba??ar??yla silinmi??tir!',
                            showConfirmButton: false,
                            timer: 800
                        }).then(() => {
                            $(""#addDiv"").load(getProjectEquipments());
                        })
                    },
                    error: function (data) {
                    }
                });
            }
        })
    }
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
