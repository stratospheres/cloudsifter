<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SiteMap.aspx.cs" Inherits="Cloudsifter.Web.SiteMap" %><?xml version="1.0" encoding="UTF-8"?>
<urlset xmlns="http://www.sitemaps.org/schemas/sitemap/0.9">
	<url>
		<loc>http://www.cloudsifter.net/</loc>
		<lastmod><%=dateTimeNow %></lastmod>
		<changefreq>hourly</changefreq>
		<priority>1.0</priority>
	</url>
	<url>
		<loc>http://www.cloudsifter.net/subscribe</loc>
		<lastmod><%=dateTimeNow %></lastmod>
		<changefreq>weekly</changefreq>
		<priority>0.8</priority>
	</url>
	<url>
		<loc>http://www.cloudsifter.net/submit</loc>
		<lastmod><%=dateTimeNow %></lastmod>
		<changefreq>weekly</changefreq>
		<priority>0.8</priority>
	</url>
	<url>
		<loc>http://www.cloudsifter.net/past</loc>
		<lastmod><%=dateTimeNow %></lastmod>
		<changefreq>daily</changefreq>
		<priority>0.9</priority>
	</url>
<asp:Repeater ID="pastIssues" runat="server">
<ItemTemplate>
	<url>
		<loc>http://www.cloudsifter.net/past/<%#DataBinder.Eval(Container.DataItem, "PublishDate.Month")%>/<%#DataBinder.Eval(Container.DataItem, "PublishDate.Day")%>/<%#DataBinder.Eval(Container.DataItem, "PublishDate.Year")%></loc>
		<lastmod><%=dateTimeNow %></lastmod>
		<changefreq>daily</changefreq>
		<priority>0.8</priority>
	</url>
</ItemTemplate>
</asp:Repeater>
<asp:Repeater ID="linksRepeater" runat="server">
<ItemTemplate>
	<url>
		<loc>http://www.cloudsifter.net/link/<%#DataBinder.Eval(Container.DataItem, "Id")%></loc>
		<lastmod><%=dateTimeNow %></lastmod>
		<changefreq>daily</changefreq>
		<priority>1.0</priority>
	</url>
</ItemTemplate>
</asp:Repeater>
</urlset>