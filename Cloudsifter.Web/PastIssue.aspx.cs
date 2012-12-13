using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cloudsifter.Web
{
	public partial class PastIssue : System.Web.UI.Page
	{
		public int NewsletterId = -1;

		protected void Page_Load(object sender, EventArgs e)
		{
			if (!IsPostBack)
			{
				string monthAsString = Page.RouteData.Values["Month"] as string;
				string dayAsString = Page.RouteData.Values["Day"] as string;
				string yearAsString = Page.RouteData.Values["Year"] as string;

				int month, day, year;
				if (
					!int.TryParse(monthAsString, out month) ||
					!int.TryParse(dayAsString, out day) ||
					!int.TryParse(yearAsString, out year))
				{
					// no apparent parameter, we should redirect to the past issues list...
					Response.Redirect("~/past");
				}
				else
				{
					// numbers seem legit - look this thing up...
					Data.Repositories.Newsletter newsletterRepository = new Data.Repositories.Newsletter();
					Data.Types.Newsletter newsletter = newsletterRepository.GetByMonthDayYear(month, day, year);

					// fill out the title and description
					titleLiteral.Text = newsletter.Name;
					descriptionLiteral.Text = newsletter.Description;

					// save the Id so that the front end page can use it to parameterize the nested repeater calls
					NewsletterId = newsletter.Id;

					// figure out what categories are represented...
					Data.Repositories.Category categoryRepository = new Data.Repositories.Category();
					List<Data.Types.Category> categories = categoryRepository.GetAllRelatedToNewsletter(newsletter.Id);
					newsletterRepeater.DataSource = categories;
					newsletterRepeater.DataBind();
				}

			}
		}
	}
}