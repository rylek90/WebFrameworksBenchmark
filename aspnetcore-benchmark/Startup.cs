using aspnetcore.benchmark.Core;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace aspnetcore.benchmark
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app)
        {
            app.UseMvc();
        }

        public void ConfigureServices(IServiceCollection services)
        { 
            services.AddMvc();
            services.AddTransient<IGenerateNumbers, NumbersGenerator>();
            services.AddTransient<ICheckPrimes, PrimesChecker>();
        }
    }
}