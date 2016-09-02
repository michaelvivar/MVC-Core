using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Website.Services
{
    public class UserService : IUserService
    {
        public void LogOut()
        {

        }
    }

    public interface IUserService
    {
        void LogOut();
    }
}
