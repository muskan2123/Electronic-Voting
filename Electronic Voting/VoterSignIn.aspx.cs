using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Electronic_Voting
{
    public partial class VoterSignIn : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            

            SqlConnection con = new SqlConnection("Initial catalog=muskan; integrated security=true;server=OM\\SQLEXPRESS");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into voterslist values('" + TextBox1.Text + "','" + TextBox2.Text + "'," + TextBox3.Text + ")", con);
            Label5.Text = cmd.CommandText;
            int i = cmd.ExecuteNonQuery();
            Label5.Text = " Record inserted successfully";
        }
    }
}