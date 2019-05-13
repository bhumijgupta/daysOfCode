## Setup Hangfire
`dotnet add package Hangfire`<br>
Hangfire uses SQL/ redis server for storing information. We will use memory instead using `Hangfire.MemoryStorage`.<br>
`dotnet add package Hangfire.MemoryStorage`

## Configuring Hangfire
* Configuring Service<br>
In Startup.cs
```C#
public void ConfigureServices(IServiceCollection services)
    {

        services.AddHangfire(config =>
        {
            config.UseMemoryStorage();
        });
        services.AddMvc();
    }
    .
    .
    .
public void Configure(IApplicationBuilder app, IHostingEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }
        app.UseHangfireDashboard();
        app.UseHangfireServer();
        app.UseStaticFiles();
        app.UseMvcWithDefaultRoute();
        app.Run(async (context) =>
        {
            await context.Response.WriteAsync("Hello World!");
        });
    }
```

## Scheduling jobs
In HomeController.cs
```C#
public class HomeController
    {
        public string Index()
        {
            // Scheduling Background Job
            BackgroundJob.Schedule(
                () => Console.WriteLine("================Delayed by 5 second"),
                TimeSpan.FromSeconds(5)
            );
            BackgroundJob.Schedule(
                () => Console.WriteLine("================Delayed by 1 min"),
                TimeSpan.FromMinutes(1)
            );
            BackgroundJob.Schedule(
                () => Console.WriteLine("================Delayed by 2 min"),
                TimeSpan.FromMinutes(2)
            );
            return "Hello from MVC";
        }
    }
```
Syntax: `BackgroundJob.Schedule(<fn to be scheduled>, TimeSpan.FromMinutes(<time>))`
