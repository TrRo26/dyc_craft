using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Linq;
using System.Collections.Generic;

namespace dyc_craft
{

    public partial class Default : System.Web.UI.Page
    {
        List<Quilt> allQuilts;

        protected void Page_Load(object sender, EventArgs e)
        {
            allQuilts = Quilt.QuiltsDB();
            quiltList.DataSource = allQuilts;
            quiltList.DataBind();
        }

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
