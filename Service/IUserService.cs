using FleetStudioLeaveApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetStudioLeaveApp.Service
{
    interface IUserService
    {
        bool AddUser(User user);
        bool Login(int id);
        bool Logout(int id);
    }
}
