using Microsoft.AspNetCore.Mvc;
using VkusProject.Data.interfaces;
using VkusProject.Data.mocks;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddMvc();

// Вставил новые строки
builder.Services.AddTransient < IBludosCategory, MockCategory > ();
builder.Services.AddTransient<IAllBludos, MockBludos>();

/*builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(
builder.Configuration.GetConnectionString("DefaultConnection")
));
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();*/
////////

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();
//

app.UseDeveloperExceptionPage();
app.UseStatusCodePages();
app.UseStaticFiles();
//IApplicationBuilder applicationBuilder = app.UseMvcWithDefaultRoute();


//
app.Run();


// Из класса Startup
/*  public void Configure(ApplicationBuilder app, IHostingEnvironment env)
{
    
}*/