using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ClinicaSaude.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<ClinicaSaudeContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ClinicaSaudeContext") ?? throw new InvalidOperationException("Connection string 'ClinicaSaudeContext' not found.")));

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
    name: "medicos",
    pattern: "medicos/{action=Index}/{id?}",
    defaults: new { controller = "Medico" });

app.MapControllerRoute(
    name: "pacientes",
    pattern: "pacientes/{action=Index}/{id?}",
    defaults: new { controller = "Paciente" });


app.Run();
