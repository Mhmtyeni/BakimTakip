using AutoMapper;
using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using EntityLayer.Dtos.CompleteMaintenanceRobotDtos;
using EntityLayer.Dtos.RobotToBeMaintainedDtos;
using EntityLayer.Dtos.RobotToBeMaintainedUserDtos;
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
    public class RobotToBeMaintainedController : BaseController
    {
        private readonly IRobotToBeMaintainedService _robotToBeMaintainedManager;
        private readonly IRobotToBeMaintainedUserService _robotToBeMaintainedUserManager;
        private readonly ICompleteMaintenanceRobotService _completeMaintenanceRobotManager;
        private readonly IWebHostEnvironment _env;
        public RobotToBeMaintainedController(UserManager<AppUser> userManager, IMapper mapper, IRobotToBeMaintainedService robotToBeMaintainedManager, ICompleteMaintenanceRobotService completeMaintenanceRobotManager, IRobotToBeMaintainedUserService robotToBeMaintainedUserManager, IWebHostEnvironment env) : base(userManager, mapper)
        {
            _robotToBeMaintainedManager = robotToBeMaintainedManager;
            _completeMaintenanceRobotManager = completeMaintenanceRobotManager;
            _robotToBeMaintainedUserManager = robotToBeMaintainedUserManager;
            _env = env;
        }
        [Authorize(Roles = "Admin,Engineer,SuperAdmin")]
        public IActionResult AddRobotToBeMaintained()
        {
            return View();
        }
        [Authorize(Roles = "Admin,SuperAdmin")]
        public async Task<IActionResult> RobotMaintenance()
        {
            var result = await _robotToBeMaintainedManager.GetAll();
            return View(result.Data);
        }
        [HttpPost]
        public async Task<JsonResult> Add(RobotToBeMaintainedUserAddDto p)
        {
            bool bIsExist = await _robotToBeMaintainedUserManager.CheckProjectRobotExist(p.ProjectRobotId, p.RobotMaintenanceId);
            if (!bIsExist)
            {
                p.CreatedByName = LoggedInUser.UserName;
                p.ModifiedByName = LoggedInUser.UserName;
                p.IsActive = true;
                p.IsDeleted = false;
                p.CreatedDate = DateTime.Now;
                p.ModifiedDate = DateTime.Now;
                var result = await _robotToBeMaintainedUserManager.Add(p);
                if (result.ResultStatus == ResultStatus.Success)
                    return Json(true);
            }
            else
            {
                return Json("exist");
            }
            return Json(false);
        }
        [HttpPost]
        public async Task<JsonResult> AddUser(RobotToBeMaintainedAddDto p)
        {
            var robotMaintenanceUserId = p.ProjectRobotId;
            var result2 = await _robotToBeMaintainedUserManager.GetById(p.ProjectRobotId);
            p.CreatedByName = robotMaintenanceUserId.ToString();
            p.ModifiedByName = LoggedInUser.UserName;
            p.IsActive = true;
            p.IsDeleted = false;
            p.CreatedDate = DateTime.Now;
            p.ModifiedDate = DateTime.Now;
            p.ProjectRobotId = Convert.ToInt32(result2.Data.RobotToBeMaintainedUser.ProjectRobotId);
            p.RobotMaintenanceId = result2.Data.RobotToBeMaintainedUser.RobotMaintenanceId;
            p.MaintenanceDate = result2.Data.RobotToBeMaintainedUser.MaintenanceDate;
            p.DoneOrNotDone = result2.Data.RobotToBeMaintainedUser.DoneOrNotDone;
            var result = await _robotToBeMaintainedManager.Add(p);
            if (result.ResultStatus == ResultStatus.Success)
            {
                RobotToBeMaintainedUserUpdateDto editMaintenanceUser = new RobotToBeMaintainedUserUpdateDto
                {
                    Id = robotMaintenanceUserId,
                    CheckOrDenied = true,
                    ProjectRobotId = Convert.ToInt32(result2.Data.RobotToBeMaintainedUser.ProjectRobotId),
                    MaintenanceDate = result2.Data.RobotToBeMaintainedUser.MaintenanceDate,
                    RobotMaintenanceId = result2.Data.RobotToBeMaintainedUser.RobotMaintenanceId,
                    ModifiedDate = DateTime.Now,
                    DoneOrNotDone = result2.Data.RobotToBeMaintainedUser.DoneOrNotDone,
                    CreatedDate = result2.Data.RobotToBeMaintainedUser.CreatedDate,
                    CreatedByName = robotMaintenanceUserId.ToString(),
                    ModifiedByName = LoggedInUser.UserName

                };
                await _robotToBeMaintainedUserManager.Update(editMaintenanceUser);
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
                smtp.Credentials = new NetworkCredential("deneme@deneme.com", "******"); // Gönderici bilgilerini giriyoruz
                smtp.Port = 25; // Mail uzantınıza göre bu değişebilir
                smtp.Host = "10.20.50.56"; // Gmail veya hotmail ise onların host bilgisini almanız gerekiyor 
                smtp.EnableSsl = false;// False olacak
                smtp.UseDefaultCredentials = false;//Eğer bu kapalı olursa mail çok yavas gönderiliyor
                mail.IsBodyHtml = true;// HTML tagleri kullanarak mail gönderebilmek için aktif ediyoruz
                mail.From = new MailAddress("deneme@deneme.com", "Bakım Portalı"); // Gönderen mail adresini yazıyoruz
                mail.To.Add("mhmtyeni@gmail.com.tr"); // Gönderilecek mail adresini ekliyoruz
                mail.Subject = "Bilgilendirme"; // Mesaja konuyu ekliyoruz
                mail.Body = "<div style=\"widht:600px;margin:-100px auto;\">" +
                            "<div style=\"widht:600px;background-color:white;\">" +
                            "<center><h1 style=\"color: red\">" +
                            "<img src=\"" + wwwwRootPathSendMail + "/wwwroot/assets/img.png\">BAKIM PORTALI" +
                             "<img src=\"" + wwwwRootPathSendMail + "/wwwroot/assets/img.png\"></h1></center></div>" + body
                                 + "<p style=\"color:black;\"><span style=\"font-weight:bold;font-size:18px\">Proje İsmi: </span>" + result2.Data.RobotToBeMaintainedUser.ProjectRobot.Project.Name + "</p> "
                                 + "<p style=\"color:black;\"><span style=\"font-weight:bold;font-size:18px\">Robot İsmi: </span>" + result2.Data.RobotToBeMaintainedUser.RobotMaintenance.Robot.Name + "</p> "
                                 + "<p style=\"color:black;\"><span style=\"font-weight:bold;font-size:18px\">Bakım Açıklaması: </span>" + p.Note + "</p> ";
                smtp.SendAsync(mail, "#35eys4n#"); // Mesajı gönderiyoruz(async olmaz ise gene yavaş gönderiyor)
                return Json(true);
            }

            else
                return Json(false);
        }
        [HttpPost]
        public async Task<JsonResult> Edit(RobotToBeMaintainedUpdateDto p)
        {
            var result2 = await _robotToBeMaintainedManager.GetById(p.Id);
            var result3 = await _robotToBeMaintainedUserManager.GetById(Convert.ToInt32(result2.Data.RobotToBeMaintained.CreatedByName));
            if (result2.ResultStatus == ResultStatus.Success)
            {
                CompleteMaintenanceRobotAddDto completeMaintenance = new CompleteMaintenanceRobotAddDto
                {
                    ProjectRobotId = Convert.ToInt32(result2.Data.RobotToBeMaintained.ProjectRobotId),
                    RobotMaintenanceId = result2.Data.RobotToBeMaintained.RobotMaintenanceId,
                    CreatedByName = LoggedInUser.UserName,
                    ModifiedByName = LoggedInUser.UserName,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                    AppUserId = LoggedInUser.Id,
                    MaintenanceDate = DateTime.Now,
                    Note = result3.Data.RobotToBeMaintainedUser.Note
                };
                await _completeMaintenanceRobotManager.Add(completeMaintenance);
                RobotToBeMaintainedUserUpdateDto editMaintenanceUser = new RobotToBeMaintainedUserUpdateDto
                {
                    Id = Convert.ToInt32(result2.Data.RobotToBeMaintained.CreatedByName),
                    CheckOrDenied = false,
                    ProjectRobotId = Convert.ToInt32(result3.Data.RobotToBeMaintainedUser.ProjectRobotId),
                    RobotMaintenanceId = result3.Data.RobotToBeMaintainedUser.RobotMaintenanceId,
                    MaintenanceDate = p.MaintenanceDate,
                    ModifiedDate = DateTime.Now,
                    DoneOrNotDone = p.DoneOrNotDone,
                    CreatedDate = result3.Data.RobotToBeMaintainedUser.CreatedDate,
                    CreatedByName = result3.Data.RobotToBeMaintainedUser.CreatedByName,
                    ModifiedByName = LoggedInUser.UserName
                };
                await _robotToBeMaintainedUserManager.Update(editMaintenanceUser);
            }
            var result = await _robotToBeMaintainedManager.DeleteById(p.Id);
            if (result.ResultStatus == ResultStatus.Success)
                return Json(true);
            else
                return Json(false);
        }
        [HttpPost]
        public async Task<JsonResult> Denied(RobotToBeMaintainedUpdateDto p)
        {
            var result = await _robotToBeMaintainedManager.DeleteById(p.Id);
            var result3 = await _robotToBeMaintainedManager.GetById(p.Id);
            var result2 = await _robotToBeMaintainedUserManager.GetById(Convert.ToInt32(result3.Data.RobotToBeMaintained.CreatedByName));
            if (result.ResultStatus == ResultStatus.Success)
            {
                RobotToBeMaintainedUserUpdateDto editMaintenanceUser = new RobotToBeMaintainedUserUpdateDto
                {
                    Id = result2.Data.RobotToBeMaintainedUser.Id,
                    ProjectRobotId = Convert.ToInt32(result2.Data.RobotToBeMaintainedUser.ProjectRobotId),
                    MaintenanceDate = result2.Data.RobotToBeMaintainedUser.MaintenanceDate,
                    RobotMaintenanceId = result2.Data.RobotToBeMaintainedUser.RobotMaintenanceId,
                    CreatedByName = result2.Data.RobotToBeMaintainedUser.CreatedByName,
                    CreatedDate = result2.Data.RobotToBeMaintainedUser.CreatedDate,
                    DoneOrNotDone = result2.Data.RobotToBeMaintainedUser.DoneOrNotDone,
                    CheckOrDenied = false,
                    Note = p.Note,
                    ModifiedByName = LoggedInUser.UserName
                };
                await _robotToBeMaintainedUserManager.Update(editMaintenanceUser);
            }
            if (result.ResultStatus == ResultStatus.Success)
                return Json(true);
            else
                return Json(false);
        }
    }
}
