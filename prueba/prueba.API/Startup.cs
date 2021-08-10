using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using prueba.Domain.Context;
using prueba.Domain.Core;
using prueba.Domain.Interfaces;
using prueba.UseCase.Core;
using prueba.UseCase.Interfaces;

namespace prueba.API
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
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddDbContext<db_pruebaContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("db_pruebaConnection"), sqlServerOptionsAction: op =>
                {
                    op.EnableRetryOnFailure(
                        maxRetryCount: 3,
                        maxRetryDelay: TimeSpan.FromSeconds(15),
                        errorNumbersToAdd: null
                        );
                }));
            services.AddScoped<IUsuarioDomain, UsuarioDomain>();
            services.AddScoped<IClienteDomain, ClienteDomain>();
            services.AddScoped<IDetalleMovimientoLibroDomain, DetalleMovimientoLibroDomain>();
            services.AddScoped<ILibroDomain, LibroDomain>();
            services.AddScoped<IMovimientoLibroDomain, MovimientoLibroDomain>();
            services.AddScoped<IReservaLibroDomain, ReservaLibroDomain>();

            services.AddScoped<IUsuarioUseCase, UsuarioUseCase>();
            services.AddScoped<IClienteUseCase, ClienteUseCase>();
            services.AddScoped<IDetalleMovimientoLibroUseCase, DetalleMovimientoLibroUseCase>();
            services.AddScoped<ILibroUseCase, LibroUseCase>();
            services.AddScoped<IMovimientoLibroUseCase, MovimientoLibroUseCase>();
            services.AddScoped<IReservaLibroUseCase, ReservaLibroUseCase>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}
