using AutoMapper;
using BusinessLayer.Abstract;
using ClosedXML.Excel;
using EntityLayer.Concrete;
using EntityLayer.Dtos.ProjectReportDtos;
using EntityLayer.Utilities.Results.ComplexTypes;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace RobotMaintenanceMvc.Controllers
{
    public class ProjectReportController : BaseController
    {

        private readonly IAppUserService _appUserManager;
        private readonly IProjectReportService _projectReportManager;
        public ProjectReportController(UserManager<AppUser> userManager, IMapper mapper, IAppUserService appUserManager, IProjectReportService projectReportManager) : base(userManager, mapper)
        {
            _appUserManager = appUserManager;
            _projectReportManager = projectReportManager;
        }

        [Authorize(Roles = "Admin,Engineer,SuperAdmin")]
        public async Task<IActionResult> AddProjectReport()
        {
            var result = await _appUserManager.GetAll();
            return View(result.Data);
        }
        [HttpPost]
        public async Task<JsonResult> Add(ProjectReportAddDto p)
        {
            p.CreatedByName = LoggedInUser.UserName;
            p.ModifiedByName = LoggedInUser.UserName;
            p.IsActive = true;
            p.IsDeleted = false;
            p.CreatedDate = DateTime.Now;
            p.ModifiedDate = DateTime.Now;
            var result = await _projectReportManager.Add(p);
            if (result.ResultStatus == ResultStatus.Success)
                return Json(true);
            else
                return Json(false);
        }
        public async Task<IActionResult> ProjectReportList()
        {
            var result = await _projectReportManager.GetAll();
            return View(result.Data);
        }
        public async Task<IActionResult> ProjectReportBzdList()
        {
            var result = await _projectReportManager.GetByFactory(3, 4, 6, 3);
            return View(result.Data);
        }
        public async Task<IActionResult> ProjectReportKmfList()
        {
            var result = await _projectReportManager.GetByFactory(5, 10, 11, 5);
            return View(result.Data);
        }
        public async Task<IActionResult> ProjectReportPcfList()
        {
            var result = await _projectReportManager.GetByFactory(2, 7, 8, 9);
            return View(result.Data);
        }
        public async Task<IActionResult> ProjectReportTgetList()
        {
            var result = await _projectReportManager.GetByFactory(12, 12, 12, 12);
            return View(result.Data);
        }

        [HttpPost]
        public async Task<JsonResult> Complete(ProjectReportUpdateDto p)
        {
            var result = await _projectReportManager.GetById(p.Id);
            p.ProjectId = result.Data.ProjectReport.ProjectId;
            p.Fault = result.Data.ProjectReport.Fault;
            p.AppUserId = result.Data.ProjectReport.AppUserId;
            p.Comment = result.Data.ProjectReport.Comment;
            p.Deadline = result.Data.ProjectReport.Deadline;
            p.CreatedDate = result.Data.ProjectReport.CreatedDate;
            p.CreatedByName = result.Data.ProjectReport.CreatedByName;
            p.ModifiedByName = LoggedInUser.FirstName + LoggedInUser.LastName;
            p.ModifiedDate = DateTime.Now;
            p.IsActive = true;
            p.IsDeleted = false;
            p.Note = result.Data.ProjectReport.Note;
            p.Completed = true;
            var result2 = await _projectReportManager.Update(p);
            if (result2.ResultStatus == ResultStatus.Success)
                return Json(true);
            else
                return Json(false);
        }
        [HttpPost]
        public async Task<JsonResult> Cancel(ProjectReportUpdateDto p)
        {
            var result = await _projectReportManager.GetById(p.Id);
            p.ProjectId = result.Data.ProjectReport.ProjectId;
            p.Fault = result.Data.ProjectReport.Fault;
            p.AppUserId = result.Data.ProjectReport.AppUserId;
            p.Comment = result.Data.ProjectReport.Comment;
            p.Deadline = result.Data.ProjectReport.Deadline;
            p.CreatedDate = result.Data.ProjectReport.CreatedDate;
            p.CreatedByName = "İptal Edildi";
            p.ModifiedByName = LoggedInUser.FirstName + LoggedInUser.LastName;
            p.ModifiedDate = DateTime.Now;
            p.IsActive = true;
            p.IsDeleted = false;
            p.Note = result.Data.ProjectReport.Note;
            p.Completed = true;
            var result2 = await _projectReportManager.Update(p);
            if (result2.ResultStatus == ResultStatus.Success)
                return Json(true);
            else
                return Json(false);
        }
        [HttpPost]
        public async Task<JsonResult> Undo(ProjectReportUpdateDto p)
        {
            var result = await _projectReportManager.GetById(p.Id);
            p.ProjectId = result.Data.ProjectReport.ProjectId;
            p.Fault = result.Data.ProjectReport.Fault;
            p.AppUserId = result.Data.ProjectReport.AppUserId;
            p.Comment = result.Data.ProjectReport.Comment;
            p.Deadline = result.Data.ProjectReport.Deadline;
            p.CreatedDate = result.Data.ProjectReport.CreatedDate;
            if (result.Data.ProjectReport.CreatedByName == "İptal Edildi")
                p.CreatedByName = LoggedInUser.UserName;
            else
                p.CreatedByName = result.Data.ProjectReport.CreatedByName;
            p.ModifiedByName = LoggedInUser.FirstName + LoggedInUser.LastName;
            p.ModifiedDate = DateTime.Now;
            p.IsActive = true;
            p.IsDeleted = false;
            p.Note = result.Data.ProjectReport.Note;
            p.Completed = false;
            var result2 = await _projectReportManager.Update(p);
            if (result2.ResultStatus == ResultStatus.Success)
                return Json(true);
            else
                return Json(false);
        }
        [HttpPost]
        public async Task<JsonResult> Delete(ProjectReportUpdateDto p)
        {
            var result = await _projectReportManager.GetById(p.Id);
            p.ProjectId = result.Data.ProjectReport.ProjectId;
            p.Fault = result.Data.ProjectReport.Fault;
            p.AppUserId = result.Data.ProjectReport.AppUserId;
            p.Comment = result.Data.ProjectReport.Comment;
            p.Deadline = result.Data.ProjectReport.Deadline;
            p.CreatedDate = result.Data.ProjectReport.CreatedDate;
            p.CreatedByName = "İptal Edildi";
            p.ModifiedByName = LoggedInUser.FirstName + LoggedInUser.LastName;
            p.ModifiedDate = DateTime.Now;
            p.IsActive = false;
            p.IsDeleted = true;
            p.Note = result.Data.ProjectReport.Note;
            p.Completed = true;
            var result2 = await _projectReportManager.Update(p);
            if (result2.ResultStatus == ResultStatus.Success)
                return Json(true);
            else
                return Json(false);
        }
        [Authorize(Roles = "Admin,Engineer,SuperAdmin")]
        public async Task<IActionResult> Edit(int id)
        {
            var result = await _projectReportManager.GetById(id);
            if (result.ResultStatus == ResultStatus.Success)
                return PartialView(result.Data);
            else
                return PartialView();
        }
        [Authorize(Roles = "Admin,Engineer,SuperAdmin")]
        public async Task<IActionResult> EditUser(int id)
        {           
            var user = await UserManager.FindByIdAsync(2.ToString());
            user.PhoneNumber = id.ToString();
            var update = await UserManager.UpdateAsync(user);
            var result = await _appUserManager.GetAll();
            if (result.ResultStatus == ResultStatus.Success)
                return PartialView(result.Data);
            else
                return PartialView();
        }
        [HttpPost]
        public async Task<JsonResult> Edit(ProjectReportUpdateDto p)
        {
            var result = await _projectReportManager.GetById(p.Id);
            p.ProjectId = result.Data.ProjectReport.ProjectId;
            p.Fault = result.Data.ProjectReport.Fault;
            p.AppUserId = result.Data.ProjectReport.AppUserId;
            p.Comment = result.Data.ProjectReport.Comment;
            p.Deadline = result.Data.ProjectReport.Deadline;
            p.ModifiedByName = LoggedInUser.FirstName + LoggedInUser.LastName;
            p.ModifiedDate = DateTime.Now;
            p.IsActive = true;
            p.IsDeleted = false;
            var result2 = await _projectReportManager.Update(p);
            if (result2.ResultStatus == ResultStatus.Success)
                return Json(true);
            else
                return Json(false);
        }
        [HttpPost]
        public async Task<JsonResult> Edit2(ProjectReportUpdateDto p)
        {
            var result = await _projectReportManager.GetById(p.Id);
            p.Deadline = result.Data.ProjectReport.Deadline;
            p.Note = result.Data.ProjectReport.Note;
            p.ModifiedByName = LoggedInUser.FirstName + LoggedInUser.LastName;
            p.ModifiedDate = DateTime.Now;
            p.IsActive = true;
            p.IsDeleted = false;
            var result2 = await _projectReportManager.Update(p);
            if (result2.ResultStatus == ResultStatus.Success)
                return Json(true);
            else
                return Json(false);
        }
        [HttpPost]
        public async Task<JsonResult> EditUser(ProjectReportUpdateDto p)
        {
            var result = await _projectReportManager.GetById(p.Id);
            p.ProjectId = result.Data.ProjectReport.ProjectId;
            p.Fault = result.Data.ProjectReport.Fault;
            p.AppUserId = result.Data.ProjectReport.AppUserId;
            p.Comment = result.Data.ProjectReport.Comment;
            p.Deadline = result.Data.ProjectReport.Deadline;
            p.CreatedDate = result.Data.ProjectReport.CreatedDate;
            p.CreatedByName = result.Data.ProjectReport.CreatedByName;
            if (p.Note == null)
                p.Note = result.Data.ProjectReport.Note;
            else
                p.Note = p.Note;
            p.ModifiedByName = LoggedInUser.FirstName + LoggedInUser.LastName;
            p.ModifiedDate = DateTime.Now;
            p.IsActive = true;
            p.IsDeleted = false;
            p.Completed = result.Data.ProjectReport.Completed;
            var result2 = await _projectReportManager.Update(p);
            if (result2.ResultStatus == ResultStatus.Success)
                return Json(true);
            else
                return Json(false);
        }
        #region Excel
        public async Task<IActionResult> ExportExcel()
        {
            var result = await _projectReportManager.GetAll();
            try
            {
                DataTable dataTable = new DataTable();
                dataTable = DataTableSave(result.Data.ProjectReports);
                dataTable.TableName = "Arızalar";
                using (XLWorkbook wb = new XLWorkbook())
                {
                    wb.ColumnWidth = 20;
                    wb.Worksheets.Add(dataTable);
                    using (MemoryStream stream = new MemoryStream())
                    {
                        wb.SaveAs(stream);
                        return File(stream.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Tüm Projeler.xlsx");
                    }
                }
            }
            catch (Exception ex)
            {
                ViewBag.message = ex.Message;
            }
            return RedirectToAction("AllProject");

        }
        public DataTable DataTableSave(IList<ProjectReport> projetReports)
        {
            DataTable table = new DataTable();
            table.Columns.Add("Fabrika İsmi");
            table.Columns.Add("Bölüm İsmi");
            table.Columns.Add("Proje İsmi");
            table.Columns.Add("Proje İle İlgili Madde");
            table.Columns.Add("Sorumlu");
            table.Columns.Add("Açıklama");
            table.Columns.Add("Termin");
            table.Columns.Add("Durum");
            foreach (ProjectReport item in projetReports)
            {
                DataRow row = table.NewRow();
                row["Fabrika İsmi"] = item.Project.FactoryDepartment.Factory.Name;
                row["Bölüm İsmi"] = item.Project.FactoryDepartment.Name;
                row["Proje İsmi"] = item.Project.Name;
                row["Proje İle İlgili Madde"] = item.Fault;
                row["Sorumlu"] = item.Note;
                row["Açıklama"] = item.Comment;
                row["Termin"] = item.Deadline.ToShortDateString();
                if (item.Completed)
                {
                    row["Durum"] = "Tamamlandı";
                }
                else
                {
                    row["Durum"] = "Devam Ediyor";
                }
                table.Rows.Add(row);
            }
            return table;
        }
        public async Task<IActionResult> ExportExcelBzd()
        {
            var result = await _projectReportManager.GetByFactory(3, 4, 6, 3);
            try
            {
                DataTable dataTable = new DataTable();
                dataTable = DataTableSaveBzd(result.Data.ProjectReports);
                dataTable.TableName = "Arızalar";
                using (XLWorkbook wb = new XLWorkbook())
                {
                    wb.ColumnWidth = 20;
                    wb.Worksheets.Add(dataTable);
                    using (MemoryStream stream = new MemoryStream())
                    {
                        wb.SaveAs(stream);
                        return File(stream.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Bzd Fabrikası Projeleri.xlsx");
                    }
                }
            }
            catch (Exception ex)
            {
                ViewBag.message = ex.Message;
            }
            return RedirectToAction("AllProject");

        }
        public DataTable DataTableSaveBzd(IList<ProjectReport> projectReports)
        {
            DataTable table = new DataTable();
            table.Columns.Add("Fabrika İsmi");
            table.Columns.Add("Bölüm İsmi");
            table.Columns.Add("Proje İsmi");
            table.Columns.Add("Proje İle İlgili Madde");
            table.Columns.Add("Sorumlu");
            table.Columns.Add("Açıklama");
            table.Columns.Add("Termin");
            table.Columns.Add("Durum");
            foreach (ProjectReport item in projectReports)
            {
                DataRow row = table.NewRow();
                row["Fabrika İsmi"] = item.Project.FactoryDepartment.Factory.Name;
                row["Bölüm İsmi"] = item.Project.FactoryDepartment.Name;
                row["Proje İsmi"] = item.Project.Name;
                row["Proje İle İlgili Madde"] = item.Fault;
                row["Sorumlu"] = item.Note;
                row["Açıklama"] = item.Comment;
                row["Termin"] = item.Deadline.ToShortDateString();
                if (item.Completed)
                {
                    row["Durum"] = "Tamamlandı";
                }
                else
                {
                    row["Durum"] = "Devam Ediyor";
                }
                table.Rows.Add(row);
            }
            return table;
        }
        public async Task<IActionResult> ExportExcelKmf()
        {
            var result = await _projectReportManager.GetByFactory(5, 10, 11, 5);
            try
            {
                DataTable dataTable = new DataTable();
                dataTable = DataTableSaveBzd(result.Data.ProjectReports);
                dataTable.TableName = "Arızalar";
                using (XLWorkbook wb = new XLWorkbook())
                {
                    wb.ColumnWidth = 20;
                    wb.Worksheets.Add(dataTable);
                    using (MemoryStream stream = new MemoryStream())
                    {
                        wb.SaveAs(stream);
                        return File(stream.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Cmf-Kmf Fabrikası Projeleri.xlsx");
                    }
                }
            }
            catch (Exception ex)
            {
                ViewBag.message = ex.Message;
            }
            return RedirectToAction("AllProject");

        }
        public DataTable DataTableSaveKmf(IList<ProjectReport> projectReports)
        {
            DataTable table = new DataTable();
            table.Columns.Add("Fabrika İsmi");
            table.Columns.Add("Bölüm İsmi");
            table.Columns.Add("Proje İsmi");
            table.Columns.Add("Proje İle İlgili Madde");
            table.Columns.Add("Sorumlu");
            table.Columns.Add("Açıklama");
            table.Columns.Add("Termin");
            table.Columns.Add("Durum");
            foreach (ProjectReport item in projectReports)
            {
                DataRow row = table.NewRow();
                row["Fabrika İsmi"] = item.Project.FactoryDepartment.Factory.Name;
                row["Bölüm İsmi"] = item.Project.FactoryDepartment.Name;
                row["Proje İsmi"] = item.Project.Name;
                row["Proje İle İlgili Madde"] = item.Fault;
                row["Sorumlu"] = item.Note;
                row["Açıklama"] = item.Comment;
                row["Termin"] = item.Deadline.ToShortDateString();
                if (item.Completed)
                {
                    row["Durum"] = "Tamamlandı";
                }
                else
                {
                    row["Durum"] = "Devam Ediyor";
                }
                table.Rows.Add(row);
            }
            return table;
        }
        public async Task<IActionResult> ExportExcelPcf()
        {
            var result = await _projectReportManager.GetByFactory(2, 7, 8, 9);
            try
            {
                DataTable dataTable = new DataTable();
                dataTable = DataTableSaveBzd(result.Data.ProjectReports);
                dataTable.TableName = "Arızalar";
                using (XLWorkbook wb = new XLWorkbook())
                {
                    wb.ColumnWidth = 20;
                    wb.Worksheets.Add(dataTable);
                    using (MemoryStream stream = new MemoryStream())
                    {
                        wb.SaveAs(stream);
                        return File(stream.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Pcf-Klm-Bmf Fabrikası Projeleri.xlsx");
                    }
                }
            }
            catch (Exception ex)
            {
                ViewBag.message = ex.Message;
            }
            return RedirectToAction("AllProject");

        }
        public DataTable DataTableSavePcf(IList<ProjectReport> projetReports)
        {
            DataTable table = new DataTable();
            table.Columns.Add("Fabrika İsmi");
            table.Columns.Add("Bölüm İsmi");
            table.Columns.Add("Proje İsmi");
            table.Columns.Add("Proje İle İlgili Madde");
            table.Columns.Add("Sorumlu");
            table.Columns.Add("Açıklama");
            table.Columns.Add("Termin");
            table.Columns.Add("Durum");
            foreach (ProjectReport item in projetReports)
            {
                DataRow row = table.NewRow();
                row["Fabrika İsmi"] = item.Project.FactoryDepartment.Factory.Name;
                row["Bölüm İsmi"] = item.Project.FactoryDepartment.Name;
                row["Proje İsmi"] = item.Project.Name;
                row["Proje İle İlgili Madde"] = item.Fault;
                row["Sorumlu"] = item.Note;
                row["Açıklama"] = item.Comment;
                row["Termin"] = item.Deadline.ToShortDateString();
                if (item.Completed)
                {
                    row["Durum"] = "Tamamlandı";
                }
                else
                {
                    row["Durum"] = "Devam Ediyor";
                }
                table.Rows.Add(row);
            }
            return table;
        }
        public async Task<IActionResult> ExportExcelTget()
        {
            var result = await _projectReportManager.GetByFactory(2, 7, 8, 9);
            try
            {
                DataTable dataTable = new DataTable();
                dataTable = DataTableSaveBzd(result.Data.ProjectReports);
                dataTable.TableName = "Arızalar";
                using (XLWorkbook wb = new XLWorkbook())
                {
                    wb.ColumnWidth = 20;
                    wb.Worksheets.Add(dataTable);
                    using (MemoryStream stream = new MemoryStream())
                    {
                        wb.SaveAs(stream);
                        return File(stream.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Tget Projeler.xlsx");
                    }
                }
            }
            catch (Exception ex)
            {
                ViewBag.message = ex.Message;
            }
            return RedirectToAction("AllProject");

        }
        public DataTable DataTableSaveTget(IList<ProjectReport> projectReports)
        {
            DataTable table = new DataTable();
            table.Columns.Add("Fabrika İsmi");
            table.Columns.Add("Bölüm İsmi");
            table.Columns.Add("Proje İsmi");
            table.Columns.Add("Proje İle İlgili Madde");
            table.Columns.Add("Sorumlu");
            table.Columns.Add("Açıklama");
            table.Columns.Add("Termin");
            table.Columns.Add("Durum");
            foreach (ProjectReport item in projectReports)
            {
                DataRow row = table.NewRow();
                row["Fabrika İsmi"] = item.Project.FactoryDepartment.Factory.Name;
                row["Bölüm İsmi"] = item.Project.FactoryDepartment.Name;
                row["Proje İsmi"] = item.Project.Name;
                row["Proje İle İlgili Madde"] = item.Fault;
                row["Sorumlu"] = item.Note;
                row["Açıklama"] = item.Comment;
                row["Termin"] = item.Deadline.ToShortDateString();
                if (item.Completed)
                {
                    row["Durum"] = "Tamamlandı";
                }
                else
                {
                    row["Durum"] = "Devam Ediyor";
                }
                table.Rows.Add(row);
            }
            return table;
        }
        #endregion
    }
}
