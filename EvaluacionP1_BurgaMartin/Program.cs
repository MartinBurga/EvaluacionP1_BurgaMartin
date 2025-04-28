using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using EvaluacionP1_BurgaMartin.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<EvaluacionP1_SQL_PlanRecompensas>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("EvaluacionP1_SQL_PlanRecompensas") ?? throw new InvalidOperationException("Connection string 'EvaluacionP1_SQL_PlanRecompensas' not found.")));
builder.Services.AddDbContext<EvaluacionP1_SQLserver>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("EvaluacionP1_SQLserver") ?? throw new InvalidOperationException("Connection string 'EvaluacionP1_SQLserver' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
