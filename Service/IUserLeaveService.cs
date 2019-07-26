using FleetStudioLeaveApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetStudioLeaveApp.Service
{
    interface IUserLeaveService
    {
        IEnumerable<Leave> ApplyLeave(Leave leave);
        IEnumerable<Leave> CancelLeave(int id);
    }
}
