using VkusProject.Data.interfaces;
using VkusProject.Data.mocks;
using Microsoft.AspNetCore.Mvc;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;

namespace VkusProject
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IAllBludos, MockBludos>();
            //для объединения интерфейса и класса который реализует интерфейс
            //интерфейс IAllBludos реализуется в классe MockBludos

            services.AddTransient<IBludosCategory, MockCategory>();
            //интерфейс IBludosCategory реализуется в классe MockBludos

            services.AddMvc();
        }



        public void Configure(ApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseMvcWithDefaultRoute();
        }
    }
}
