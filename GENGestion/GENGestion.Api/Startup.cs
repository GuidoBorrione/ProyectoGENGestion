using GENGestion.Core.Interfaces;
using GENGestion.Infrastructure.Data;
using GENGestion.Infrastructure.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace GENGestion.Api
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
            services.AddControllers();
            
            //Cadena de conexion
            services.AddDbContext<GENGestionContext>(options => options.UseSqlServer(Configuration.GetConnectionString("GENGestion")));

            //dependencias Problemas
            services.AddTransient<IMedicosRepository, MedicosRepository>();
            services.AddTransient<IPacientesRepository, PacientesRepository>();
            
            
            services.AddCors(
                options =>
                options.AddPolicy(
                    "CorsPolicy",
                    builder =>
                    {
                        builder
                            .AllowAnyMethod()
                            .AllowAnyHeader()
                            .AllowAnyOrigin()
                            .SetIsOriginAllowed(
                                x =>
                                {
                                    return true;
                                }
                            );
                    }

            )
    );
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //app.UseHttpsRedirection();

            app.UseRouting();

            app.UseCors("CorsPolicy");

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            //var urlAceptadas = Configuration
            //           .GetSection("AllowedHosts").Value.Split(",");
            //app.UseCors(builder => builder.WithOrigins(urlAceptadas)
            //                      .AllowAnyHeader()
            //                      .AllowAnyMethod()
            //                      );
        }

    }
    }
}
