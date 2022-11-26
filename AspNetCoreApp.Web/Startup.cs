using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using CoreLayer.Entities;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using DataAccessLayer.Repositories;
using DataAccessLayer.SeedData;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreApp.Web
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<Context>(options => options.UseSqlServer("Server = tcp:easyhr21.database.windows.net, 1433; Initial Catalog = IKPROJELOCAL1; Persist Security Info = False; User ID = easyhr21; Password =Kanrascal_1; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30;"));


            services.AddIdentity<Personnel,IdentityRole>(x =>
                {
                    x.Password.RequireUppercase = false;
                    x.Password.RequireNonAlphanumeric = false;
                })
                .AddEntityFrameworkStores<Context>();

            services.ConfigureApplicationCookie(option =>
            {
                option.Cookie.Name = "Identity";  //Web sayfasýnda incele ksmýnda applicationda artýk session adý ýdentity olarak görünecek.
                option.ExpireTimeSpan = TimeSpan.FromMinutes(10); //default olarak 20 dk iþlem yapmazsa session sonlanacak ama biz 1 dk yaptýk.
                option.SlidingExpiration = true; //1 dk dolmadan iþlem yaptýðý sürece sessionu uzatýr bu metod.

                option.AccessDeniedPath = "/Home/AccessDenied";
            });
            services.AddAuthentication();

            services.AddAuthentication();

            services.AddControllersWithViews().AddRazorRuntimeCompilation();
            services.AddTransient(typeof(IGENERICDAL<>), typeof(GenericRepository<>));
            services.AddTransient(typeof(IGenericService<>), typeof(GenericManager<>));

            services.AddTransient<IExpenseDal, EFExpenseRepository>();
            services.AddTransient<IExpenseService, ExpenseManager>();

            services.AddTransient<IAdvanceDal, EFAdvanceRepository>();
            services.AddTransient<IAdvanceService, AdvanceManager>();

            services.AddTransient<IPermitDal, EFPermitRepository>();
            services.AddTransient<IPermitService, PermitManager>();

            services.AddTransient<IPersonnelDal, EFPersonnelRepository>();
            services.AddTransient<IPersonnelService, PersonnelManager>();

            services.AddTransient<ICompanyDal, EFCompanyRepository>();
            services.AddTransient<ICompanyService, CompanyManager>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            //SeedData.Seed(app);
            
            app.UseAuthentication();
            app.UseAuthorization();


            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Login}/{action=Index}/{id?}");

                endpoints.MapControllers();
            });

            
        }
    }
}
