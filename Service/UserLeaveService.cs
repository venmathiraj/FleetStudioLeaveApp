using FleetStudioLeaveApp.Models;
using FleetStudioLeaveApp.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FleetStudioLeaveApp.Service
{
    public class UserLeaveService : IUserLeaveService
    {
        private LeaveRepository _LeaveRepository;
        private UserLeaveRepository _UserLeaveRepository;

        public UserLeaveService()
        {
            this._LeaveRepository = new LeaveRepository();
            this._UserLeaveRepository = new UserLeaveRepository();
        }
        public IEnumerable<Leave> Get(int id)
        {
            return _LeaveRepository.GetLeave(id);
        }
        public IEnumerable<Leave> ApplyLeave(Leave leave)
        {
            if(_UserLeaveRepository.RequestLeave(leave))
            {
                return _LeaveRepository.GetLeave(leave.UserId);
            }
            return null;
        }

        public IEnumerable<Leave> CancelLeave(int id)
        {
            if (_UserLeaveRepository.CancelLeave(id))
            {
                return _LeaveRepository.GetLeave(_LeaveRepository.GetUserIdByLeaveId(id));
            }
            return null;
        }
    }
}