using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cloudsifter.Web
{
	public partial class Latest : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			// we live to serve... all we do here is look up the latest issue, and redirect...
			Data.Repositories.Newsletter newsletterRepository = new Data.Repositories.Newsletter();
			List<Data.Types.Newsletter> newsletters = newsletterRepository.GetAll();

			if (newsletters.Count > 0)
			{
				Response.Redirect(
					"~/past/" +
					newsletters[0].PublishDate.Value.Month.ToString() + "/" +
					newsletters[0].PublishDate.Value.Day.ToString() + "/" +
					newsletters[0].PublishDate.Value.Year.ToString()
					);
			}
			else
			{
				Response.Redirect("~/past");
			}
		}
	}
}