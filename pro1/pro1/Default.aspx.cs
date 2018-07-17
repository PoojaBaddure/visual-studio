using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

namespace pro1
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(t1.Text);
            int b = int.Parse(t2.Text);
            if (a > b)
            {
                t3.Text = (" " + a);
            }
            else
            {
                t3.Text = (" " + b);
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int a = int.Parse(t1.Text);
            int b = int.Parse(t2.Text);
            if (a > b)
            {
                t3.Text = (" " + b);
            }
            else
            {
                t3.Text = (" " + a);
            }

        }
    }
}
