using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;

namespace FleetStudioLeaveApp.Controllers
{
    public class LoginController : ApiController
    {
        [HttpPost]
        public RedirectToRouteResult DoLogin(int id)
        {
            return RedirectToRoute("User/Get", id);
        }
    }
}
