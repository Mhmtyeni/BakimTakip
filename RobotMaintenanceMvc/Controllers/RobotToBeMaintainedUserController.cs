using AutoMapper;
using BusinessLayer.Abstract;
using ClosedXML.Excel;
using EntityLayer.Concrete;
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
    public class RobotToBeMaintainedUserController : BaseController
    {

        private readonly IRobotToBeMaintainedService _robotToBeMaintainedManager;
        private readonly IRobotToBeMaintainedUserService _robotToBeMaintainedUserManager;
        public RobotToBeMaintainedUserController(UserManager<AppUser> userManager, IMapper mapper, IRobotToBeMaintainedService robotToBeMaintainedManager, IRobotToBeMaintainedUserService robotToBeMaintainedUserManager) : base(userManager, mapper)
        {
            _robotToBeMaintainedManager = robotToBeMaintainedManager;
            _robotToBeMaintainedUserManager = robotToBeMaintainedUserManager;
        }

        
        public async Task<IActionResult> RobotMaintenanceUser()
        {
            var result = await _robotToBeMaintainedUserManager.GetAll();
            return View(result.Data);
        }
        public async Task<IActionResult> ExportExcel()
        {
            var result = await _robotToBeMaintainedUserManager.GetAll();
            try
            {
                DataTable dataTable = new DataTable();
                dataTable = DataTableSave(result.Data.RobotToBeMaintainedUsers);
                dataTable.TableName = "Arızalar";
                using (XLWorkbook wb = new XLWorkbook())
                {
                    wb.ColumnWidth = 20;
                    wb.Worksheets.Add(dataTable);
                    using (MemoryStream stream = new MemoryStream())
                    {
                        wb.SaveAs(stream);
                        return File(stream.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Tüm Robot Bakımları.xlsx");
                    }
                }
            }
            catch (Exception ex)
            {
                ViewBag.message = ex.Message;
            }
            return RedirectToAction("AllProject");

        }
        public DataTable DataTableSave(IList<RobotToBeMaintainedUser> robotMaintenanceUsers)
        {
            DataTable table = new DataTable();
            table.Columns.Add("Proje İsmi");
            table.Columns.Add("Robot İsmi");
            table.Columns.Add("Bakım İsmi");
            table.Columns.Add("Bakım Periodu");
            table.Columns.Add("En Son Bakım Yapılma Tarihi");
            table.Columns.Add("Bir Sonraki Bakım Zamanı");
            table.Columns.Add("Bakım Red Nedeni");
            foreach (RobotToBeMaintainedUser item in robotMaintenanceUsers)
            {
                DataRow row = table.NewRow();
                row["Proje İsmi"] = item.ProjectRobot.Project.Name;
                row["Robot İsmi"] = item.RobotMaintenance.Robot.Name;
                row["Bakım İsmi"] = item.RobotMaintenance.Maintenance.Name;
                row["Bakım Periodu"] = item.RobotMaintenance.Maintenance.Period + "Gün";
                if (!item.DoneOrNotDone)
                {
                    row["En Son Bakım Yapılma Tarihi"] = "Bakım Yapılmadı";
                }
                else
                {
                    row["En Son Bakım Yapılma Tarihi"] = item.MaintenanceDate.ToShortDateString();
                }
                row["Bir Sonraki Bakım Zamanı"] = item.MaintenanceDate.AddDays(item.RobotMaintenance.Maintenance.Period).ToShortDateString();
                row["Bakım Red Nedeni"] = item.Note;
                table.Rows.Add(row);
            }
            return table;
        }
    }
}
