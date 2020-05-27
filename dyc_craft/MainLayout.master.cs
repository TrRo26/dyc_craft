using System;
using System.Web;
using System.Web.UI;

namespace dyc_craft
{
    public partial class MainLayout : System.Web.UI.MasterPage
    {

        public static object getQuilts()
        {
            return Quilt.QuiltsDB();
        }

        public void toggleMainNavActive(object sender, EventArgs e)
        {
            //mainNavHome.Attributes.Remove("class");
            //mainNavAbout.Attributes.Add("class", "active");
            //mainNavHome.Attributes.Add("class", mainNavHome.Attributes["class"].ToString().Replace("active", ""));
        }

    }
}
