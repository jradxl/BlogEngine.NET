using System;
using System.Web.UI;
using BlogEngine.Core.Web.Controls;
using BlogEngine.Core;

namespace BlogEngine.NET
{
	public partial class john1 : BlogBasePage
	{
		protected override void Render(HtmlTextWriter writer)
		{
			base.Render(writer);
			Response.StatusCode = 404;
		}

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);
			Page.Title += Server.HtmlEncode(" - " + Resources.labels.PageNotFound);
		}
	}
}
