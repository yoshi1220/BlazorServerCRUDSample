using BlazorServerCRUDSample;
using BlazorServerCRUDSample.Data;
using BlazorServerCRUDSample.Repositories;
using BlazorServerCRUDSample.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.EntityFrameworkCore;
using MudBlazor.Services;

var builder = WebApplication.CreateBuilder(args);

//appsettings.jsonからデータを取得する際に使用。どこからでも参照可能にする
AppSettings.Configuration = builder.Configuration;

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

//DB関連
builder.Services.AddDbContext<SampleDbContext>(options =>
{
    options.UseSqlServer(AppSettings.Configuration.GetConnectionString("DefaultConnection"));
});

//Repository関連
builder.Services.AddScoped<IUserRepository, UserRepository>(); //EntityFrameworkCoreを使う場合
//builder.Services.AddScoped<IUserRepository, UserRepositoryDapper>(); //Dapperを使う場合

//Service関連            
builder.Services.AddScoped<IUserService, UserService>();

//MudBlazor
builder.Services.AddMudServices();

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


