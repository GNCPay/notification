using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payflow.Notification
{
    public class SMS
    {
        public static bool Send(
            string ReceiverTel,
            string Content)
        {
            ReceiverTel = ReceiverTel.Replace(" ", "").Replace("+", "");
            if (ReceiverTel.StartsWith("0")) ReceiverTel = ReceiverTel.Substring(1, ReceiverTel.Length - 1);
            if (ReceiverTel.StartsWith("84")) ReceiverTel = ReceiverTel.Remove(0, 2);

            ReceiverTel = "84" + ReceiverTel;
            string iResult = "0";

            iResult = SendSMSIncom(ReceiverTel, Content, false);
            //dynamic log = null;// = new Data.Log();
            //log.Module = "NOTIFICATION";
            //log.Category = "INFO";
            //log.LogKey = "SMS";
            //log.CreatedBy = "notification@epayment.vn";
            //log.CreatedTime = DateTime.Now;
            //log.LogMessage = string.Concat("Send SMS (INCOM) to ", ReceiverTel, " return: ", iResult);
            return iResult == "1";
        }

        public static string SendSMSIncom(string ReceiverTel, string Content, bool isBrandName)
        {
            string account_name = "Payflowdauso";
            string account_pwd = "AccOUnSenDMTdauso6x8938mtSS";
            string brand_code = "PAYID";
            string brand_num = "6089";
            string command_code = "PAYID";
            sms.incom.Service_SendSMSSoapClient proxy = new sms.incom.Service_SendSMSSoapClient();
            return proxy.SendSMS(
                account_name
                , account_pwd
                , ReceiverTel,
                Content,
                (isBrandName) ? brand_code : brand_num,//NganhangMDB
                command_code,
                "0",
                "0",
                "1",
                "1",
                "0",
                "0").ToString();
        }
    }
}
