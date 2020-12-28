using DotNetNuke.Services.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Jhohan.Modules.DNNModuleTest.Utils
{
    public static class surveyEmails
    {
        public static void SendMail(string strCC, string strBCC, string strBody)

        {

            try

            {

                /*** Get the host settings information***/

                Dictionary<string, string> hostSettings = DotNetNuke.Entities.Controllers.HostController.Instance.GetSettingsDictionary();

                /*** Set the SMTP server details ***/

                string strSMTP = hostSettings["SMTPServer"];

                string strFrom = hostSettings["HostEmail"];

                string EMailID = "Jhohan25@hotmail.com";

                string Subject = "Test Mail";

                /*** This is the actual built in function from DNN Framework. ***/

                DotNetNuke.Services.Mail.Mail.SendMail(strFrom, EMailID, strCC, strBCC, DotNetNuke.Services.Mail.MailPriority.Normal, Subject, DotNetNuke.Services.Mail.MailFormat.Html, System.Text.Encoding.UTF8, strBody, "",

                strSMTP, hostSettings["SMTPAuthentication"], hostSettings["SMTPUsername"], hostSettings["SMTPPassword"]);

            }

            catch (Exception ex)
            {

                Exceptions.LogException(ex);

            }

        }
    }
}