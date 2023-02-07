using Core.Application;
using Core.Data.Domain.TechnicalDbModel;
using Core.Data.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using System;
using WebAPI.AutoMapper;

namespace WebAPI
{
    public class Startup
    {
        private readonly IConfiguration _configuration;

        public Startup(IWebHostEnvironment environment)
        {
            var configBuilder = new ConfigurationBuilder()
                .SetBasePath(environment.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile($"appsettings.{environment.EnvironmentName}.json", optional: true)
                .AddEnvironmentVariables();

            _configuration = configBuilder.Build();
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicyAllowAll", builder =>
                {
                    builder
                        .SetIsOriginAllowed((host) => true)
                        .AllowAnyMethod()
                        .AllowAnyHeader()
                        .AllowCredentials();
                });
            });

            services.AddDbContext<TechnicalTestDBContext>(options =>
               options.UseSqlServer(_configuration.GetConnectionString("TechnicalTestDB"))
                   .EnableSensitiveDataLogging(true));

            services.AddControllers()
                    .SetCompatibilityVersion(CompatibilityVersion.Latest);

            services.AddAutoMapper(new Type[] { typeof(WebApiProfile) });

            services.AddSwaggerGen(options =>
            {
                var groupName = "v1";

                options.SwaggerDoc(groupName, new OpenApiInfo
                {
                    Title = $"Technical Test {groupName}",
                    Version = groupName,
                    Description = "Technical Test API",
                    License = new OpenApiLicense() { Name = "QBI Solutions LICX" },
                    Contact = new OpenApiContact
                    {
                        Name = "QBI Solutions",
                        Email = "support@qbisolutions.com",
                        Url = new Uri("https://www.qbisolutions.com/"),
                    }
                });
            });

            services.AddTransient(typeof(IProjectRepository), typeof(ProjectRepository));
            services.AddTransient(typeof(IProjectLogic), typeof(ProjectLogic));
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseSwagger(s =>
            {
                s.RouteTemplate = "/swagger/{documentName}/swagger.json";
            });
            app.UseSwaggerUI(c =>
            {
                c.RoutePrefix = "swagger";
                c.DocumentTitle = "Technical Test API";
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Technical Test API V1");
            });

            app.UseRouting();

            app.UseCors("CorsPolicyAllowAll");

            app.UseEndpoints(endpoints => endpoints.MapControllers());
        }
    }
}