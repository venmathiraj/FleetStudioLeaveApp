using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FleetStudioLeaveApp.Models;
using FleetStudioLeaveApp.Repository;

namespace FleetStudioLeaveApp.Service
{
    public class UserService : IUserService
    {
        private UserRepository userRepository;

        public UserService()
        {
            userRepository = new UserRepository();
        }
        public bool AddUser(User user)
        {
            return userRepository.AddUser(user);
        }

        public bool Login(int id)
        {
            return userRepository.Loggin(id);
        }

        public bool Logout(int id)
        {
            return userRepository.LogOut(id);
        }
    }
}