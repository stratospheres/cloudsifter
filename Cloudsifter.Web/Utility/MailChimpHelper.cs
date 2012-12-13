using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;

namespace Cloudsifter.Web.Utility
{
	public enum ResponseCode
	{
		Success,
		SubscriberAlreadyExists
	}

    public static class MailChimpHelper
    {
        public static ResponseCode AddSubscriber(string emailAddress)
        {
            var postString =
                   String.Format(
                       @"http://us5.api.mailchimp.com/1.3/?method=listSubscribe&apikey={0}&id={1}&email_address={2}&output=xml",
                           "a0921d4688db61f062e32c47630426a7-us5",
                           "a685cce8c1",
                           emailAddress);

            try
            {
                HttpWebRequest myRequest = WebRequest.Create(postString) as HttpWebRequest;
                myRequest.Method = "POST";
                myRequest.ContentType = "application/x-www-form-urlencoded";
                myRequest.ServicePoint.Expect100Continue = false;

                string results;
                using (var requestStream = new StreamWriter(myRequest.GetRequestStream()))
                {
                    requestStream.Write(String.Empty);
                    requestStream.Close();

                    using (var responseReader = new StreamReader(myRequest.GetResponse().GetResponseStream()))
                    {
                        results = responseReader.ReadToEnd();

						if (results.Contains("is already subscribed"))
							return ResponseCode.SubscriberAlreadyExists;
						else
							return ResponseCode.Success;
                    }
                }
            }
            catch (Exception e)
            {
                //Elmah.ErrorSignal.FromCurrentContext().Raise(e);
                throw e;
            }
        }
    }
}