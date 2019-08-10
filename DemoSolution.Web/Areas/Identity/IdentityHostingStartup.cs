using System;
using DemoSolution.Web.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(DemoSolution.Web.Areas.Identity.IdentityHostingStartup))]
namespace DemoSolution.Web.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<DemoSolutionWebContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("DemoSolutionWebContextConnection")));

                services.AddDefaultIdentity<IdentityUser>()
                    .AddEntityFrameworkStores<DemoSolutionWebContext>();
            });
        }
    }
}