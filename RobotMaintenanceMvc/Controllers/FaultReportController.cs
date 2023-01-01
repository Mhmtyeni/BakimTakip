using AutoMapper;
using BusinessLayer.Abstract;
using ClosedXML.Excel;
using EntityLayer.Concrete;
using EntityLayer.Dtos.FaultReportDtos;
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
    public class FaultReportController : BaseController
    {

        private readonly IAppUserService _appUserManager;
        private readonly IFaultReportService _faultReportManager;
        public FaultReportController(UserManager<AppUser> userManager, IMapper mapper, IAppUserService appUserManager, IFaultReportService faultReportManager) : base(userManager, mapper)
        {
            _appUserManager = appUserManager;
            _faultReportManager = faultReportManager;
        }

        [Authorize(Roles = "Admin,Engineer,SuperAdmin")]
        public async Task<IActionResult> AddFaultReport()
        {
            var result = await _appUserManager.GetAll();
            return View(result.Data);
        }
        [HttpPost]
        public async Task<JsonResult> Add(FaultReportAddDto p)
        {
            p.CreatedByName = LoggedInUser.UserName;
            p.ModifiedByName = LoggedInUser.UserName;
            p.IsActive = true;
            p.IsDeleted = false;
            p.CreatedDate = DateTime.Now;
            p.ModifiedDate = DateTime.Now;
            var result = await _faultReportManager.Add(p);
            if (result.ResultStatus == ResultStatus.Success)
                return Json(true);
            else
                return Json(false);
        }
        public async Task<IActionResult> FaultReportList()
        {
            var result = await _faultReportManager.GetAll();
            return View(result.Data);
        }
        public async Task<IActionResult> FaultReportPcfList()
        {
            var result = await _faultReportManager.GetByFactory(2, 7, 8, 9);
            return View(result.Data);
        }
        public async Task<IActionResult> FaultReportBzdList()
        {
            var result = await _faultReportManager.GetByFactory(3, 4, 6, 3);
            return View(result.Data);
        }
        public async Task<IActionResult> FaultReportKmfList()
        {
            var result = await _faultReportManager.GetByFactory(5, 10, 11, 5);
            return View(result.Data);
        }
        public async Task<IActionResult> FaultReportTgetList()
        {
            var result = await _faultReportManager.GetByFactory(12, 12, 12, 12);
            return View(result.Data);
        }
        [HttpPost]
        public async Task<JsonResult> Complete(FaultReportUpdateDto p)
        {
            var result = await _faultReportManager.GetById(p.Id);
            p.ProjectId = result.Data.FaultReport.ProjectId;
            p.Fault = result.Data.FaultReport.Fault;
            p.AppUserId = result.Data.FaultReport.AppUserId;
            p.Comment = result.Data.FaultReport.Comment;
            p.Deadline1 = result.Data.FaultReport.Deadline1;
            p.Deadline2 = result.Data.FaultReport.Deadline2;
            p.Deadline3 = result.Data.FaultReport.Deadline3;
            p.CreatedDate = result.Data.FaultReport.CreatedDate;
            p.CreatedByName = result.Data.FaultReport.CreatedByName;
            p.ModifiedByName = LoggedInUser.FirstName + LoggedInUser.LastName;
            p.ModifiedDate = DateTime.Now;
            p.IsActive = true;
            p.IsDeleted = false;
            p.Note = result.Data.FaultReport.Note;
            p.Completed = true;
            var result2 = await _faultReportManager.Update(p);
            if (result2.ResultStatus == ResultStatus.Success)
                return Json(true);
            else
                return Json(false);
        }
        [HttpPost]
        public async Task<JsonResult> Cancel(FaultReportUpdateDto p)
        {
            var result = await _faultReportManager.GetById(p.Id);
            p.ProjectId = result.Data.FaultReport.ProjectId;
            p.Fault = result.Data.FaultReport.Fault;
            p.AppUserId = result.Data.FaultReport.AppUserId;
            p.Comment = result.Data.FaultReport.Comment;
            p.Deadline1 = result.Data.FaultReport.Deadline1;
            p.Deadline2 = result.Data.FaultReport.Deadline2;
            p.Deadline3 = result.Data.FaultReport.Deadline3;
            p.CreatedDate = result.Data.FaultReport.CreatedDate;
            p.CreatedByName = "İptal Edildi";
            p.ModifiedByName = LoggedInUser.FirstName + LoggedInUser.LastName;
            p.ModifiedDate = DateTime.Now;
            p.IsActive = true;
            p.IsDeleted = false;
            p.Note = result.Data.FaultReport.Note;
            p.Completed = true;
            var result2 = await _faultReportManager.Update(p);
            if (result2.ResultStatus == ResultStatus.Success)
                return Json(true);
            else
                return Json(false);
        }
        [HttpPost]
        public async Task<JsonResult> Undo(FaultReportUpdateDto p)
        {
            var result = await _faultReportManager.GetById(p.Id);
            p.ProjectId = result.Data.FaultReport.ProjectId;
            p.Fault = result.Data.FaultReport.Fault;
            p.AppUserId = result.Data.FaultReport.AppUserId;
            p.Comment = result.Data.FaultReport.Comment;
            p.Deadline1 = result.Data.FaultReport.Deadline1;
            p.Deadline2 = result.Data.FaultReport.Deadline2;
            p.Deadline3 = result.Data.FaultReport.Deadline3;
            p.CreatedDate = result.Data.FaultReport.CreatedDate;
            if (result.Data.FaultReport.CreatedByName == "İptal Edildi")
                p.CreatedByName = LoggedInUser.UserName;
            else
                p.CreatedByName = result.Data.FaultReport.CreatedByName;
            p.ModifiedByName = LoggedInUser.FirstName + LoggedInUser.LastName;
            p.ModifiedDate = DateTime.Now;
            p.IsActive = true;
            p.IsDeleted = false;
            p.Note = result.Data.FaultReport.Note;
            p.Completed = false;
            var result2 = await _faultReportManager.Update(p);
            if (result2.ResultStatus == ResultStatus.Success)
                return Json(true);
            else
                return Json(false);
        }
        [HttpPost]
        public async Task<JsonResult> Delete(FaultReportUpdateDto p)
        {
            var result = await _faultReportManager.GetById(p.Id);
            p.ProjectId = result.Data.FaultReport.ProjectId;
            p.Fault = result.Data.FaultReport.Fault;
            p.AppUserId = result.Data.FaultReport.AppUserId;
            p.Comment = result.Data.FaultReport.Comment;
            p.Deadline1 = result.Data.FaultReport.Deadline1;
            p.Deadline2 = result.Data.FaultReport.Deadline2;
            p.Deadline3 = result.Data.FaultReport.Deadline3;
            p.CreatedDate = result.Data.FaultReport.CreatedDate;
            p.CreatedByName = "İptal Edildi";
            p.ModifiedByName = LoggedInUser.FirstName + LoggedInUser.LastName;
            p.ModifiedDate = DateTime.Now;
            p.IsActive = false;
            p.IsDeleted = true;
            p.Note = result.Data.FaultReport.Note;
            p.Completed = true;
            var result2 = await _faultReportManager.Update(p);
            if (result2.ResultStatus == ResultStatus.Success)
                return Json(true);
            else
                return Json(false);
        }
        [Authorize(Roles = "Admin,Engineer,SuperAdmin")]
        public async Task<IActionResult> Edit(int id)
        {
            var result = await _faultReportManager.GetById(id);
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
        public async Task<JsonResult> Edit(FaultReportUpdateDto p)
        {
            var result = await _faultReportManager.GetById(p.Id);
            p.ProjectId = result.Data.FaultReport.ProjectId;
            p.Fault = result.Data.FaultReport.Fault;
            p.AppUserId = result.Data.FaultReport.AppUserId;
            p.Comment = result.Data.FaultReport.Comment;
            p.Deadline1 = result.Data.FaultReport.Deadline1;
            p.Deadline2 = result.Data.FaultReport.Deadline2;
            p.Deadline3 = result.Data.FaultReport.Deadline3;
            p.ModifiedByName = LoggedInUser.FirstName + LoggedInUser.LastName;
            p.ModifiedDate = DateTime.Now;
            p.IsActive = true;
            p.IsDeleted = false;
            var result2 = await _faultReportManager.Update(p);
            if (result2.ResultStatus == ResultStatus.Success)
                return Json(true);
            else
                return Json(false);
        }
        [HttpPost]
        public async Task<JsonResult> Edit2(FaultReportUpdateDto p)
        {
            var result = await _faultReportManager.GetById(p.Id);
            p.Deadline2 = result.Data.FaultReport.Deadline2;
            p.Deadline3 = result.Data.FaultReport.Deadline3;
            p.ModifiedByName = LoggedInUser.FirstName + LoggedInUser.LastName;
            p.ModifiedDate = DateTime.Now;
            p.Note = result.Data.FaultReport.Note;
            p.IsActive = true;
            p.IsDeleted = false;
            var result2 = await _faultReportManager.Update(p);
            if (result2.ResultStatus == ResultStatus.Success)
                return Json(true);
            else
                return Json(false);
        }
        [HttpPost]
        public async Task<JsonResult> EditUser(FaultReportUpdateDto p)
        {
            var result = await _faultReportManager.GetById(p.Id);
            p.ProjectId = result.Data.FaultReport.ProjectId;
            p.Fault = result.Data.FaultReport.Fault;
            p.AppUserId = result.Data.FaultReport.AppUserId;
            p.Comment = result.Data.FaultReport.Comment;
            p.Deadline1 = result.Data.FaultReport.Deadline1;
            p.Deadline2 = result.Data.FaultReport.Deadline2;
            p.Deadline3 = result.Data.FaultReport.Deadline3;
            p.CreatedDate = result.Data.FaultReport.CreatedDate;
            p.CreatedByName = result.Data.FaultReport.CreatedByName;
            if (p.Note == null)
                p.Note = result.Data.FaultReport.Note;
            else
                p.Note = p.Note;
            p.ModifiedByName = LoggedInUser.FirstName + LoggedInUser.LastName;
            p.ModifiedDate = DateTime.Now;
            p.IsActive = true;
            p.IsDeleted = false;
            p.Completed = result.Data.FaultReport.Completed;
            var result2 = await _faultReportManager.Update(p);
            if (result2.ResultStatus == ResultStatus.Success)
                return Json(true);
            else
                return Json(false);
        }
        #region Excel
        public async Task<IActionResult> ExportExcel()
        {
            var result = await _faultReportManager.GetAll();
            try
            {
                DataTable dataTable = new DataTable();
                dataTable = DataTableSave(result.Data.FaultReports);
                dataTable.TableName = "Arızalar";
                using (XLWorkbook wb = new XLWorkbook())
                {
                    wb.ColumnWidth = 20;
                    wb.Worksheets.Add(dataTable);
                    using (MemoryStream stream = new MemoryStream())
                    {
                        wb.SaveAs(stream);
                        return File(stream.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Tüm Arızalar.xlsx");
                    }
                }
            }
            catch (Exception ex)
            {
                ViewBag.message = ex.Message;
            }
            return RedirectToAction("AllProject");

        }
        public DataTable DataTableSave(IList<FaultReport> faultReports)
        {
            DataTable table = new DataTable();
            table.Columns.Add("Fabrika İsmi");
            table.Columns.Add("Bölüm İsmi");
            table.Columns.Add("Proje İsmi");
            table.Columns.Add("Arızayla İlgili Madde");
            table.Columns.Add("Sorumlu");
            table.Columns.Add("Açıklama");
            table.Columns.Add("Termin");
            table.Columns.Add("Durum");
            foreach (FaultReport item in faultReports)
            {
                DataRow row = table.NewRow();
                row["Fabrika İsmi"] = item.Project.FactoryDepartment.Factory.Name;
                row["Bölüm İsmi"] = item.Project.FactoryDepartment.Name;
                row["Proje İsmi"] = item.Project.Name;
                row["Arızayla İlgili Madde"] = item.Fault;
                row["Sorumlu"] = item.Note;
                row["Açıklama"] = item.Comment;
                row["Termin"] = item.Deadline1.ToShortDateString();
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
            var result = await _faultReportManager.GetByFactory(3, 4, 6, 3);
            try
            {
                DataTable dataTable = new DataTable();
                dataTable = DataTableSaveBzd(result.Data.FaultReports);
                dataTable.TableName = "Arızalar";
                using (XLWorkbook wb = new XLWorkbook())
                {
                    wb.ColumnWidth = 20;
                    wb.Worksheets.Add(dataTable);
                    using (MemoryStream stream = new MemoryStream())
                    {
                        wb.SaveAs(stream);
                        return File(stream.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Bzd Fabrikası Arızaları.xlsx");
                    }
                }
            }
            catch (Exception ex)
            {
                ViewBag.message = ex.Message;
            }
            return RedirectToAction("AllProject");

        }
        public DataTable DataTableSaveBzd(IList<FaultReport> faultReports)
        {
            DataTable table = new DataTable();
            table.Columns.Add("Fabrika İsmi");
            table.Columns.Add("Bölüm İsmi");
            table.Columns.Add("Proje İsmi");
            table.Columns.Add("Arızayla İlgili Madde");
            table.Columns.Add("Sorumlu");
            table.Columns.Add("Açıklama");
            table.Columns.Add("Termin");
            table.Columns.Add("Durum");
            foreach (FaultReport item in faultReports)
            {
                DataRow row = table.NewRow();
                row["Fabrika İsmi"] = item.Project.FactoryDepartment.Factory.Name;
                row["Bölüm İsmi"] = item.Project.FactoryDepartment.Name;
                row["Proje İsmi"] = item.Project.Name;
                row["Arızayla İlgili Madde"] = item.Fault;
                row["Sorumlu"] = item.Note;
                row["Açıklama"] = item.Comment;
                row["Termin"] = item.Deadline1.ToShortDateString();
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
            var result = await _faultReportManager.GetByFactory(5, 10, 11, 5);
            try
            {
                DataTable dataTable = new DataTable();
                dataTable = DataTableSaveBzd(result.Data.FaultReports);
                dataTable.TableName = "Arızalar";
                using (XLWorkbook wb = new XLWorkbook())
                {
                    wb.ColumnWidth = 20;
                    wb.Worksheets.Add(dataTable);
                    using (MemoryStream stream = new MemoryStream())
                    {
                        wb.SaveAs(stream);
                        return File(stream.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Cmf-Kmf Fabrikası Arızaları.xlsx");
                    }
                }
            }
            catch (Exception ex)
            {
                ViewBag.message = ex.Message;
            }
            return RedirectToAction("AllProject");

        }
        public DataTable DataTableSaveKmf(IList<FaultReport> faultReports)
        {
            DataTable table = new DataTable();
            table.Columns.Add("Fabrika İsmi");
            table.Columns.Add("Bölüm İsmi");
            table.Columns.Add("Proje İsmi");
            table.Columns.Add("Arızayla İlgili Madde");
            table.Columns.Add("Sorumlu");
            table.Columns.Add("Açıklama");
            table.Columns.Add("Termin");
            table.Columns.Add("Durum");
            foreach (FaultReport item in faultReports)
            {
                DataRow row = table.NewRow();
                row["Fabrika İsmi"] = item.Project.FactoryDepartment.Factory.Name;
                row["Bölüm İsmi"] = item.Project.FactoryDepartment.Name;
                row["Proje İsmi"] = item.Project.Name;
                row["Arızayla İlgili Madde"] = item.Fault;
                row["Sorumlu"] = item.Note;
                row["Açıklama"] = item.Comment;
                row["Termin"] = item.Deadline1.ToShortDateString();
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
            var result = await _faultReportManager.GetByFactory(2, 7, 8, 9);
            try
            {
                DataTable dataTable = new DataTable();
                dataTable = DataTableSaveBzd(result.Data.FaultReports);
                dataTable.TableName = "Arızalar";
                using (XLWorkbook wb = new XLWorkbook())
                {
                    wb.ColumnWidth = 20;
                    wb.Worksheets.Add(dataTable);
                    using (MemoryStream stream = new MemoryStream())
                    {
                        wb.SaveAs(stream);
                        return File(stream.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Pcf-Klm-Bmf Fabrikası Arızaları.xlsx");
                    }
                }
            }
            catch (Exception ex)
            {
                ViewBag.message = ex.Message;
            }
            return RedirectToAction("AllProject");

        }
        public DataTable DataTableSavePcf(IList<FaultReport> faultReports)
        {
            DataTable table = new DataTable();
            table.Columns.Add("Fabrika İsmi");
            table.Columns.Add("Bölüm İsmi");
            table.Columns.Add("Proje İsmi");
            table.Columns.Add("Arızayla İlgili Madde");
            table.Columns.Add("Sorumlu");
            table.Columns.Add("Açıklama");
            table.Columns.Add("Termin");
            table.Columns.Add("Durum");
            foreach (FaultReport item in faultReports)
            {
                DataRow row = table.NewRow();
                row["Fabrika İsmi"] = item.Project.FactoryDepartment.Factory.Name;
                row["Bölüm İsmi"] = item.Project.FactoryDepartment.Name;
                row["Proje İsmi"] = item.Project.Name;
                row["Arızayla İlgili Madde"] = item.Fault;
                row["Sorumlu"] = item.Note;
                row["Açıklama"] = item.Comment;
                row["Termin"] = item.Deadline1.ToShortDateString();
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
            var result = await _faultReportManager.GetByFactory(2, 7, 8, 9);
            try
            {
                DataTable dataTable = new DataTable();
                dataTable = DataTableSaveBzd(result.Data.FaultReports);
                dataTable.TableName = "Arızalar";
                using (XLWorkbook wb = new XLWorkbook())
                {
                    wb.ColumnWidth = 20;
                    wb.Worksheets.Add(dataTable);
                    using (MemoryStream stream = new MemoryStream())
                    {
                        wb.SaveAs(stream);
                        return File(stream.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Tget Arızalar.xlsx");
                    }
                }
            }
            catch (Exception ex)
            {
                ViewBag.message = ex.Message;
            }
            return RedirectToAction("AllProject");

        }
        public DataTable DataTableSaveTget(IList<FaultReport> faultReports)
        {
            DataTable table = new DataTable();
            table.Columns.Add("Fabrika İsmi");
            table.Columns.Add("Bölüm İsmi");
            table.Columns.Add("Proje İsmi");
            table.Columns.Add("Arızayla İlgili Madde");
            table.Columns.Add("Sorumlu");
            table.Columns.Add("Açıklama");
            table.Columns.Add("Termin");
            table.Columns.Add("Durum");
            foreach (FaultReport item in faultReports)
            {
                DataRow row = table.NewRow();
                row["Fabrika İsmi"] = item.Project.FactoryDepartment.Factory.Name;
                row["Bölüm İsmi"] = item.Project.FactoryDepartment.Name;
                row["Proje İsmi"] = item.Project.Name;
                row["Arızayla İlgili Madde"] = item.Fault;
                row["Sorumlu"] = item.Note;
                row["Açıklama"] = item.Comment;
                row["Termin"] = item.Deadline1.ToShortDateString();
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
