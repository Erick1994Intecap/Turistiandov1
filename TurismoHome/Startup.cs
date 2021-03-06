using Autofac;
using Interface;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using Servicios.Servicios;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace TurismoHome
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
            SqlConnection conn = new SqlConnection
            {
                ConnectionString = @"Server=35.193.52.85;Database=Turistiando;user=sqlserver;password=R3st@I12022*;"
            };
            conn.Open();
            //builder.RegisterInstance<IDbConnection>(conn);
            //this.ApplicationContainer = builder.Build();

            services.AddSingleton<ILugaresVisitados, LugaresVisitadosService>();
            services.AddSingleton<ILugarTuristico, LugarTuristicoService>();
            services.AddSingleton<IRecomendacionCategoria, RecoCategoriaService>();
            services.AddSingleton<IRecomendaciones, RecomendacionesService>();
            services.AddSingleton<IRecoRegiones, RecoRegionesService>();

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "TurismoHome", Version = "v1" });
            });
        }

        public void ConfigureContainer(ContainerBuilder builder)
        {
            builder.RegisterModule(new DIModule());
            #region AutoFac Modulo
            builder.RegisterModule(new DIModule());
            #endregion
            #region AutoFac Direct REgistration
            //builder.RegisterType<AlumnoService>().As<IAlumno>();
            #endregion


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "TurismoHome v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
