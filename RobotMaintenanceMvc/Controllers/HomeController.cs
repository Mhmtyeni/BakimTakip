using AutoMapper;
using BusinessLayer.Abstract;
using DataAccsessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using RobotMaintenanceMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace RobotMaintenanceMvc.Controllers
{
    [Authorize]
    public class HomeController : BaseController
    {

        ICompleteMaintenanceEquipmentService _completeMaintenanceEquipmentManager;
        ICompleteMaintenanceRobotService _completeMaintenanceRobotManager;
        IEquipmentMaintenanceUserService _equipmentMaintenanceUserManager;
        IRobotToBeMaintainedUserService _robotToBeMaintainedUserManager;
        IEquipmentMaintenanceService _equipmentMaintenanceManager;
        IRobotToBeMaintainedService _robotToBeMaintainedManager;
        IProjectEquipmentService _projectEquipmentManager;
        IProjectRobotService _projectRobotManager;
        IEquipmentService _equipmentManager;
        IProjectService _projectManager;
        IRobotService _robotManager;
        public HomeController(UserManager<AppUser> userManager, IMapper mapper, IEquipmentMaintenanceService equipmentMaintenanceManager, IRobotToBeMaintainedService robotToBeMaintainedManager, IEquipmentService equipmentManager, IProjectService projectManager, IRobotService robotManager, ICompleteMaintenanceEquipmentService completeMaintenanceEquipmentManager, ICompleteMaintenanceRobotService completeMaintenanceRobotManager, IProjectEquipmentService projectEquipmentManager, IProjectRobotService projectRobotManager, IEquipmentMaintenanceUserService equipmentMaintenanceUserManager, IRobotToBeMaintainedUserService robotToBeMaintainedUserManager) : base(userManager, mapper)
        {
            _completeMaintenanceEquipmentManager = completeMaintenanceEquipmentManager;
            _completeMaintenanceRobotManager = completeMaintenanceRobotManager;
            _equipmentMaintenanceManager = equipmentMaintenanceManager;
            _robotToBeMaintainedManager = robotToBeMaintainedManager;
            _projectEquipmentManager = projectEquipmentManager;
            _projectRobotManager = projectRobotManager;
            _equipmentManager = equipmentManager;
            _projectManager = projectManager;
            _robotManager = robotManager;
            _equipmentMaintenanceUserManager = equipmentMaintenanceUserManager;
            _robotToBeMaintainedUserManager = robotToBeMaintainedUserManager;
        }
        public async Task<IActionResult> Index()
        {
            HomeIndexViewModel model = new HomeIndexViewModel();
            var allProject = await _projectManager.GetAll();
            var allRobot = await _projectRobotManager.GetAll();
            var allEquipment = await _projectEquipmentManager.GetAll();
            var allCompleteEquipment = await _completeMaintenanceEquipmentManager.GetAllMounth();
            var allCompleteRobot = await _completeMaintenanceRobotManager.GetAllMounth();
            var robotMaintenance = await _robotToBeMaintainedManager.GetAll();
            var equipmentMaintenance = await _equipmentMaintenanceManager.GetAll();
            var robotMaintenanceUser = await _robotToBeMaintainedUserManager.GetAll();
            var equipmentMaintenanceUser = await _equipmentMaintenanceUserManager.GetAll();

            int i = 0, j = 0, iu = 0, ju = 0;
            model.TotalCompleteMaintenance = allCompleteEquipment.Data.CompleteMaintenanceEquipment.Count + allCompleteRobot.Data.CompleteMaintenanceRobots.Count;
            model.TotalProject = allProject.Data.Projects.Count;
            model.TotalEquipment = allEquipment.Data.ProjectEquipment.Count;
            model.TotalRobot = allRobot.Data.ProjectRobots.Count;
            foreach (var item in equipmentMaintenance.Data.EquipmentMaintenances)
            {
                if (i < 10)
                {
                    model.EquipmentMaintenance[i] = item.ProjectEquipment.Project.Name + "?" +
                        item.ProjectEquipment.Equipment.Name + "?" +
                        item.ProjectEquipment.Equipment.MaintenanceName + "?" +
                        item.ProjectEquipment.Equipment.Period + "?" +
                        item.MaintenanceDate.AddDays(item.ProjectEquipment.Equipment.Period) + "?" +
                        item.DoneOrNotDone;
                    i++;
                }
            }
            foreach (var item in robotMaintenance.Data.RobotToBeMaintained)
            {
                if (j < 10)
                {
                    model.RobotMaintenance[j] = item.ProjectRobot.Project.Name + "?" +
                        item.RobotMaintenance.Robot.Name + "?" +
                        item.RobotMaintenance.Maintenance.Name + "?" +
                        item.RobotMaintenance.Maintenance.Period + "?" +
                        item.MaintenanceDate.AddDays(item.RobotMaintenance.Maintenance.Period) + "?" +
                        item.DoneOrNotDone;
                    j++;
                }
            }
            foreach (var item in equipmentMaintenanceUser.Data.EquipmentMaintenanceUsers)
            {
                if (iu < 10)
                {
                    model.EquipmentMaintenanceUser[iu] = item.ProjectEquipment.Project.Name + "?" +
                        item.ProjectEquipment.Equipment.Name + "?" +
                        item.ProjectEquipment.Equipment.MaintenanceName + "?" +
                        item.ProjectEquipment.Equipment.Period + "?" +
                        item.MaintenanceDate.AddDays(item.ProjectEquipment.Equipment.Period) + "?" +
                        item.DoneOrNotDone + "?" +
                        item.CheckOrDenied;
                    iu++;
                }
            }
            foreach (var item in robotMaintenanceUser.Data.RobotToBeMaintainedUsers)
            {
                if (ju < 10)
                {
                    model.RobotMaintenanceUser[ju] = item.ProjectRobot.Project.Name + "?" +
                        item.RobotMaintenance.Robot.Name + "?" +
                        item.RobotMaintenance.Maintenance.Name + "?" +
                        item.RobotMaintenance.Maintenance.Period + "?" +
                        item.MaintenanceDate.AddDays(item.RobotMaintenance.Maintenance.Period) + "?" +
                        item.DoneOrNotDone + "?" +
                        item.CheckOrDenied;
                    ju++;
                }
            }
            return View(model);
        }
        public static void MailSender(string body)
        {
            var fromAddress = new MailAddress("deneme@gmail.com");
            var toAddress = new MailAddress("mhmtyeni@gmail.com.tr");
            const string subject = "Deneme | Sitenizden Gelen İletişim Formu";
            using (var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, "gliese581c530")
            })
            {
                using (var message = new MailMessage(fromAddress, toAddress) { Subject = subject, Body = body })
                {
                    smtp.Send(message);
                }
            }
        }
        [HttpPost]
        public ActionResult SendMail()  //Mail sınıfından m diye bir değişken tanımlarız
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient smtp = new SmtpClient();
                smtp.Credentials = new NetworkCredential("deneme@gmail.com","******"); // Gönderici bilgilerini giriyoruz
                smtp.Port = 587; // Mail uzantınıza göre bu değişebilir
                smtp.Host = "smtp.gmail.com"; // Gmail veya hotmail ise onların host bilgisini almanız gerekiyor 
                smtp.EnableSsl = true;
                mail.IsBodyHtml = true;// HTML tagleri kullanarak mail gönderebilmek için aktif ediyoruz
                mail.From = new MailAddress("deneme@gmail.com","Deneme"); // Gönderen mail adresini yazıyoruz
                mail.To.Add("mhmtyeni@gmail.com.tr"); // Gönderilecek mail adresini ekliyoruz
                mail.Subject = "Ekipman Bakım Onayı"; // Mesaja konuyu ekliyoruz
                mail.Body = "Ekipman bakım onayı gelmiştir lütfen kontrol edip onaylayınız."; // Mesajın içeriğini ekliyoruz

                smtp.Send(mail); // Mesajı gönderiyoruz
                return View();
            }
            catch (Exception)
            {
                return View(false);
            }
        
        }
    }
}
