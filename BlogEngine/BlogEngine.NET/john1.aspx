<%@ Page Language="C#" AutoEventWireup="true" Inherits="BlogEngine.NET.john1" Codebehind="john1.aspx.cs"%>

<asp:Content ID="Content1" ContentPlaceHolderID="cphBody" Runat="Server">

  <div class="post error404 page-global">

	<h2 class="page-global-title">Ooops! I can't find the page you're looking for</h2>

    <div id="divDirectHit" runat="server" visible="True">
      <p>You might find one of the following links useful:</p>
      <ul>
        <li><a href="<%=BlogEngine.Core.Utils.RelativeWebRoot %>">Return to Home page</a></li>
		<li><a href="archive<%= BlogEngine.Core.BlogConfig.FileExtension %>"><%=Resources.labels.archive %></a></li>
      </ul>
      <p>You can also try to <a href="<%=BlogEngine.Core.Utils.RelativeWebRoot %>search">search for the page you were looking for</a>.</p>
	  <br />
      <p>You may not have been able to find the page you were after because of:</p>
      <ol type="a">
        <li>An out-of-date bookmark/favorite</li>
        <li>A search engine that has an out-of-date listing for us</li>
        <li>A miss-typed address</li>
      </ol>
    </div>		
		
  </div>

</asp:Content>
