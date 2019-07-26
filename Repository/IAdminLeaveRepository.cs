using FleetStudioLeaveApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetStudioLeaveApp.Repository
{
    interface IAdminLeaveRepository
    {
        IEnumerable<Leave> GetAllUserLeave();
        IEnumerable<Leave> ApproveLeave();
        IEnumerable<Leave> RejectLeave();
    }
}
