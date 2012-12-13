using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cloudsifter.Web
{
	public partial class Link : System.Web.UI.Page
	{
		public Cloudsifter.Data.Types.Link TheLink;
		
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!IsPostBack)
			{
				string idAsString = Page.RouteData.Values["ID"] as string;

				int id;
				if (!int.TryParse(idAsString, out id))
				{
					// no apparent parameter, we should redirect to the past issues list...
					Response.Redirect("~/past");
				}
				else
				{
					// numbers seem legit - look this thing up...
					Data.Repositories.Link linkRepository = new Data.Repositories.Link();
					TheLink = linkRepository.GetById(id);
					titleLiteral.Text = TheLink.Title;
					descriptionLiteral.Text = TheLink.Description;
					urlLiteral.Text = "<a href=\"" + TheLink.URL + "\" target=\"_blank\">" + TheLink.URL + "</a>";

					// figure out who spotted the links
					Data.Repositories.LinkSpotter linkSpotterRepository = new Data.Repositories.LinkSpotter();
					List<Data.Types.LinkSpotter> linkSpotters = linkSpotterRepository.GetByLinkId(id);
					linkSpotterRepeater.DataSource = linkSpotters;
					linkSpotterRepeater.DataBind();
				}

			}

		}
	}
}