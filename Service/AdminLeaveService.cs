using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FleetStudioLeaveApp.Models;
using FleetStudioLeaveApp.Repository;

namespace FleetStudioLeaveApp.Service
{
    public class AdminLeaveService : IAdminLeaveService
    {
        private AdminRepository _AdminRepository;
        public AdminLeaveService()
        {
            this._AdminRepository = new AdminRepository();
        }
        public void AppoveLeave()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Leave> GetAllUserLeave()
        {
            return _AdminRepository.GetAllUserLeave();
        }

        public void RejectLeave()
        {
            throw new NotImplementedException();
        }
    }
}