using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

using Login_with_Master_Page.Bill;
using Login_with_Master_Page.Dao;

namespace Login_with_Master_Page
{
    public partial class homepage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void log_Click(object sender, EventArgs e)
        {
            //Implementing try and catch
            try
            {
                User u = new User();
                u.Username = txtUsername.text;
                u.Password = txtPassword.text;
                UserDao ud = new UserDao();
                DataTable dt = ud.CheckUser(u);
                if (dt.Rows.Count > 0)
                {
                    Response.Redirect("AdminPage.aspx");
                }
                else
                {
                    msg.Text=""Invalid Username or Password";
                }
            }
            catch(Exception ex)
            {
                msg.Text = ex.Message;
            }
        }
    }
}