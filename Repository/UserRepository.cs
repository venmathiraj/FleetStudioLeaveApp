using FleetStudioLeaveApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FleetStudioLeaveApp.Repository
{
    public class UserRepository : IUserRepository
    {
        public bool AddUser(User user)
        {
            //insert new user into db
            throw new NotImplementedException();
        }

        public bool Loggin(int id)
        {
            using (FSLEntities Fsla = new FSLEntities())
            {
                var user = Fsla.tblUsers?.Where(x => x.UserId == id).FirstOrDefault();
                user.LoginStatus = true;
                Fsla.SaveChangesAsync();
            }
            return true;
        }

        public bool LogOut(int id)
        {
            using (FSLEntities Fsla = new FSLEntities())
            {
                var user = Fsla.tblUsers?.Where(x => x.UserId == id).FirstOrDefault();
                user.LoginStatus = true;
                Fsla.SaveChangesAsync();
            }
            return true;
        }
    }
}