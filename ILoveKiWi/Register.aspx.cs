using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ILoveKiWi
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }
        protected void Button_Register_Click(object sender, EventArgs e)
        {
            ConnectDatabase aLayer = new ConnectDatabase();
            if (aLayer.CheckUserID(txtUserID.Text))
            {
                Response.Write("<script>alert('Same UserID aleady exit!!');</script>");
            }
            else
            {
                if (aLayer.AddNewCustomer(txtUserID.Text, txtUserPasswd.Text, txtUserName.Text, txtUserEmail.Text, txtUserMobile.Text))
                {
                    Response.Write("<script>alert('New customer is registered');window.location = '/Customer/CustomerLogin.aspx';</script>");
                    return;
                }
                else
                {
                    Response.Write("<script>alert('Can not add a new customer');window.location = '/ViewCustomerSite.aspx';</script>");
                    return;
                }
            }
        }

        protected void Button_Reset_Click(object sender, EventArgs e)
        {
            txtUserID.Text = "";
            txtUserPasswd.Text = "";
            txtConfirmPasswd.Text = "";
            txtUserName.Text = "";
            txtUserEmail.Text = "";
            txtUserMobile.Text = "";
        }
    }
}