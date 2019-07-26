using FleetStudioLeaveApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetStudioLeaveApp.Repository
{
    interface IUserLeaveRepository
    {
        bool RequestLeave(Leave leave);
        bool CancelLeave(int id);
    }
}
