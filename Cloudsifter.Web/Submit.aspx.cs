using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cloudsifter.Web
{
    public partial class Submit : System.Web.UI.Page
    {
        public bool IsFirstTime = false;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                // validate our inputs? (TODO - jquery on client probably did a good enough job)
                string name = "";
                string website = "";
                string url = "";
                string title = "";
                string description = "";

                if (!string.IsNullOrWhiteSpace(Request.Form["name"]))
                    name = Request.Form["name"];
                if (!string.IsNullOrWhiteSpace(Request.Form["website"]))
                    website = Request.Form["website"];
                if (!string.IsNullOrWhiteSpace(Request.Form["url"]))
                    url = Request.Form["url"];
                if (!string.IsNullOrWhiteSpace(Request.Form["title"]))
                    title = Request.Form["title"];
                if (!string.IsNullOrWhiteSpace(Request.Form["description"]))
                    description = Request.Form["description"];

                // post to database
				// 1. see if this name already exists...
				Cloudsifter.Data.Repositories.LinkSpotter linkSpotterRepository = new Data.Repositories.LinkSpotter();
				Data.Types.LinkSpotter linkSpotter = linkSpotterRepository.GetByFullName(name);

				// 2. do we need to create it?
				if (linkSpotter == null)
				{
					// need to create that record first...
					linkSpotter = new Data.Types.LinkSpotter();
					linkSpotter.FullName = name;
					linkSpotter.URL = website.ToLower();
					linkSpotter.PUID = null;

					int newID = linkSpotterRepository.Add(linkSpotter);
				}
				else
				{
					// push out the website data as an update to the existing record (just in case it's changed)
					linkSpotter.URL = website;
					linkSpotterRepository.Update(linkSpotter);
				}
				
				// 3. see if this link already exists in our unprocessed links...
				Cloudsifter.Data.Repositories.UnprocessedLink unprocessedLinkRepository = new Data.Repositories.UnprocessedLink();
				Data.Types.UnprocessedLink unprocessedLink = unprocessedLinkRepository.GetByTitleAndURL(title, url);

				// 4. do we need to create it?
				if (unprocessedLink == null)
				{
					unprocessedLink = new Data.Types.UnprocessedLink();
					unprocessedLink.Title = title;
					unprocessedLink.URL = url.ToLower();
					unprocessedLink.Description = description;

					int newID = unprocessedLinkRepository.Add(unprocessedLink);
				}

				// 5. connect the dots...
				Cloudsifter.Data.Repositories.LinkSpotterUnprocessedLink linkSpotterUnprocessedLinkRepository = new Data.Repositories.LinkSpotterUnprocessedLink();
				Data.Types.LinkSpotterUnprocessedLink linkSpotterUnprocessedLink = new Data.Types.LinkSpotterUnprocessedLink();
				linkSpotterUnprocessedLink.LinkSpotterId = linkSpotter.Id;
				linkSpotterUnprocessedLink.UnprocessedLinkId = unprocessedLink.Id;
				linkSpotterUnprocessedLink.ReportedDate = DateTime.Now;

				try
				{
					linkSpotterUnprocessedLinkRepository.Add(linkSpotterUnprocessedLink);
				}
				catch (Exception ex)
				{
					if (ex.Message.Contains("violation of PRIMARY KEY constraint"))
					{
						// we don't care about this...
					}
					else
						throw;
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