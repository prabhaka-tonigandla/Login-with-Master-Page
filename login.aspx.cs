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
                u.Username = txtUsername.Text;
                u.Password = txtPassword.Text;
                UserDao ud = new UserDao();
                DataTable dt = ud.CheckUser(u);
                string role = dt.Rows[0]["Role"].ToString();
                if (dt.Rows.Count > 0)
                {
                    Session["Username"] = txtUsername.Text;
                    Session["Password"] = txtPassword.Text;
                    if (role == "Admin")
                    {
                        Response.Redirect("AdminPage.aspx");
                    }
                    if (role == "User")
                    {
                        Response.Redirect("User_profile.aspx");
                    }
                }
                else
                {
                    ltrMessage.Text="Invalid Username or Password";
                }
            }
            catch(Exception ex)
            {
                ltrMessage.Text = ex.Message;
            }
        }
    }
}