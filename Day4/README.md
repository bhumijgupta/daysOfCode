Create empty web template
```bash
dotnet new web
```
### Structure
`Program.cs` is the starting point when .NET CORE application is run<br>
Main configuration of application is in `.csproj` file<br>
It contains information about hosting model and packages included
Hosting model are of two types - InProcess and OutOfProcess. InProcess is faster than OutOfProcess<br>
`Properties/launchSettings.json` contains information about different profiles and environment name corresponding to the profile<br>
Env Name can be accessed using
```C#
IHostingEnvironment env
// and
env.EnvironmentName
```
Application Variables can be set in `appsettings.json`.<br>
appsettings.json
```C#
{
  "Logging": {
    "LogLevel": {
      "Default": "Warning"
    }
  },
  "AllowedHosts": "*",
  "myval": "Hello Darkness"
}
```
They can be accessed using<br>
Startup.cs
```C#
private IConfiguration _config;
public Startup(IConfiguration config)
{
    _config = config;
}
// _config["myval"]
```

## Middleware
`public void Configure` contains all the middleware and creates the HTTP Request pipeline. The order of middleware is important
```C#
public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILogger<Startup> logger)
{
    if (env.IsDevelopment())
    {
        app.UseDeveloperExceptionPage();
    }
    app.Use(async (context, next) =>
    {
        logger.LogInformation("MW1: Incoming Request");
        // next() redirects to next middleware
        await next();
        logger.LogInformation("MW1: Outgoing Response");
    });
    app.Use(async (context, next) =>
    {
        logger.LogInformation("MW2: Incoming Request");
        await next();
        logger.LogInformation("MW2: Outgoing Response");
    });

    // Run defines the end of pipeline and flow reverses from here
    app.Run(async (context) =>
    {
        await context.Response.WriteAsync(_config["myval"] + env.EnvironmentName);
        logger.LogInformation("MW3: Request handled and response produced");
    });
}
```

## Displaying Static Files
All the static files must be saved in a folder `wwwroot`. To display the files we use `UseDefaultFiles` and `UseStaticFiles` middlewares.<br>
By default, the default filenames are index.html/htm or default.html/html. It can be changed by creating a new DefaultFilesOptions and passing in the middleware.
```C#
public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILogger<Startup> logger)
{
    if (env.IsDevelopment())
    {
        DeveloperExceptionPageOptions developerExceptionPageOptions = new DeveloperExceptionPageOptions
        {
            SourceCodeLineCount = 10
        };
        app.UseDeveloperExceptionPage(developerExceptionPageOptions);
    }
    
    DefaultFilesOptions defaultfileoptions = new DefaultFilesOptions();
    // Clear default file names and add foo.html as default name
    defaultfileoptions.DefaultFileNames.Clear();
    defaultfileoptions.DefaultFileNames.Add("foo.html");

    // default file name should be index.html/htm, default.html/htm
    app.UseDefaultFiles(defaultfileoptions);
    // UseDefaultFiles should be before UseStaticFiles
    app.UseStaticFiles();

    app.Run(async (context) =>
    {
        // throw new Exception("Some error processing request");
        await context.Response.WriteAsync(_config["myval"] + env.EnvironmentName);
        logger.LogInformation("MW3: Request handled and response produced");
    });
}
```
FileServerOptions can also be used in place of UseDefaultFiles and UseStaticFiles
```C#
FileServerOptions fileserveroptions = new FileServerOptions();
// Clear default file names and add foo.html as default name
fileserveroptions.DefaultFilesOptions.DefaultFileNames.Clear();
fileserveroptions.DefaultFilesOptions.DefaultFileNames.Add("foo.html");
app.UseFileServer(fileserveroptions);
// Combination of UseDefaultFiles, UseStaticFiles and UseDirectoryBrowser
```



