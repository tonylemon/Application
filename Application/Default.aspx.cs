using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Application
{
    public partial class Default : System.Web.UI.Page
    {
        protected static bool IsData = false;
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = "您是该网站的第" + Application["count"].ToString() + "个访问者";
            PC.Text = Application["PC"].ToString();
            Android.Text = Application["Android"].ToString();
            Iphone.Text = Application["Iphone"].ToString();
            Ipad.Text = Application["Ipad"].ToString();
        }
    }
}