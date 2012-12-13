using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cloudsifter.Web
{
    public partial class Subscribe : System.Web.UI.Page
    {
        public bool IsFirstTime = false;
		public bool IsAlreadySubscribed = false;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                // validate our inputs? (TODO - jquery on client probably did a good enough job)
                string email = "";
                if (!string.IsNullOrWhiteSpace(Request.Form["email"]))
                    email = Request.Form["email"].Trim();

                // post to mailchimp
				if (email != "")
				{
					Utility.ResponseCode returnCode = Cloudsifter.Web.Utility.MailChimpHelper.AddSubscriber(email);
					if (returnCode == Utility.ResponseCode.SubscriberAlreadyExists)
						IsAlreadySubscribed = true;
				}

                // show some feedback.
                IsFirstTime = false;
            }
            else
            {
                // this is the first time through the page... show the form...
                IsFirstTime = true;
            }
        }
    }
}