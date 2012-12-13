using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cloudsifter.Web
{
	public partial class PastIssues : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!IsPostBack)
			{
				Data.Repositories.Newsletter newsletterRepository = new Data.Repositories.Newsletter();
				List<Data.Types.Newsletter> newsletters = newsletterRepository.GetAll();
				newslettersRepeater.DataSource = newsletters;
				newslettersRepeater.DataBind();
			}
		}
	}
}