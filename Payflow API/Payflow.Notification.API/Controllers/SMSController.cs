using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text.RegularExpressions;
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

        public HttpResponseMessage Post(string user_id, string user_pwd, string command_code, string sent_to, string sent_content)
        {
            HttpResponseMessage response = new HttpResponseMessage();
            bool result = SMS.Send(sent_to, sent_content);
            if (result) response.StatusCode = HttpStatusCode.OK;
            else response.StatusCode = HttpStatusCode.BadGateway;
            return response;
        }

        public HttpResponseMessage Topup(string user_id, string user_pwd, string partner_code, string name_code, string phone_number, string sent_to, string sent_content)
        {
            HttpResponseMessage response = new HttpResponseMessage();
            if(IsValidMobile(phone_number)==true)
            {
                if(CheckPhoneSupport(phone_number)==true)
                {                   
                    bool result = SMS.Send(sent_to, sent_content);
                    if (result) response.StatusCode = HttpStatusCode.OK;
                    else response.StatusCode = HttpStatusCode.BadGateway;
                }
            }           
            return response;
        }

        //kiem tra sdt
        public static bool IsValidMobile(string phone_number)
        {
            if(string.IsNullOrEmpty(phone_number))
            {
                return false;
            }
            phone_number = phone_number.Trim();
            const string checkPhonenumber = @"^[0]d{9,10}$";
            Regex regexPhonenumber = new Regex(checkPhonenumber);
            Match mPhonenumber = regexPhonenumber.Match(phone_number);
            if(!mPhonenumber.Success)
            { return false; }
            return true;
        }
        // kiem tra so thuoc mang nao viettel vina mobifone
        public static bool CheckPhoneSupport(string phone_number)
        {
            const int networkLength = 4;
            const int RegionConuntryCode = 84;
            if(phone_number.StartsWith("+"))
            {
                phone_number = phone_number.Replace("+", "0");
            }

            if(phone_number.StartsWith("0" + RegionConuntryCode))
            {
                phone_number = phone_number.Replace("0" + RegionConuntryCode, "0");
            }
            // Đầu số Mobifone: 090…….093…….0120…….0121…….0122…….0126…….0128…….
            // Đầu số Viettel:096…….097…….098…….0163…….0164…….0165…….0166…….0167…….0168…….0169…….
            // Đầu số Vinaphone:091…….094…….0123…….0124…….0125…….0127…….0129…….
            string[] networkSupport = { "096", "097", "098", "0163", "0164", "0165", "0166", "0167", "0168", "0169",
            "090", "093","0120", "0121", "0122","0126","0128",
            "091", "094","0123","0124","0125","0127","0129" };
            var startphone_number = phone_number.Substring(0, networkLength);
            return networkSupport.Any(startphone_number.Equals);
        }
    }
}
