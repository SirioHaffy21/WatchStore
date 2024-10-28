using EmailService;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using WatchManageStore.Configurations;
using WatchManageStore.Data;
using WatchManageStore.Data.SeedData;
using WatchManageStore.Infrastructure;
using WatchManageStore.Models;
using WatchManageStore.Repository;
using WatchManageStore.Repository.IRepository;
using WatchManageStore.Services;
using WatchManageStore.Services.InterfaceServices;

namespace WatchManageStore
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
            //email config
            var emailConfig = Configuration
                .GetSection("EmailConfiguration")
                .Get<EmailConfiguration>();
            services.AddSingleton(emailConfig);
            services.AddScoped<IEmailSender, EmailSender>();

            services.AddDbContext<ApplicationDBContext>(options =>
               options.UseSqlServer(
                   Configuration.GetConnectionString("DefaultConnection")));
            services.AddIdentity<Account, IdentityRole>(opt =>
            {
                opt.Password.RequiredLength = 7;
                opt.Password.RequireDigit = false;
                opt.Password.RequireUppercase = false;
                opt.User.RequireUniqueEmail = true;
            })
             .AddEntityFrameworkStores<ApplicationDBContext>()
             .AddDefaultTokenProviders();

            //set limited time for token reset password
            services.Configure<DataProtectionTokenProviderOptions>(opt =>
                opt.TokenLifespan = TimeSpan.FromHours(2));

            services.ConfigureApplicationCookie(options =>
            {
                // Cookie settings
                options.Cookie.HttpOnly = true;
                //options.Cookie.Expiration 

                options.ExpireTimeSpan = TimeSpan.FromMinutes(10);
                options.LoginPath = "/User/Login";
                options.LogoutPath = "/User/Logout";
                options.AccessDeniedPath = "/User/AccessDenied";
                options.SlidingExpiration = true;
                options.ReturnUrlParameter = "returnUrl";
            });

            services.AddAutoMapper(typeof(MapperConfig));
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IWatchesService, WatchesService>();
            services.AddScoped<IPostService, PostService>();
            services.AddScoped<ICommentRepository, CommentRepository>();
            services.AddScoped<IRateAccountRepository, RateAccountRepository>();
            services.AddRazorPages();

            services.AddControllersWithViews()
                .AddNewtonsoftJson(options =>
    options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
);

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app,
            IWebHostEnvironment env,
             UserManager<Account> userManager,
            RoleManager<IdentityRole> roleManager)
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

            app.UseAuthentication();

            app.UseAuthorization();

            AccountSeedData.Seed(userManager, roleManager);

            app.UseEndpoints(endpoints =>
            {
                // Attribute routing.

                endpoints.MapControllers();

                endpoints.MapControllerRoute(
                     name: "areas",
                     pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
                   );
                endpoints.MapControllerRoute(
              name: "Posts",
             pattern: "Posts/Details/{postId}",
             defaults: new { controller = "Posts", action = "Details" }
             );
                //endpoints.MapControllerRoute(
                //  name: "ShopSearch",
                // pattern: "Shop/SearchStore/",
                // defaults: new { controller = "Shop", action = "SearchStore" },
                //  constraints: new { search = "" }
                // );
                endpoints.MapControllerRoute(
              name: "Shop",
             pattern: "Shop/Details/{storeId}",
             defaults: new { controller = "Shop", action = "Details" }
             );

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
