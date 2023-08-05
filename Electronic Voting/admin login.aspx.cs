using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Electronic_Voting
{
    public partial class admin_login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("Initial catalog=muskan; integrated security=true;server=OM\\SQLEXPRESS");
            con.Open();
            SqlCommand cmd = new SqlCommand("select count(1) from admin_login where username='" + TextBox1.Text + "'"+ "and password=" + TextBox2.Text + "", con);
            int count=Convert.ToInt32(cmd.ExecuteScalar());
            if (count == 1)
            {
                Session["username"]=TextBox1.Text.Trim();
                Label4.Text = "login successful";

                Response.Redirect("AdminModification.aspx");

            }

            else
            {
                Label4.Text = "invalid username or password";
            }


            /*SqlConnection con = new SqlConnection("Initial catalog=muskan; integrated security=true;server=OM\\SQLEXPRESS");
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select * from dept", con);
            DataSet ds = new DataSet();
            da.Fill(ds);



             SqlCommand cmd = new SqlCommand("select* from dept", con);
             SqlDataReader dr = cmd.ExecuteReader();

             if (dr.HasRows)
             {
                 Label1.Text = "welcome: " + TextBox1.Text;

             }
             else
             {
                 Response.Write("invalid username and password");
             }*/





        }
    }
}