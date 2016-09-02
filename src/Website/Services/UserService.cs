using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Website.Services
{
    public class UserService : IUserService, IDisposable
    {
        public UserService(INotificationService notificationService)
        {
            string msg = notificationService.Msg;
        }
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void LogOut()
        {

        }
    }

    public interface IUserService
    {
        void LogOut();
    }
}
