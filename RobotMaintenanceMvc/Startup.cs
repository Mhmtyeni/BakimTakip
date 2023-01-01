using BusinessLayer.AutoMapper.Profiles;
using BusinessLayer.Extensions;
using DataAccsessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using RobotMaintenanceMvc.CustomValidators;
using StackExchange.Profiling;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace RobotMaintenanceMvc
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public IConfiguration Configuration { get; }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMiniProfiler(options =>
            {
                // MiniProfiler'ýn sað altta görünmesi için
                options.PopupRenderPosition = RenderPosition.BottomLeft;
                options.PopupShowTimeWithChildren = true;
            });

            services.LoadMyServices();
            services.AddIdentity<AppUser, AppRole>(options =>
            {
                options.Password.RequiredLength = 3;
                options.Password.RequireLowercase = false;
                options.Password.RequireUppercase = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireDigit = false;
                options.User.RequireUniqueEmail = true;
            }).AddErrorDescriber<CustomIdentityValidator>().AddPasswordValidator<CustomPasswordValidator>().AddEntityFrameworkStores<Context>();
            services.ConfigureApplicationCookie(options =>
            {
                options.Cookie.HttpOnly = true;
                options.Cookie.Name = "Test";
                options.ExpireTimeSpan = TimeSpan.FromDays(7);
                options.LoginPath = new PathString("/Account/LoginRegister");
                options.LogoutPath = new PathString("/Account/Logout");
                options.Cookie = new CookieBuilder
                {
                    Name = "RobotMaintenanceMvc",
                    HttpOnly = true,
                    SameSite = SameSiteMode.Strict,
                    SecurePolicy = CookieSecurePolicy.SameAsRequest // Always
                };
                options.SlidingExpiration = true;
                options.ExpireTimeSpan = System.TimeSpan.FromDays(7);
                options.AccessDeniedPath = new PathString("/Error/PageNotFound");
            });

            services.AddControllersWithViews().AddRazorRuntimeCompilation();
            services.AddAutoMapper(typeof(CompleteMaintenanceEquipmentProfile),
                typeof(CompleteMaintenanceRobotProfile),
                typeof(AppUserProfile),
                typeof(EquipmentCategoryProfile),
                typeof(EquipmentMaintenanceProfile),
                typeof(EquipmentMaintenanceUserProfile),
                typeof(EquipmentProfile),
                typeof(FactoryDepartmentProfile),
                typeof(FactoryProfile),
                typeof(ProjectEquipmentProfile),
                typeof(ProjectProfile),
                typeof(ProjectResponsibleProfile),
                typeof(ProjectRobotProfile),
                typeof(RobotCategoryProfile),
                typeof(RobotMaintenanceProfile),
                typeof(MaintenanceProfile),
                typeof(RobotProfile),
                typeof(RobotToBeMaintainedProfile),
                typeof(FaultReportProfile),
                typeof(ProjectReportProfile),
                typeof(RobotToBeMaintainedUserProfile)
                );
            services.AddHttpContextAccessor();
            services.AddMvc().AddJsonOptions(
           options =>
           {
               options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.Preserve;
           });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseStatusCodePagesWithRedirects("/Error/PageNotFound");
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();
            app.UseRouting();
            app.UseMiniProfiler();
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "areas",
                    pattern: "{area:exists}/{controller=Request}/{action=Index}/{id?}"
                    );
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
