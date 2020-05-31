using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json;
using WaterLevelController.DAL.EfDbContext;
using WaterLevelController.DAL.Interfaces;
using WaterLevelController.DAL.Repositories;
using WaterLevelController.Microservices;
using WaterLevelController.Services;

namespace WaterLevelController
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
            //CORS
            services.AddCors();

            //DBCONTEXT
            services.AddDbContext<WaterLevelDbContext>(options =>
            {
                options.UseSqlServer(@"Server=.\SQLEXPRESS;Database=WaterLevelDb;Trusted_Connection=True;");
            });

            //NEWTONSOFTJSON SERIALIZER
            services.AddMvc(option => option.EnableEndpointRouting = false)
                .SetCompatibilityVersion(CompatibilityVersion.Version_3_0)
                .AddNewtonsoftJson(opt => opt.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore);

            //REPOSITORY
            services.AddScoped<IScheduleRepository, ScheduleRepository>();
            services.AddScoped<ISensorRepository, SensorRepository>();
            services.AddScoped<ISwitchRepository, SwitchRepository>();
            services.AddScoped<IZoneRepository, ZoneRepository>();

            //SERVICE
            services.AddTransient<ScheduleManager>();
            services.AddTransient<SensorManager>();
            services.AddTransient<ZoneManager>();
            services.AddTransient<SwitchManager>();

            //MICROSERVICE
            services.AddHostedService<SwitchControllerService>();

            //SWAGGER
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo { Title = "WLC", Version = "v1" });
            });

            //CONTROLLERS
            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //CORS
            app.UseCors(
                options => options.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader()
            );

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "WLC v1");
            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
