using FleetStudioLeaveApp.Enum;
using FleetStudioLeaveApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FleetStudioLeaveApp.Repository
{
    public class AdminRepository : IAdminLeaveRepository
    {
       
        public IEnumerable<Leave> ApproveLeave()
        {
            List<Leave> LeaveList = new List<Leave>();
            using (FSLEntities Fsla = new FSLEntities())
            {
                LeaveList = Fsla.tblLeaves?.Select(
                    x => new Leave
                    {
                        LeaveId = x.LeaveId,
                        AvailableLeave = x.AvailableLeave,
                        LeaveStatus = x.LeaveStatus
                    }).ToList();
            }
            return LeaveList;
        }

        public IEnumerable<Leave> RejectLeave()
        {
            return new List<Leave>();
        }

        public IEnumerable<Leave> GetAllUserLeave()
        {
            List<Leave> LeaveList = new List<Leave>();
            using (FSLEntities Fsla = new FSLEntities())
            {
                int status = Convert.ToInt32(LeaveStatusEnum.LeaveStatus.PendingForApproval);
                LeaveList = Fsla.tblLeaves.Where(x=>x.LeaveStatus ==status)?.Select(
                    x => new Leave
                    {
                        LeaveId = x.LeaveId,
                        AvailableLeave = x.AvailableLeave,
                        LeaveStatus = x.LeaveStatus,
                        UserId=(int)x.UserId,
                        LeaveDate=x.LeaveDate                        
                    }).ToList();
            }
            return LeaveList;
        }
    }
}