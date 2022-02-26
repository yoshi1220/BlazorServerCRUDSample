using BlazorServerCRUDSample;
using BlazorServerCRUDSample.Data;
using BlazorServerCRUDSample.Repositories;
using BlazorServerCRUDSample.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

//appsettings.json����f�[�^���擾����ۂɎg�p�B�ǂ�����ł��Q�Ɖ\�ɂ���
AppSettings.Configuration = builder.Configuration;

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

//DB�֘A
builder.Services.AddDbContext<SampleDbContext>(options =>
{
    options.UseSqlServer(AppSettings.Configuration.GetConnectionString("DefaultConnection"));
});

//Repository�֘A
//services.AddScoped<IUserRepository, UserRepository>(); //EntityFrameworkCore���g���ꍇ
builder.Services.AddScoped<IUserRepository, UserRepositoryDapper>(); //Dapper���g���ꍇ

//Service�֘A            
builder.Services.AddScoped<IUserService, UserService>();

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

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();


