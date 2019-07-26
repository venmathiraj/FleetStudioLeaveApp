using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FleetStudioLeaveApp.Models;

namespace FleetStudioLeaveApp.Repository
{
    public class LeaveRepository : ILeaveRepsitory
    {
        public IEnumerable<Leave> GetLeave(int id)
        {
            List<Leave> LeaveList = new List<Leave>();
            using (FSLEntities Fsla = new FSLEntities())
            {
                LeaveList = Fsla.tblLeaves.Where(x => x.UserId == id)?.Select(
                    x => new Leave
                    {
                        LeaveId = x.LeaveId,
                        AvailableLeave = x.AvailableLeave,
                        LeaveStatus = x.LeaveStatus
                    }).ToList();
            }
            return LeaveList;
        }

        public int GetUserIdByLeaveId(int id)
        {
            int UserId = 0;
            using (FSLEntities Fsla = new FSLEntities())
            {
                UserId = Convert.ToInt32(Fsla.tblLeaves.Where(x => x.LeaveId == id)?.FirstOrDefault().UserId);
            }
            return UserId;
        }
    }
}