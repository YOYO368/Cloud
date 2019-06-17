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
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            ConnectDatabase aLayer = new ConnectDatabase();

            if (txtUserID.Text == "Admin")
            {
                if (txtUserPasswd.Text == "Admin")
                {
                    Response.Write("<script>alert('Your login success');window.location = '/ViewStaffSite.aspx';</script>");
                }
            }
            else
            {
                if (aLayer.CheckUserID_Password(txtUserID.Text, txtUserPasswd.Text))
                {
                }
                else
                {
                    ClearTextBox();
                    Response.Write("<script>alert('Can not find User ID and User Password');</script>");
                    return;
                }
            }
        }
        void ClearTextBox()
        {
            txtUserID.Text = "";
            txtUserPasswd.Text = "";
        }
    }
}