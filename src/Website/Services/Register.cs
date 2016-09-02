using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Website.Services
{
    public static class Register
    {
        public static void DependencyInjection(IServiceCollection services)
        {
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<INotificationService, NotificationService>();
        }
    }
}
