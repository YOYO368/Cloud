using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ILoveKiWi
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }
        void ClearTextBox()
        {
            txtUserID.Text = "";
            txtUserPasswd.Text = "";
        }

        protected void btnLogin_Click1(object sender, EventArgs e)
        {
            ConnectDatabase aLayer = new ConnectDatabase();

            if (aLayer.CheckUserID_Password(txtUserID.Text, txtUserPasswd.Text))
            {
                Response.Write("<script>alert('Your login success');window.location = '/KiWiMainPage.aspx';</script>");
            }
            else
            {
                ClearTextBox();
                Response.Write("<script>alert('Can not find User ID and User Password');</script>");
                return;
            }
        }
    }
}