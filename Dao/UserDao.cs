using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data;
using System.Data.SqlClient;
using Login_with_Master_Page.Bill;
using Login_with_Master_Page.Utils;

namespace Login_with_Master_Page.Dao
{
    public class UserDao
    {
        //Check username nad password
        public DataTable CheckUser(User u)
        {
            //connection to Database
            DbConnection dc = new DbConnection();
            string sql = "SELECT * FROM LOGIN WHERE Username=@Username and Password=@Password";
            SqlCommand cmd = new SqlCommand(sql, dc.cn);
            cmd.Parameters.AddWithValue("@Username", u.Username);
            cmd.Parameters.AddWithValue("@Password", u.Password);
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();
            //Database name
            da.Fill(ds, "Login");
            return ds.Tables["Login"];
        }
    }
}