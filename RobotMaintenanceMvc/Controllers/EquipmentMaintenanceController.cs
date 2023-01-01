using AutoMapper;
using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using EntityLayer.Dtos.CompleteMaintenanceEquipmentDtos;
using EntityLayer.Dtos.EquipmentMaintenanceDtos;
using EntityLayer.Dtos.EquipmentMaintenanceUserDtos;
using EntityLayer.Utilities.Results.ComplexTypes;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace RobotMaintenanceMvc.Controllers
{
    [Authorize]
    public class EquipmentMaintenanceController : BaseController
    {
        private readonly IEquipmentMaintenanceService _equipmentMaintenanceManager;
        private readonly IEquipmentMaintenanceUserService _equipmentMaintenanceUserManager;
        private readonly ICompleteMaintenanceEquipmentService _completeMaintenanceEquipmentManager;
        private readonly IAppUserService _appUserManager;
        private readonly IWebHostEnvironment _env;
        public EquipmentMaintenanceController(UserManager<AppUser> userManager, IMapper mapper, IEquipmentMaintenanceService equipmentMaintenanceManager, ICompleteMaintenanceEquipmentService completeMaintenanceEquipmentManager, IAppUserService appUserManager, IEquipmentMaintenanceUserService equipmentMaintenanceUserManager, IWebHostEnvironment env) : base(userManager, mapper)
        {
            _equipmentMaintenanceManager = equipmentMaintenanceManager;
            _completeMaintenanceEquipmentManager = completeMaintenanceEquipmentManager;
            _appUserManager = appUserManager;
            _equipmentMaintenanceUserManager = equipmentMaintenanceUserManager;
            _env = env;
        }
        [Authorize(Roles = "SuperAdmin")]
        public IActionResult AddEquipmentMaintenance()
        {
            return View();
        }
        [Authorize(Roles = "Admin,SuperAdmin")]
        public async Task<IActionResult> EquipmentMaintenance()
        {
            var result = await _equipmentMaintenanceManager.GetAll();
            return View(result.Data);
        }
        [HttpPost]
        public async Task<JsonResult> Add(EquipmentMaintenanceAddDto p)
        {
            var equipmentMaintenanceUserId = p.ProjectEquipmentId;
            var result2 = await _equipmentMaintenanceUserManager.GetById(p.ProjectEquipmentId);
            p.CreatedByName = equipmentMaintenanceUserId.ToString();
            p.ModifiedByName = LoggedInUser.UserName;
            p.IsActive = true;
            p.IsDeleted = false;
            p.CreatedDate = DateTime.Now;
            p.ModifiedDate = DateTime.Now;
            p.ProjectEquipmentId = result2.Data.EquipmentMaintenanceUser.ProjectEquipmentId;
            p.MaintenanceDate = DateTime.Now;
            p.DoneOrNotDone = result2.Data.EquipmentMaintenanceUser.DoneOrNotDone;
            var result = await _equipmentMaintenanceManager.Add(p);
            if (result.ResultStatus == ResultStatus.Success)
            {
                EquipmentMaintenanceUserUpdateDto editMaintenanceUser = new EquipmentMaintenanceUserUpdateDto
                {
                    Id = equipmentMaintenanceUserId,
                    CheckOrDenied = true,
                    ProjectEquipmentId = result2.Data.EquipmentMaintenanceUser.ProjectEquipmentId,
                    MaintenanceDate = result2.Data.EquipmentMaintenanceUser.MaintenanceDate,
                    ModifiedDate = DateTime.Now,
                    DoneOrNotDone = result2.Data.EquipmentMaintenanceUser.DoneOrNotDone,
                    CreatedDate = result2.Data.EquipmentMaintenanceUser.CreatedDate,
                    CreatedByName = equipmentMaintenanceUserId.ToString(),
                    ModifiedByName = LoggedInUser.UserName

                };
                await _equipmentMaintenanceUserManager.Update(editMaintenanceUser);
            }
            if (result.ResultStatus == ResultStatus.Success)
            {
                string wwwwRootPathSendMail = _env.ContentRootPath;
                string body = string.Empty;
                using (StreamReader reader = new StreamReader(wwwwRootPathSendMail + "/Views/Email/EmailTemplate.cshtml"))
                {
                    body = reader.ReadToEnd();
                }
                MailMessage mail = new MailMessage();
                SmtpClient smtp = new SmtpClient();
                smtp.Credentials = new NetworkCredential("deneme@deneme.com.tr", "******"); // Gönderici bilgilerini giriyoruz
                smtp.Port = 25; // Mail uzantınıza göre bu değişebilir
                smtp.Host = "10.20.50.56"; // Gmail veya hotmail ise onların host bilgisini almanız gerekiyor 
                smtp.EnableSsl = false;// False olacak
                smtp.UseDefaultCredentials = false;//Eğer bu kapalı olursa mail çok yavas gönderiliyor
                mail.IsBodyHtml = true;// HTML tagleri kullanarak mail gönderebilmek için aktif ediyoruz
                mail.From = new MailAddress("deneme@deneme.com.tr", "Bakım Portalı"); // Gönderen mail adresini yazıyoruz
                mail.To.Add("mhmtyeni@gmail.com.tr"); // Gönderilecek mail adresini ekliyoruz
                mail.Subject = "Bilgilendirme"; // Mesaja konuyu ekliyoruz
                mail.Body = "<div style=\"widht:600px;margin:-100px auto;\">" +
                            "<div style=\"widht:600px;background-color:white;\">" +
                            "<center><h1 style=\"color: red\">" +
                            "<img src=\"" + wwwwRootPathSendMail + "/wwwroot/assets/img.png\">BAKIM PORTALI" +
                             "<img src=\"" + wwwwRootPathSendMail + "/wwwroot/assets/img.png\"></h1></center></div>" + body
                                 + "<p style=\"color:black;\"><span style=\"font-weight:bold;font-size:18px\">Proje İsmi: </span>" + result2.Data.EquipmentMaintenanceUser.ProjectEquipment.Project.Name + "</p> "
                                 + "<p style=\"color:black;\"><span style=\"font-weight:bold;font-size:18px\">Ekipman İsmi: </span>" + result2.Data.EquipmentMaintenanceUser.ProjectEquipment.Equipment.Name + "</p> "
                                 + "<p style=\"color:black;\"><span style=\"font-weight:bold;font-size:18px\">Bakım Açıklaması: </span>" + p.Note + "</p> ";
                smtp.SendAsync(mail, "#35eys4n#"); // Mesajı gönderiyoruz(async olmaz ise gene yavaş gönderiyor)
                return Json(true);     
            }
            else
                return Json(false);
        }
        [HttpPost]
        public async Task<JsonResult> Edit(EquipmentMaintenanceUpdateDto p)
        {
            var result2 = await _equipmentMaintenanceManager.GetById(p.Id);
            var result3 = await _equipmentMaintenanceUserManager.GetById(Convert.ToInt32(result2.Data.EquipmentMaintenance.CreatedByName));
            if (result2.ResultStatus == ResultStatus.Success)
            {
                CompleteMaintenanceEquipmentAddDto completeMaintenance = new CompleteMaintenanceEquipmentAddDto
                {
                    ProjectEquipmentId = result2.Data.EquipmentMaintenance.ProjectEquipmentId,
                    CreatedByName = LoggedInUser.UserName,
                    ModifiedByName = LoggedInUser.UserName,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                    AppUserId = LoggedInUser.Id,
                    MaintenanceDate = DateTime.Now,
                    Note = result3.Data.EquipmentMaintenanceUser.Note

                };
                await _completeMaintenanceEquipmentManager.Add(completeMaintenance);
                EquipmentMaintenanceUserUpdateDto editMaintenanceUser = new EquipmentMaintenanceUserUpdateDto
                {
                    Id = Convert.ToInt32(result2.Data.EquipmentMaintenance.CreatedByName),
                    CheckOrDenied = false,
                    ProjectEquipmentId = result3.Data.EquipmentMaintenanceUser.ProjectEquipmentId,
                    MaintenanceDate = p.MaintenanceDate,
                    ModifiedDate = DateTime.Now,
                    DoneOrNotDone = p.DoneOrNotDone,
                    CreatedDate = result3.Data.EquipmentMaintenanceUser.CreatedDate,
                    CreatedByName = result3.Data.EquipmentMaintenanceUser.CreatedByName,
                    ModifiedByName = LoggedInUser.UserName
                };
                await _equipmentMaintenanceUserManager.Update(editMaintenanceUser);
            }
            var result = await _equipmentMaintenanceManager.DeleteById(p.Id);
            if (result.ResultStatus == ResultStatus.Success)
                return Json(true);
            else
                return Json(false);
        }
        [HttpPost]
        public async Task<JsonResult> Denied(EquipmentMaintenanceUpdateDto p)
        {
            var result = await _equipmentMaintenanceManager.DeleteById(p.Id);
            var result3 = await _equipmentMaintenanceManager.GetById(p.Id);
            var result2 = await _equipmentMaintenanceUserManager.GetById(Convert.ToInt32(result3.Data.EquipmentMaintenance.CreatedByName));
            if (result.ResultStatus == ResultStatus.Success)
            {
                EquipmentMaintenanceUserUpdateDto editMaintenanceUser = new EquipmentMaintenanceUserUpdateDto
                {
                    Id = result2.Data.EquipmentMaintenanceUser.Id,
                    ProjectEquipmentId = result2.Data.EquipmentMaintenanceUser.ProjectEquipmentId,
                    MaintenanceDate = result2.Data.EquipmentMaintenanceUser.MaintenanceDate,
                    CreatedByName = result2.Data.EquipmentMaintenanceUser.CreatedByName,
                    CreatedDate = result2.Data.EquipmentMaintenanceUser.CreatedDate,
                    DoneOrNotDone = result2.Data.EquipmentMaintenanceUser.DoneOrNotDone,
                    Note = p.Note,
                    CheckOrDenied = false,
                    ModifiedByName = LoggedInUser.UserName
                };
                await _equipmentMaintenanceUserManager.Update(editMaintenanceUser);
            }
            if (result.ResultStatus == ResultStatus.Success)
                return Json(true);
            else
                return Json(false);
        }

    }
}
