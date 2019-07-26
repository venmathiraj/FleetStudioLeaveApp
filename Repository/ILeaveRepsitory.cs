using FleetStudioLeaveApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetStudioLeaveApp.Repository
{
    public interface ILeaveRepsitory
    {
        IEnumerable<Leave> GetLeave(int id);
        int GetUserIdByLeaveId(int id);
    }
}
