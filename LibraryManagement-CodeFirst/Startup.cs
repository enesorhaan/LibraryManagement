using LibraryManagement_CodeFirst.Context;
using LibraryManagement_CodeFirst.Models;
using LibraryManagement_CodeFirst.RepositoryPattern.Base;
using LibraryManagement_CodeFirst.RepositoryPattern.Concrete;
using LibraryManagement_CodeFirst.RepositoryPattern.Interfaces;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagement_CodeFirst
{
    public class Startup
    {
        IConfiguration _configuration;
        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<MyDbContext>(options => options.UseSqlServer(_configuration["ConnectionStrings:MsSql"]));
            services.AddControllersWithViews();
            //services.AddScoped<IRepository<BookType>, Repository<BookType>>();
            services.AddScoped<IBookTypeRepository, BookTypeRepository>();
            services.AddScoped<IRepository<AppUser>, Repository<AppUser>>();
            //services.AddScoped<IRepository<Author>, Repository<Author>>();
            services.AddScoped<IAuthorRepository, AuthorRepository>();
            services.AddScoped<IBookRepository, BookRepository>();
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(options => {
                options.LoginPath = "/Auth/Login";
                options.Cookie.Name = "UserDetail";
                options.AccessDeniedPath = "/Auth/Login";
            });
            services.AddAuthorization(options => {
                options.AddPolicy("AdminPolicy", policy => policy.RequireClaim("role", "admin"));
                options.AddPolicy("UserPolicy", policy => policy.RequireClaim("role", "admin", "user"));
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, MyDbContext context)
        {
            context.Database.Migrate();
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "DefaultArea",
                    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
                );
                endpoints.MapControllerRoute(
                    name:"Default",
                    pattern:"{controller=Auth}/{action=Login}/{id?}"
                );
            });
        }
    }
}
