<%@ Page Title="DYC CRAFT" Language="C#" MasterPageFile="~/MainLayout.Master" Inherits="dyc_craft.Default" %>

<asp:Content ContentPlaceHolderID="DefaultPagePlaceholder" runat="server">
    
    <form id="QuiltsAndQuilts" runat="server">
        <div>
            <asp:Repeater id="quiltList" runat="server" >
                <ItemTemplate>
                    
                    <table>
                        <tr><td>Quilt Id</td><td><asp:TableCell runat="server" ID="QuiltId" Text= '<%# Eval("Id") %>' visible="true"/> </td></tr>
                        <tr><td>Name</td><td><asp:TableCell runat="server" ID="QuiltName" Text= '<%# Eval("Name") %>' visible="true"/> </td></tr>
                        <tr><td>OriginDate</td><td><asp:TableCell runat="server" ID="QuiltOriginDate" Text= '<%# Eval("OriginDate") %>' visible="true"/> </td></tr>
                        <tr><td>Dimensions</td><td><asp:TableCell runat="server" ID="QuiltImage" Text='<%# Eval("Dimensions") %>' visible="true" /></td></tr>
                        <tr><td>Description</td><td><asp:TableCell runat="server" ID="QuiltDescription" Text= '<%# Eval("Description") %>'visible="true" /></td></tr>
                        <tr><td>LocaleOfInspiration</td><td><asp:TableCell runat="server" ID="QuiltLocaleOfInspiration" Text='<%# Eval("LocaleOfInspiration") %>' visible="true" /></td></tr>                        
                        <tr><td>MaterialAndTechnique</td><td><asp:TableCell runat="server" ID="QuiltMaterialAndTechnique" Text='<%# Eval("MaterialAndTechnique") %>' visible="true" /></td></tr>                        
                        <tr><td>ArtistName</td><td><asp:TableCell runat="server" ID="QuiltArtistName" Text='<%# Eval("ArtistName") %>' visible="true" /></td></tr>                        
                    </table>
                    <div class="landing-page-primary-image-container">
                        <asp:Image class="landing-page-primary-image" runat="server" ID="QuiltImage" AlternateText="Image not found" ImageUrl='<%# Eval("ImageURL") %>' visible="true" /></td></tr>                        
                    </div>
                    
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </form>
        
    <form id="form2" runat="server">
        <asp:Button id="button2" runat="server" Text="Go To About Page" OnClick="redirectToAbout" />
    </form>
    
	<form id="form1" runat="server">
		<asp:Button id="button1" runat="server" Text="Click me!" OnClick="button1Clicked" />
	</form>

</asp:Content>
