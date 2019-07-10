using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TribunusAPI.Data;

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
