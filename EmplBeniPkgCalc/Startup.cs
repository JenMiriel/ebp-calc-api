using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using EmployeeBenefitPackageCalc.Data;
using Microsoft.EntityFrameworkCore;
using EmployeeBenefitPackageCalc.src.Models;
using EmployeeBenefitPackageCalc.Services;

namespace EmplBeniPkgCalc
{
    public class Startup
    {
        readonly string AllowLocalHostOrigins = "_allowLocalHostOrigins";
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            //string connectionString = Configuration.GetConnectionString("myDb");
            //services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=ebp_calc;Integrated Security=True"));

            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=ebp_calc;Integrated Security=True"));

            services.AddCors(options =>
            {
                options.AddPolicy(name: AllowLocalHostOrigins,
                                    builder =>
                                    {
                                        builder.WithOrigins("https://localhost",
                                                            "http://localhost",
                                                            "http://localhost:4200");
                                    });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, AppDbContext context)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            context.Database.EnsureCreated();


            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseCors(AllowLocalHostOrigins);
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            //context.Database.Migrate();
        }
    }
}
