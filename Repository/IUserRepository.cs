using FleetStudioLeaveApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetStudioLeaveApp.Repository
{
    interface IUserRepository
    {
        bool AddUser(User user);
        bool Loggin(int id);

        bool LogOut(int id);
    }
}
