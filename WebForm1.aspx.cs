using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace sqldatacode
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Login_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=ITLAB01\SQLEXPRESS;Initial Catalog=cse_user;User ID=sa;Password=system123#");
            con.Open();
            SqlCommand con1 = new SqlCommand("select * from cseuser where login='" + login_box.Text + "' and pwd='" + pwd_box.Text + "' ", con);
            SqlDataReader r;
            r = con1.ExecuteReader();
            /*GridView1.DataSource = r;
            GridView1.DataBind();*/

            if (r.HasRows)
                Label1.Text = "login details valid";
            else
                Label1.Text = "login details invalid";
        }

        protected void search_button_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=ITLAB01\SQLEXPRESS;Initial Catalog=cse_user;User ID=sa;Password=system123#");
            con.Open();
            SqlCommand con1 = new SqlCommand("select * from cseuser where login='" + Box_1.Text + "'", con);
            SqlDataReader r;
            r = con1.ExecuteReader();
            GridView1.DataSource = r;
            GridView1.DataBind();
        }
    }
}