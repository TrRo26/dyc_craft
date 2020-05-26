<%@ Page Language="C#" Inherits="dyc_craft.Default" %>
<!DOCTYPE html>
<html>
<head runat="server">
	<title>DYC Craft</title>
    <link href="./Stylesheets/LandingPage.css" rel="stylesheet" type="text/css" />
</head>
<body>
        
    <div class="landing-page-title">
        <h1>DYC CRAFT</h1>
    </div>
        
    <div class="landing-page-primary-image-container">
        <asp:Image class="landing-page-primary-image" ID="testQuilt" runat="server" ImageUrl="~/Content/Images/TestQuilt.jpg" />
    </div>
        
	<form id="form1" runat="server">
		<asp:Button id="button1" runat="server" Text="Click me!" OnClick="button1Clicked" />
	</form>

</body>
</html>
