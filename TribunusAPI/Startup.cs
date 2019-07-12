using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TribunusAPI.Data;
using TribunusAPI.Services;

namespace TribunusAPI {
    public class Startup {
        public Startup(IConfiguration configuration) {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services) {
            services.AddDbContext<TribunusContext>(options => 
                options.UseSqlServer(Configuration.GetConnectionString("TribunusContext"), builder =>
                builder.MigrationsAssembly("TribunusAPI")));
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            services.AddScoped<SeedingService>();
            services.AddScoped<AtaReuniaoService>();
            services.AddScoped<AtaService>();
            services.AddScoped<CargoService>();
            services.AddScoped<DiretoriaService>();
            services.AddScoped<GraduacaoService>();
            services.AddScoped<MembroService>();
            services.AddScoped<MotoMembroService>();
            services.AddScoped<MotoService>();
            services.AddScoped<ReuniaoService>();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env, SeedingService seedingService) {
            if (env.IsDevelopment()) {
                app.UseDeveloperExceptionPage();
                seedingService.Seed();
            }
            else {
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
