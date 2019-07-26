using FleetStudioLeaveApp.Models;
using FleetStudioLeaveApp.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Policy;
using System.Web.Http;

namespace FleetStudioLeaveApp.Controllers
{
    public class UserController : ApiController
    {
        private UserLeaveService userLeaveService;
        private UserService userService;

        public UserController()
        {
            userLeaveService = new UserLeaveService();
            userService = new UserService();
        }

        [HttpPost]
        [Route("api/user/loggedin/{id}")]
        public HttpResponseMessage UserLoggedIn([FromUri] int id)
        {
            if (userService.Login(id))
            {
                return Request.CreateResponse(HttpStatusCode.OK, true);
            }
            else return Request.CreateErrorResponse(HttpStatusCode.NotFound, "No records found");
        }

        [HttpPost]
        [Route("api/user/loggedout/{id}")]
        public IHttpActionResult UserLoggedOut([FromUri] int id)
        {
            if (userService.Logout(id))
            {
                return Ok(true);
            }
            else return NotFound();
        }

        [HttpGet]
        [Route("api/user/get/{id}")]
        public IHttpActionResult GetUserLeave([FromUri] int id)
        {
            var userLeave = userLeaveService.Get(id);
            if (userLeave != null)
                return Ok(userLeave);
           return NotFound();
        }

        [HttpPost]
        [Route("api/user/new")]
        public IHttpActionResult NewUser([FromBody] User user)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            if (userService.AddUser(user))
            {
                return Ok(true);
            }
            return Content(HttpStatusCode.OK,false);
        }

        [HttpPost]
        [Route("api/user/requestleave")]
        public IHttpActionResult ApplyLeave([FromBody] Leave leave)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            var userLeave = userLeaveService.ApplyLeave(leave);
            if (userLeave!=null)
            {
                return Ok(true);
            }
            return Content(HttpStatusCode.OK, false);
        }

        
    }
}
