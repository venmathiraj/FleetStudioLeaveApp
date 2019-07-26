using FleetStudioLeaveApp.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FleetStudioLeaveApp.Models
{
    public class Leave
    {
        public int LeaveId;
        public int AvailableLeave;
        private int Status;
        public static int TotalLeave = 6;
        public DateTime LeaveDate;
        public int UserId;
        public int LeaveStatus
        {
            get
            {
                return this.Status;
            }
            set
            {
               if(value==Convert.ToInt16(LeaveStatusEnum.LeaveStatus.PendingForApproval))
                {
                    this.Status = Convert.ToInt16(LeaveStatusEnum.LeaveStatus.PendingForApproval);
                }
               else if(value == Convert.ToInt16(LeaveStatusEnum.LeaveStatus.Approved))
                {
                    this.Status = Convert.ToInt16(LeaveStatusEnum.LeaveStatus.Approved);
                }
               else
                {
                    this.Status = Convert.ToInt16(LeaveStatusEnum.LeaveStatus.Rejected);
                }
            }
        }
    }
}