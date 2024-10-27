using EmployeeData.EFDAL;
using EmployeeWebApp;
using EmployeeWebApp.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<CompanyDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("Company"));
});

builder.Services.AddScoped<EmployeeService>();

var app = builder.Build();

app.EnsureContextReady<CompanyDbContext>();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();

app.UseRouting();
app.MapControllerRoute(name: "default", pattern: "{controller=Employees}/{action=Employees}");

app.UseAuthorization();

app.MapRazorPages();

app.Run();
