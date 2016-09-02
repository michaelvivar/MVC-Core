using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Website.Services
{
    public class NotificationService : IDisposable, INotificationService
    {
        public void Dispose()
        {
            
        }
    }

    public interface INotificationService
    {
    }
}
