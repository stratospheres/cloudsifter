using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cloudsifter.Web
{
	public partial class SiteMap : System.Web.UI.Page
	{
		public string dateTimeNow = DateTime.Now.ToString("yyyy-MM-dd");
		protected void Page_Load(object sender, EventArgs e)
		{
			Data.Repositories.Newsletter newsletterRepository = new Data.Repositories.Newsletter();
			var newsletters = newsletterRepository.GetAll();
			this.pastIssues.DataSource = newsletters;
			this.pastIssues.DataBind();

			Data.Repositories.Link linkRepository = new Data.Repositories.Link();
			var links = linkRepository.GetAll();
			linksRepeater.DataSource = links;
			linksRepeater.DataBind();
		}
	}
}