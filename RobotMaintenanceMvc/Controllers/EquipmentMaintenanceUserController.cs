using AutoMapper;
using BusinessLayer.Abstract;
using ClosedXML.Excel;
using EntityLayer.Concrete;
using EntityLayer.Dtos.EquipmentMaintenanceUserDtos;
using EntityLayer.Dtos.ProjectEquipmentDtos;
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
    public class EquipmentMaintenanceUserController : BaseController
    {
        private readonly IProjectEquipmentService _projectEquipmentManager;
        private readonly IEquipmentMaintenanceService _equipmentMaintenanceManager;
        private readonly IEquipmentMaintenanceUserService _equipmentMaintenanceUserManager;
        public EquipmentMaintenanceUserController(UserManager<AppUser> userManager, IMapper mapper, IEquipmentMaintenanceService equipmentMaintenanceManager, IEquipmentMaintenanceUserService equipmentMaintenanceUserManager, IProjectEquipmentService projectEquipmentManager) : base(userManager, mapper)
        {
            _equipmentMaintenanceManager = equipmentMaintenanceManager;
            _equipmentMaintenanceUserManager = equipmentMaintenanceUserManager;
            _projectEquipmentManager = projectEquipmentManager;
        }
        [Authorize(Roles = "Admin,Engineer,SuperAdmin")]
        public IActionResult AddEquipmentMaintenanceUser()
        {
            return View();
        }

        public async Task<IActionResult> EquipmentMaintenanceUser()
        {
            var result = await _equipmentMaintenanceUserManager.GetAll();
            return View(result.Data);
        }
        [HttpPost]
        public async Task<JsonResult> Add(EquipmentMaintenanceUserAddDto p)
        {
            var result2 = await _projectEquipmentManager.GetById(p.ProjectEquipmentId);
            p.CreatedByName = LoggedInUser.UserName;
            p.ModifiedByName = LoggedInUser.UserName;
            p.IsActive = true;
            p.IsDeleted = false;
            p.CreatedDate = DateTime.Now;
            p.ModifiedDate = DateTime.Now;
            p.MaintenanceDate = DateTime.Now;
            var result = await _equipmentMaintenanceUserManager.Add(p);
            if (result.ResultStatus == ResultStatus.Success)
            {
                ProjectEquipmentUpdateDto editProjectEquipment = new ProjectEquipmentUpdateDto
                {
                    Id = p.ProjectEquipmentId,
                    EquipmentId = result2.Data.ProjectEquipment.EquipmentId,
                    ProjectId = result2.Data.ProjectEquipment.ProjectId,
                    CreatedDate = result2.Data.ProjectEquipment.CreatedDate,
                    CreatedByName = result2.Data.ProjectEquipment.CreatedByName,
                    ModifiedDate = result2.Data.ProjectEquipment.ModifiedDate,
                    ModifiedByName = result2.Data.ProjectEquipment.ModifiedByName,
                    IsActive = true,
                    IsDeleted = false,
                    CheckMaintenance = true

                };
                await _projectEquipmentManager.Update(editProjectEquipment);
            }
            if (result.ResultStatus == ResultStatus.Success)
                return Json(true);
            else
                return Json(false);
        }
        public async Task<IActionResult> ExportExcel()
        {
            var result = await _equipmentMaintenanceUserManager.GetAll();
            try
            {
                DataTable dataTable = new DataTable();
                dataTable = DataTableSave(result.Data.EquipmentMaintenanceUsers);
                dataTable.TableName = "Arızalar";
                using (XLWorkbook wb = new XLWorkbook())
                {
                    wb.ColumnWidth = 20;
                    wb.Worksheets.Add(dataTable);
                    using (MemoryStream stream = new MemoryStream())
                    {
                        wb.SaveAs(stream);
                        return File(stream.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Tüm Ekipman Bakımları.xlsx");
                    }
                }
            }
            catch (Exception ex)
            {
                ViewBag.message = ex.Message;
            }
            return RedirectToAction("AllProject");

        }
        public DataTable DataTableSave(IList<EquipmentMaintenanceUser> equipmentMaintenanceUsers)
        {
            DataTable table = new DataTable();
            table.Columns.Add("Proje İsmi");
            table.Columns.Add("Ekipman İsmi");
            table.Columns.Add("Bakım İsmi");
            table.Columns.Add("Bakım Periodu");
            table.Columns.Add("En Son Bakım Yapılma Tarihi");
            table.Columns.Add("Bir Sonraki Bakım Zamanı");
            table.Columns.Add("Bakım Red Nedeni");
            foreach (EquipmentMaintenanceUser item in equipmentMaintenanceUsers)
            {
                DataRow row = table.NewRow();
                row["Proje İsmi"] = item.ProjectEquipment.Project.Name;
                row["Ekipman İsmi"] = item.ProjectEquipment.Equipment.Name;
                row["Bakım İsmi"] = item.ProjectEquipment.Equipment.MaintenanceName;
                row["Bakım Periodu"] = item.ProjectEquipment.Equipment.Period + "Gün";
                if (!item.DoneOrNotDone)
                {
                    row["En Son Bakım Yapılma Tarihi"] = "Bakım Yapılmadı";
                }
                else
                {
                    row["En Son Bakım Yapılma Tarihi"] = item.MaintenanceDate.ToShortDateString();
                }               
                row["Bir Sonraki Bakım Zamanı"] = item.MaintenanceDate.AddDays(item.ProjectEquipment.Equipment.Period).ToShortDateString();
                row["Bakım Red Nedeni"] = item.Note;               
                table.Rows.Add(row);
            }
            return table;
        }

    }
}
