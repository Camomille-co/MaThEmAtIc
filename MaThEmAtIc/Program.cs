using MaThEmAtIc;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<MaThDbContext>(options => options.UseSqlServer(@"Server=DESKTOP-RR0CBRF\LALAPEN;Database=FromMathTeach;TrustServerCertificate=True;Trusted_Connection=True;MultipleActiveResultSets=True", b => b.MigrationsAssembly("MaThEmAtIc")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
