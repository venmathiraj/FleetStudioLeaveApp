using FleetStudioLeaveApp.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace FleetStudioLeaveApp.Models
{
    public class User
    {
        public string UserId;
        public string Name;
        private int Role;
        public int UserRole
        {
            get
            {
                return this.Role;
            }
            set
            {
                this.Role = (value == Convert.ToInt16(UserRoleEnum.UserRole.User)) ? Convert.ToInt16(UserRoleEnum.UserRole.User) : Convert.ToInt16(UserRoleEnum.UserRole.Admin);
            }
        }
        public int availableLeave { get; set; }
    }
}