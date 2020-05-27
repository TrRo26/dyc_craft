using System;
using System.Web;
using System.Web.UI;

namespace dyc_craft
{

    public partial class Default : System.Web.UI.Page
    {
        public void redirectToAbout(object sender, EventArgs args)
        {
            Response.Redirect("About.aspx");
            //Server.Transfer("page.aspx", );
        }

        public void button1Clicked(object sender, EventArgs args)
        {
            button1.Text = "You clicked me";
        }
    }
}
