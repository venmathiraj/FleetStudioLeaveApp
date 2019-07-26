using FleetStudioLeaveApp.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FleetStudioLeaveApp.Controllers
{
    public class AdminController : ApiController
    {

        private AdminLeaveService _AdminLeaveService;
        private UserService userService;

        public AdminController()
        {
            _AdminLeaveService = new AdminLeaveService();
            userService = new UserService();
        }
        [HttpGet]
        [Route("api/admin/get")]
        public HttpResponseMessage GetAllUserLeave()
        {
            var userLeave = _AdminLeaveService.GetAllUserLeave();
            if (userLeave != null)
                return Request.CreateResponse(HttpStatusCode.OK, userLeave);
            else return Request.CreateErrorResponse(HttpStatusCode.NotFound, "No records found");
        }

        [HttpPost]
        [Route("api/admin/approve")]
        public HttpResponseMessage ApproveUserLeave([FromBody] int id)
        {
            var userLeave = _AdminLeaveService.GetAllUserLeave();
            if (userLeave != null)
                return Request.CreateResponse(HttpStatusCode.OK, userLeave);
            else return Request.CreateErrorResponse(HttpStatusCode.NotFound, "No records found");
        }

        [HttpPost]
        [Route("api/admin/reject")]
        public HttpResponseMessage RejectUserLeave([FromBody] int id)
        {
            var userLeave = _AdminLeaveService.GetAllUserLeave();
            if (userLeave != null)
                return Request.CreateResponse(HttpStatusCode.OK, userLeave);
            else return Request.CreateErrorResponse(HttpStatusCode.NotFound, "No records found");
        }
    }
}
