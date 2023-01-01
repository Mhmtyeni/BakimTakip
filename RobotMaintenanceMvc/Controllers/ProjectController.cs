using AutoMapper;
using BusinessLayer.Abstract;
using ClosedXML.Excel;
using DataAccsessLayer.Concrete;
using EntityLayer.Concrete;
using EntityLayer.Dtos.ProjectDtos;
using EntityLayer.Utilities.Results.ComplexTypes;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using RobotMaintenanceMvc.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace RobotMaintenanceMvc.Controllers
{
    [Authorize]
    public class ProjectController : BaseController
    {
        IProjectService _projectManager;
        private readonly IProjectEquipmentService _projectEquipmentManager;
        public ProjectController(UserManager<AppUser> userManager, IMapper mapper, IProjectService projectManager, IProjectEquipmentService projectEquipmentManager) : base(userManager, mapper)
        {
            _projectManager = projectManager;
            _projectEquipmentManager = projectEquipmentManager;
        }
        public async Task<IActionResult> AllProject()
        {
            var result = await _projectManager.GetAll();
            return View(result.Data);
        }
        [Authorize(Roles = "Admin,Engineer,SuperAdmin")]
        public IActionResult AddProject()
        {
            return View();
        }

        [HttpPost]
        public async Task<JsonResult> Add(ProjectAddDto p)
        {
            p.CreatedByName = LoggedInUser.UserName;
            p.ModifiedByName = LoggedInUser.UserName;
            p.IsActive = true;
            p.IsDeleted = false;
            p.CreatedDate = DateTime.Now;
            p.ModifiedDate = DateTime.Now;
            var result = await _projectManager.Add(p);
            if (result.ResultStatus == ResultStatus.Success)
                return Json(true);
            else
                return Json(false);
        }
        public async Task<JsonResult> GetAll()
        {
            var result = await _projectManager.GetAll();
            return Json(result.Data);
        }
        [Authorize(Roles = "Admin,Engineer,SuperAdmin")]
        public async Task<IActionResult> Edit(int id)
        {
            var result = await _projectManager.GetById(id);
            if (result.ResultStatus == ResultStatus.Success)
                return PartialView(result.Data);
            else
                return PartialView();
        }
        [Authorize(Roles = "Admin,Engineer,SuperAdmin")]
        public async Task<IActionResult> Select(int id)
        {
            Context db = new Context();
            ProjectEquipmentsAndProjectRobots multiModels = new ProjectEquipmentsAndProjectRobots();
            multiModels.ProjectEquipment = db.ProjectEquipment.ToList().Where(x => x.IsActive = true && x.IsDeleted == false).OrderByDescending(x => x.EquipmentId);
            multiModels.ProjectRobots = db.ProjectRobots.ToList().Where(x => x.IsActive = true && x.IsDeleted == false).OrderByDescending(x => x.RobotId);
            multiModels.Equipment = db.Equipment.ToList().Where(x => x.IsActive = true && x.IsDeleted == false);
            multiModels.Robots = db.Robots.ToList().Where(x => x.IsActive = true && x.IsDeleted == false);
            multiModels.Id = id;
            //var result = await _projectEquipmentManager.GetByProjectId(id);
            //if (result.ResultStatus == ResultStatus.Success)
            //    return PartialView(result.Data);
            //else
            return PartialView(multiModels);
        }
        [HttpPost]
        public async Task<JsonResult> Edit(ProjectUpdateDto p)
        {
            var project = await _projectManager.GetById(p.Id);
            p.ModifiedByName = LoggedInUser.UserName;
            p.ModifiedDate = DateTime.Now;
            var result = await _projectManager.Update(p);
            if (result.ResultStatus == ResultStatus.Success)
                return Json(true);
            else
                return Json(false);
        }
        [Authorize(Roles = "Admin,Engineer,SuperAdmin")]
        public async Task<IActionResult> EquipmentEdit(int id)
        {
            var result = await _projectManager.GetById(id);
            if (result.ResultStatus == ResultStatus.Success)
                return PartialView(result.Data);
            else
                return PartialView();
        }
        [Authorize(Roles = "Admin,Engineer,SuperAdmin")]
        public async Task<IActionResult> RobotEdit(int id)
        {
            var result = await _projectManager.GetById(id);
            if (result.ResultStatus == ResultStatus.Success)
                return PartialView(result.Data);
            else
                return PartialView();
        }
        public async Task<IActionResult> Search(string searchKey)
        {
            if (searchKey != "" && searchKey != " " && searchKey != null)
            {
                var result = await _projectManager.SearchByKeyword(searchKey);
                if (result.ResultStatus == ResultStatus.Success)
                {
                    return View(result.Data);
                }
            }
            return View();
        }
        public async Task<IActionResult> ExportExcel(int id)
        {
            var result = await _projectEquipmentManager.GetByProjectId(id);
            var projectName = "";
            foreach (var item in result.Data.ProjectEquipment)
            {
                projectName = item.Project.Name;
                break;
            }
            try
            {
                DataTable dataTable = new DataTable();
                dataTable = DataTableSave(result.Data.ProjectEquipment);
                dataTable.TableName = "Projeler&Ekipmanlar";
                using (XLWorkbook wb = new XLWorkbook())
                {
                    wb.ColumnWidth = 20;
                    wb.Worksheets.Add(dataTable);
                    using (MemoryStream stream = new MemoryStream())
                    {
                        wb.SaveAs(stream);
                        return File(stream.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", $"{projectName}.xlsx");
                    }
                }
            }
            catch (Exception ex)
            {
                ViewBag.message = ex.Message;
            }
            return RedirectToAction("AllProject");

        }
        public DataTable DataTableSave(IList<ProjectEquipment> equipments)
        {
            DataTable table = new DataTable();
            table.Columns.Add("Proje İsmi");
            table.Columns.Add("Ekipman İsmi");
            table.Columns.Add("Period");
            table.Columns.Add("Bakım İsmi");
            table.Columns.Add("Bakım Açıklaması");
            foreach (ProjectEquipment item in equipments)
            {
                DataRow row = table.NewRow();
                row["Proje İsmi"] = item.Project.Name; ;
                row["Ekipman İsmi"] = item.Equipment.Name;
                row["Period"] = item.Equipment.Period;
                row["Bakım İsmi"] = item.Equipment.MaintenanceName;
                row["Bakım Açıklaması"] = item.Equipment.MaintenanceComment;
                table.Rows.Add(row);
            }
            return table;
        }
    }
}
