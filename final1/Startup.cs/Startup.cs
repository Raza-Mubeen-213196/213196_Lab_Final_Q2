using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

public class Startup
{
    public IConfiguration Configuration { get; }
    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public void ConfigureServices(IServiceCollection services)
    {
        services.AddDbContext<AppDbContext> (options) => options.UseSqlite(Configuration.GetConnectionString("DefaultConnections"));

        services.AddControllersWithViews();
    }

    public void Configure(ApplicationBuilder app, IWebHostEnvironment env)
    {
        if(env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
            app.UseEndpoints();
        }
        else
        {
            app.UseExceptionHandler("/Home/Error");
            app.UseHsts();
        }

        app.UseHttpsRedirection();
        app.UseStaticFiles();
        app.UseRouting();
    }
}