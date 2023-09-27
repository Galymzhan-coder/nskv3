/*
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

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

app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action=Index}/{id?}");

app.MapFallbackToFile("C:/Users/TURGAMBAYEV.G/source/repos/NSKV3/NSKV3/ClientApp/public/index.html");

app.Run();
*/
/*
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.StaticFiles;
using Microsoft.AspNetCore.SpaServices.Extensions;

var builder = Host.CreateDefaultBuilder(args)
    .ConfigureWebHostDefaults(webBuilder =>
    {
        
        // Укажите путь к статическим файлам Vue.js
        var vueAppPath = Path.Combine(Directory.GetCurrentDirectory(), "ClientApp/dist");

        // Настройка статических файлов
        var staticFileOptions = new StaticFileOptions
        {
            FileProvider = new PhysicalFileProvider(vueAppPath),
            RequestPath = "",
            ContentTypeProvider = new FileExtensionContentTypeProvider()
        };

        webBuilder.ConfigureServices(services =>
        {
            services.AddSpaStaticFiles(options => options.RootPath = vueAppPath);
        });
        
        webBuilder.Configure(app =>
        {
            app.UseStaticFiles(staticFileOptions);
            app.UseSpaStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                // Ваши настройки маршрутов для ASP.NET Core приложения
                // endpoints.MapControllers();
            });

            if (webBuilder.GetSetting("Environment") == "Development")
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseSpa(spa =>
            {
                spa.Options.SourcePath = Path.Combine(Directory.GetCurrentDirectory(), "ClientApp");
                //"ClientApp";

                if (webBuilder.GetSetting("Environment") == "Development")
                {
                    spa.UseProxyToSpaDevelopmentServer("http://localhost:8080");
                }
            });
        });
    });

var app = builder.Build();



app.Run();
*/
/*
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action=Index}/{id?}");

app.MapFallbackToFile("C:/Users/TURGAMBAYEV.G/source/repos/NSKV3/NSKV3/ClientApp/dist/index.html");

app.Run();
*/
/* .......
using System.Diagnostics;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

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

app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action=Index}/{id?}");

app.UseSpa(spa =>
{
    spa.Options.SourcePath = "ClientApp";

    if (app.Environment.IsDevelopment())
    {
        spa.UseProxyToSpaDevelopmentServer("https://localhost:8080");
    }
});

app.Run();
*/

/*...........................*/
/*
using Microsoft.Extensions.FileProviders;
using System.Diagnostics;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddSpaStaticFiles(configuration =>
{
    configuration.RootPath = "ClientApp/dist";
});

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

app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action=Index}/{id?}");

// Serve static files from the ClientApp/dist directory
app.UseSpaStaticFiles();

// Start the Vue.js development server in Development environment
if (app.Environment.IsDevelopment())
{
    var spaScript = @"npm run serve --prefix ""ClientApp""";
    var process = new Process
    {
        StartInfo = new ProcessStartInfo
        {
            FileName = "cmd",
            RedirectStandardInput = true,
            UseShellExecute = false,
            CreateNoWindow = true
        }
    };

    process.Start();
    process.StandardInput.WriteLine(spaScript);
    process.StandardInput.Close();

    app.MapFallbackToFile("/index.html", new StaticFileOptions
    {
        FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), "ClientApp", "public")),
        RequestPath = ""
    });
}

app.Run();
*/
/*...........................*/

using System.Diagnostics;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddSpaStaticFiles(configuration =>
{
    configuration.RootPath = "ClientApp/dist";
});

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

app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action=Index}/{id?}");

// Serve static files from the ClientApp/dist directory
app.UseSpaStaticFiles();

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
            CreateNoWindow = true
        }
    };

    process.Start();
    process.StandardInput.WriteLine(spaScript);
    process.StandardInput.Close();

    //process.Start();

    // Open the browser with the SPA URL
    var spaUrl = "https://localhost:8080"; // Update with the correct port of your Vue.js dev server
    Process.Start(new ProcessStartInfo { FileName = spaUrl, UseShellExecute = true });

    app.UseSpa(spa =>
    {
        spa.Options.SourcePath = "ClientApp";
    });

}

app.Run();


/*
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.SpaServices;
using Microsoft.Extensions.DependencyInjection;
using VueCliMiddleware;

var builder = WebApplication.CreateBuilder(args);

// Set up Vue.js SPA
builder.Services.AddSpaStaticFiles(configuration =>
{
    configuration.RootPath = "ClientApp/dist";
});

// Configure the application
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSpa(spa =>
    {
        spa.Options.SourcePath = "ClientApp";
        spa.UseVueCli(npmScript: "serve");
    });
}

app.UseStaticFiles();
app.UseRouting();

app.MapFallbackToFile("index.html");

app.Run();
*/


/*
using System.Diagnostics;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

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

app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action=Index}/{id?}");

app.Use(async (context, next) =>
{
    if (context.Request.Path.StartsWithSegments("/app"))
    {
        // Run npm run serve for the Vue.js project
        var vueAppProcess = new Process
        {
            StartInfo = new ProcessStartInfo
            {
                FileName = "npm",
                Arguments = "run serve",
                WorkingDirectory = Path.Combine(context.Request.PathBase.Value, "ClientApp")
            }
        };
        vueAppProcess.Start();
        vueAppProcess.WaitForExit();
    }
    else
    {
        await next();
    }
});

app.Run();

/*
using System.Diagnostics;

var builder = WebApplication.CreateBuilder(args);

// Добавьте код, чтобы скомпилировать и запустить проект Vue
var vueProcess = new Process
{
    StartInfo =
    {
        FileName = "npm",
        Arguments = "run serve",
        WorkingDirectory = Path.Combine(builder.Environment.ContentRootPath, "ClientApp"),
        RedirectStandardOutput = true,
        RedirectStandardError = true,
        UseShellExecute = false,
        CreateNoWindow = true
    }
};
vueProcess.OutputDataReceived += (_, e) =>
{
    if (!string.IsNullOrEmpty(e.Data))
    {
        Console.WriteLine(e.Data);
    }
};
vueProcess.ErrorDataReceived += (_, e) =>
{
    if (!string.IsNullOrEmpty(e.Data))
    {
        Console.WriteLine(e.Data);
    }
};
vueProcess.Start();
vueProcess.BeginOutputReadLine();
vueProcess.BeginErrorReadLine();

var app = builder.Build();

// Оставьте остальной код без изменений

app.Run();

// Остановите процесс Vue при остановке приложения ASP.NET Core
app.ApplicationStopping.Register(() =>
{
    if (!vueProcess.HasExited)
    {
        vueProcess.Kill();
        vueProcess.WaitForExit();
    }
});
*/