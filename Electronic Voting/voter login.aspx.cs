using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Electronic_Voting
{
    public partial class voter_login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Initial catalog=muskan; integrated security=true;server=OM\\SQLEXPRESS");
            con.Open();
            SqlCommand cmd = new SqlCommand("select count(1) from voterslist where FirstName='" + TextBox1.Text + "'" + " and LastName='"  +TextBox2.Text + "'" + "and VoterId =" + TextBox3.Text + "", con);
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            if (count == 1)
            {
                Session["FirstName"] = TextBox1.Text.Trim();
                Label6.Text = "login successful";

                Response.Redirect("Voter Page.aspx");
            }

            else
            {
                Label6.Text = "invalid username or password";
            }
        }
    }
}