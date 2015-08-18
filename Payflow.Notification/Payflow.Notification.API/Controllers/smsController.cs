using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Payflow.Notification.API.Controllers
{
    public class SMSController : ApiController
    {
        public HttpResponseMessage Put(string user_id, string user_pwd, string sent_to, string sent_content)
        {
            HttpResponseMessage response = new HttpResponseMessage();
            bool result = SMS.Send(sent_to, sent_content);
            if (result) response.StatusCode = HttpStatusCode.OK;
            else response.StatusCode = HttpStatusCode.BadGateway;
            return response;
        }
    }
}
