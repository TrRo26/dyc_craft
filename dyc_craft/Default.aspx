<%@ Page Title="DYC CRAFT" Language="C#" MasterPageFile="~/MainLayout.Master" Inherits="dyc_craft.Default" %>

<asp:Content ContentPlaceHolderID="DefaultPagePlaceholder" runat="server">
    
    <div class="landing-page-title">
        <h1>DYC CRAFT</h1>
    </div>
        
    <form id="form2" runat="server">
        <asp:Button id="button2" runat="server" Text="Go To About Page" OnClick="redirectToAbout" />
    </form>
        
    <div class="landing-page-primary-image-container">
        <asp:Image class="landing-page-primary-image" ID="testQuilt" runat="server" ImageUrl="~/Content/Images/TestQuilt.jpg" />
    </div>
        
	<form id="form1" runat="server">
		<asp:Button id="button1" runat="server" Text="Click me!" OnClick="button1Clicked" />
	</form>

</asp:Content>
