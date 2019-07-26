using FleetStudioLeaveApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetStudioLeaveApp.Service
{
    interface IAdminLeaveService
    {
        IEnumerable<Leave> GetAllUserLeave();
        void AppoveLeave();
        void RejectLeave();
    }
}
