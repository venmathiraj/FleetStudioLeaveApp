using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FleetStudioLeaveApp.Enum
{
    public class LeaveStatusEnum
    {
        public enum LeaveStatus
        {
            PendingForApproval,
            Approved,
            Rejected
        }
    }
}