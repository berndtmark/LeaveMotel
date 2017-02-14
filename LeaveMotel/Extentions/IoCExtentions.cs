using LeaveMotel.BusinessLayer.Services;
using LeaveMotel.BusinessLayer.Services.Interfaces;
using LeaveMotel.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveMotel.Extentions
{
    public static class IoCExtentions
    {
        public static void ConfigureIoC(this IServiceCollection services)
        {
            services.AddTransient<IEmailSender, AuthMessageSender>();
            services.AddTransient<ISmsSender, AuthMessageSender>();

            services.AddTransient<ILeaveService, LeaveService>();
        }
    }
}
