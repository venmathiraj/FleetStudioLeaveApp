using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FleetStudioLeaveApp.Models;
using FleetStudioLeaveApp.Enum;

namespace FleetStudioLeaveApp.Repository
{
    public class UserLeaveRepository : IUserLeaveRepository
    {
        public bool CancelLeave(int id)
        {
            using (FSLEntities Fsla = new FSLEntities())
            {
                Fsla.tblLeaves.Remove(Fsla.tblLeaves.Where(x => x.LeaveId == id)?.FirstOrDefault());
                Fsla.SaveChangesAsync();
            }
            return true;
        }

        public bool RequestLeave(Leave leave)
        {
            int availableLeave = 0;
            using (FSLEntities Fsla = new FSLEntities())
            {
                availableLeave = Convert.ToInt32(Fsla.tblLeaves.Where(x => x.UserId == leave.UserId
                && x.LeaveDate < DateTime.Now
                && (
                x.LeaveStatus == Convert.ToInt32(LeaveStatusEnum.LeaveStatus.Approved)
                || x.LeaveStatus == Convert.ToInt32(LeaveStatusEnum.LeaveStatus.PendingForApproval)
                ))?.Count());
                if (availableLeave < 6)
                {
                    leave.AvailableLeave = availableLeave - 1;
                    Fsla.tblLeaves.Add(new tblLeave
                    {
                        AvailableLeave = leave.AvailableLeave,
                        LeaveDate = leave.LeaveDate,
                        LeaveStatus = Convert.ToInt32(LeaveStatusEnum.LeaveStatus.PendingForApproval)
                    });
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
    }
}