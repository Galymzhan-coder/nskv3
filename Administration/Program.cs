using Administration.Helpers;
using Administration.Interfaces;
using Administration.Services;
using Microsoft.OpenApi.Models;
using Models.Entities;
using Models.FFIFND;
using Services.FND;
using Swashbuckle.AspNetCore.SwaggerUI;
using System.Diagnostics;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//builder.Services.AddRazorPages();

/*
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Core Service", Version = "v1" });
    c.DescribeAllParametersInCamelCase();
}
);
*/

builder.Services.AddControllersWithViews();
//builder.Services.AddDbContext<DbNskContext>();
builder.Services.AddScoped<IUserInterface, UserServices>();
builder.Services.AddScoped<ODDANP>();
builder.Services.AddScoped<CategoriesService>();
builder.Services.Configure<AppSettings>(builder.Configuration.GetSection("AppSettings"));
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(builder =>
    {
        builder.AllowAnyOrigin()
               .AllowAnyMethod()
               .AllowAnyHeader();
    });
});
/*--------------------------
builder.Services.AddSpaStaticFiles(configuration =>
{
    configuration.RootPath = "ClientApp/dist";
});
*/
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Core Service", Version = "v1" });
    c.DescribeAllParametersInCamelCase();
}
);


//builder.Services.AddSwaggerGen();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
//app.UseStaticFiles();----------------------

app.UseRouting();
app.UseCors();
app.UseAuthorization();

app.UseSwagger();
app.UseSwaggerUI(c =>
{
    //c.SwaggerEndpoint("/swagger/v1/swagger.json", "API V1");
    c.RoutePrefix = ""; // Оставляем пустой префикс для Swagger UI
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Administration API V1");
    //c.IndexStream = () => typeof(Program).Assembly.GetManifestResourceStream("WebApplicationMVC.index.html"); // Замените "YourProjectName" на имя вашего проекта
    //c.HeadContent = @"<meta http-equiv=""refresh"" content=""0;URL=/swagger"" />"; // Автоматическое перенаправление на Swagger UI
    c.ConfigObject.DefaultModelExpandDepth = 2;
    c.ConfigObject.DefaultModelRendering = ModelRendering.Model;
    c.ConfigObject.DefaultModelsExpandDepth = 2;
    c.ConfigObject.DisplayRequestDuration = true;
});

//app.MapRazorPages();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action=Index}/{id?}");

// Serve static files from the ClientApp/dist directory
//app.UseSpaStaticFiles();----------------------

// Start the Vue.js development server in Development environment
if (app.Environment.IsDevelopment())
{
    var env = app.Services.GetRequiredService<IWebHostEnvironment>();

    /*
    var process = new Process
    {
        StartInfo = new ProcessStartInfo
        {
            FileName = "npm",
            Arguments = "run serve --prefix \"ClientApp\"",
            WorkingDirectory = Path.Combine(env.ContentRootPath, "ClientApp"),
            UseShellExecute = false,
            CreateNoWindow = true
        }
    };
    */

    var spaScript = @"npm run serve --prefix ""ClientApp""";
    var process = new Process
    {
        StartInfo = new ProcessStartInfo
        {
            FileName = "cmd",
            RedirectStandardInput = true,
            UseShellExecute = false,
            CreateNoWindow = false
        }
    };

    process.Start();
    process.StandardInput.WriteLine(spaScript);
    process.StandardInput.Close();

    //process.Start();

    // Open the browser with the SPA URL
    var spaUrl = "http://localhost:8084"; // Update with the correct port of your Vue.js dev server
    Process.Start(new ProcessStartInfo { FileName = spaUrl, UseShellExecute = true });
    /* ----------------------------------
    app.UseSpa(spa =>
    {
        spa.Options.SourcePath = "ClientApp";
    });
    */
}

app.Run();