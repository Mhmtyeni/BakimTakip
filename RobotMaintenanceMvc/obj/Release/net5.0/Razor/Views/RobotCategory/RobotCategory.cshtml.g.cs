#pragma checksum "C:\Users\mehmetyen\source\repos\RobotMaintenance\RobotMaintenanceMvc\Views\RobotCategory\RobotCategory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d15c0fe795f434970fd601112fbe72a101737cfd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_RobotCategory_RobotCategory), @"mvc.1.0.view", @"/Views/RobotCategory/RobotCategory.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d15c0fe795f434970fd601112fbe72a101737cfd", @"/Views/RobotCategory/RobotCategory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"82c112082cfbb1c52093a18ca25afab572666c79", @"/Views/_ViewImports.cshtml")]
    public class Views_RobotCategory_RobotCategory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form_addCategory"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form_editCategory"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            <h2 class=""page-title"" style=""text-align:center""><strong>ROBOT KATEGORİ EKLE/DÜZENLE</strong></h2>
            <div class=""row"">
                <div class=""col-md-12"">
                    <div class=""panel"">
                        <div class=""panel-body"">
                            <div class=""panel-heading"">
                                <h3 class=""panel-title"" style=""text-align:center""><strong>Robot Bilgileri</strong></h3>
                            </div>
                            <br />
                            <div class=""row"">
                                <div class=""col-md-12"">
");
            WriteLiteral("                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d15c0fe795f434970fd601112fbe72a101737cfd9620", async() => {
                WriteLiteral(@"
                                        <div class=""col-md-5"">
                                            <h3 class=""panel-title"" style=""text-align:center""><strong>Robot Kategori Ekle</strong></h3>
                                            <br />
                                            <label>Kategori İsmi</label>
                                            <input type=""text"" id=""categoryNameAdd"" class=""form-control"" placeholder=""Kategori İsmi"" required>
                                            <br />
                                            <button id=""addCategory"" onclick=""postCategoryAdd()"" style=""border-radius:10px;"" type=""button"" class=""btn btn-success btn-block"">EKLE</button>
                                            <br />
                                            <br />
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
            WriteLiteral("\r\n");
            WriteLiteral("                                    <div class=\"col-md-2\">\r\n                                    </div>\r\n");
            WriteLiteral("\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d15c0fe795f434970fd601112fbe72a101737cfd12068", async() => {
                WriteLiteral(@"
                                        <div class=""col-md-5"">
                                            <h3 class=""panel-title"" style=""text-align:center""><strong>Kategori Düzenle</strong></h3>
                                            <br />
                                            <label>Kategori Seç</label>
                                            <select name=""select"" id=""category"" class=""form-control"" required>
                                            </select>
                                            <br />
                                            <label>Kategori İsmi</label>
                                            <input type=""text"" id=""categoryNameEdit"" class=""form-control"" placeholder=""Kategori İsmi"" required>
                                            <br />
                                            <div class=""row"">
                                                <div class=""col-md-6"">
                                                    <button id=""editCatego");
                WriteLiteral(@"ry"" onclick=""postCategoryEdit()"" style=""border-radius:10px;"" type=""submit"" class=""btn btn-primary btn-block"">KAYDET</button>
                                                </div>
                                                <div class=""col-md-6"">
                                                    <button id=""deleteCategory"" onclick=""postCategoryDelete()"" style=""border-radius:10px;"" type=""submit"" class=""btn btn-danger btn-block"">SİL</button>
                                                </div>
                                            </div>
                                            <br />
                                            <br />
                                        </div>
                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
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
            <!--<h2 class=""page-title"" style=""text-align:center""><strong>BÖLÜM EKLE/DÜZENLE</strong></h2>
            <div class=""row"">
                <div class=""col-md-12"">
                    <div class=""panel"">
                        <div class=""panel-body"">
                            <div class=""panel-heading"">
                                <h3 class=""panel-title"" style=""text-align:center""><strong>Bölüm Bilgileri</strong></h3>
                            </div>
                            <br />
                            <div class=""row"">
                                <div class=""col-md-12"">-->
");
            WriteLiteral(@"            <!--<form id=""form_addSubCategory"">
                <div class=""col-md-5"">
                    <h3 class=""panel-title"" style=""text-align:center""><strong>Alt Kategori Ekle</strong></h3>
                    <br />
                    <label>Kategori Seç</label>
                    <select name=""select"" id=""category2"" class=""form-control"" required>
                    </select>
                    <br />
                    <label>Alt Kategori İsmi</label>
                    <input type=""text"" id=""subCategoryNameAdd"" class=""form-control"" placeholder=""Alt Kategori İsmi"" required>
                    <br />
                    <button id=""addSubCategory"" onclick=""postSubCategoryAdd()"" style=""border-radius:10px;"" type=""button"" class=""btn btn-success btn-block"">EKLE</button>
                    <br />
                    <br />
                </div>
            </form>-->
");
            WriteLiteral("            <!--<div class=\"col-md-2\">\r\n            </div>-->\r\n");
            WriteLiteral(@"
            <!--<form id=""form_editSubCategory"" method=""post"">
                                        <div class=""col-md-5"">
                                            <h3 class=""panel-title"" style=""text-align:center""><strong>Alt Kategori Düzenle</strong></h3>
                                            <br />
                                            <label>Kategori Seç</label>
                                            <select name=""select"" id=""category3"" class=""form-control"" required>
                                            </select>
                                            <br />
                                            <label>Alt Kategori Seç</label>
                                            <select name=""select"" id=""subCategory"" class=""form-control"" required>
                                            </select>
                                            <br />
                                            <label>Alt Kategori İsmi</label>
                                  ");
            WriteLiteral(@"          <input type=""text"" id=""subCategoryNameEdit"" class=""form-control"" placeholder=""Alt Kategori İsmi"" required>
                                            <br />
                                            <div class=""row"">
                                                <div class=""col-md-6"">
                                                    <button id=""editSubCategory"" onclick=""postSubCategoryEdit()"" style=""border-radius:10px;"" type=""submit"" class=""btn btn-primary btn-block"">KAYDET</button>
                                                </div>
                                                <div class=""col-md-6"">
                                                    <button id=""deleteSubCategory"" onclick=""postSubCategoryDelete()"" style=""border-radius:10px;"" type=""submit"" class=""btn btn-danger btn-block"">SİL</button>
                                                </div>
                                            </div>
                                            <br />
                   ");
            WriteLiteral(@"                         <br />
                                        </div>
                                    </form>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>-->
        </div>
    </div>
</div>

<script>
        $(document).ready(function () {
            getRobotCategories();
        });

        $('#category').on(""change"", function () {
            getCategoryInfo();
        })



        // ===============================
        // Category
        // ===============================
        function getCategoryInfo() {
        $.ajax({
            type: ""GET"",
            url: ""/RobotCategory/GetById?Id="" + $(""#category"").val(),
            success: function (data) {
                if (data==null) {
                    $('#categoryNameEdit').val("""");
                }
                else {
                    $('#categoryNameEdit')");
            WriteLiteral(@".val(data.robotCategory.name);
                }
            }
        });
    }
        // ===============================
        function getRobotCategories() {
                $.ajax({
                    type: ""GET"",
                    url: ""/RobotCategory/GetAll"",
                    data: ""{}"",
                    success: function (data) {
                        var s = '';
                        for (var i = 0; i < data.robotCategories.$values.length; i++) {
                            s += '<option value=""' + data.robotCategories.$values[i].id + '"">' + data.robotCategories.$values[i].name + '</option>';
                        }
                        $(""#category"").html(s);
                        getCategoryInfo();
                    }
                });
        }
        // ===============================
        function postCategoryAdd() {
            if (document.forms['form_addCategory'].reportValidity()) {
                document.getElementById(""addCategory"").d");
            WriteLiteral("isabled = true;\r\n                $.ajax({\r\n                    url: \'");
#nullable restore
#line 182 "C:\Users\mehmetyen\source\repos\RobotMaintenance\RobotMaintenanceMvc\Views\RobotCategory\RobotCategory.cshtml"
                     Write(Url.Action("Add", "RobotCategory"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
                    type: 'POST',
                    dataType: 'json',
                    data: {
                        'Name': $(""#categoryNameAdd"").val(),
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
                                title: 'Bu kategori daha önce eklenmiştir.',
                 ");
            WriteLiteral(@"               showConfirmButton: false,
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
        // ===============================
        function postCategoryEdit() {
             if (document.forms['form_editCategory'].reportValidity()) {
                 document.getElementById(""editCategory"").disabled = true;
                $.ajax({
                    url: '/RobotCategory/Edit/',
                    type: 'POST',
                    dataType: 'json',
                    data: {
                        'Name': $(""#categoryNameEdit"").val(),
                        'Id': $(""#category"").val(),
                    },
                    success: function (data) {
                        if (data == true) {
 ");
            WriteLiteral(@"                           Swal.fire({
                                position: 'center',
                                icon: 'success',
                                title: 'Başarıyla güncellenmiştir!',
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
                                title: 'Aynı isimde bir fabrika mevcut!',
                                showConfirmButton: false,
                                timer: 1500
                            }).then(() => {
                                location.reload();
                            })
                        }
                    },
                   ");
            WriteLiteral(@" error: function (data) {
                    }
                });
            }
    }
        // ===============================
        // ===============================
        function postCategoryDelete() {
            if (document.forms['form_editCategory'].reportValidity()) {
                document.getElementById(""deleteCategory"").disabled = true;
                  Swal.fire({
            title: 'Kategoriyi silmek istiyor musunuz?',
            text: ""Kategori silindikten sonra tekrar geri alınamaz!"",
            icon: 'warning',
            showCancelButton: true,
            confirmButtonColor: '#3085d6',
            cancelButtonColor: '#d33',
            confirmButtonText: 'Evet, onaylıyorum',
            cancelButtonText: 'İptal'
        }).then((result) => {
            if (result.isConfirmed) {
                $.ajax({
                    url: '/RobotCategory/Delete/',
                    type: 'POST',
                    dataType: 'json',
                    data: {");
            WriteLiteral(@"
                        'Name': $(""#categoryNameEdit"").val(),
                        'Id': $(""#category"").val(),
                    },
                    success: function (data) {
                        if (data == true) {
                            Swal.fire({
                                position: 'center',
                                icon: 'success',
                                title: 'Başarıyla silinmiştir!',
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
                                title: 'Aynı isimde bir fabrika mevcut!',
                                showConfirmButton: false,
             ");
            WriteLiteral(@"                   timer: 1500
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
    }
        // ===============================
        // ===============================
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
