
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
    public partial class list_of_voters : System.Web.UI.Page
    {


        private void fillgrid()
        {
            MyComponent obj = new MyComponent();
            DataSet ds = obj.getdata("select * from voterslist ");
            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();

        }
        protected void Page_Load(object sender, EventArgs e)
        {
             if (!IsPostBack)
             {
                 fillgrid();  

             }
             //MyComponent obj = new MyComponent();
             //DataSet ds = obj.getdata("select * from voterslist");
             //GridView1.DataSource = ds.Tables[0];
             //GridView1.DataBind();

        }

      protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            SqlConnection con = new SqlConnection("Initial catalog=muskan; integrated security=true;server=OM\\SQLEXPRESS");
            Response.Write(e.RowIndex);
            string pid = GridView1.Rows[e.RowIndex].Cells[0].Text;
            int empno = int.Parse(pid);
            cmd.CommandText = "delete from voterslist where FirstName=" + empno;

            cmd.Connection = con;
            con.Open();
            cmd.ExecuteNonQuery();
            fillgrid();

        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            int n = e.NewEditIndex;
            GridView1.EditIndex = n;

            this.fillgrid();
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1; //no editing row
            this.fillgrid();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            SqlConnection con = new SqlConnection("Initial catalog=muskan; integrated security=true;server=OM\\SQLEXPRESS");
            SqlCommand cmd = new SqlCommand();

            string FirstName = ((TextBox)GridView1.Rows[e.RowIndex].Cells[0].Controls[0]).Text.Trim();

            string LastName = ((TextBox)GridView1.Rows[e.RowIndex].Cells[1].Controls[0]).Text.Trim();
            string VoterID = ((TextBox)GridView1.Rows[e.RowIndex].Cells[2].Controls[0]).Text.Trim();

            //Prepare Sql Update Command 
            string strSqlCommand = "Update voterslist Set FirstName='" + FirstName + "', LastName='" + LastName + "' Where VoterID=" + VoterID + " ";


            con.Open();
            cmd = new SqlCommand(strSqlCommand, con);
            int i = cmd.ExecuteNonQuery();
            if (i > 0)
            {
                Response.Write("Employee Data Updated Successfully!!!");
                GridView1.EditIndex = -1; //Refresh GridView 
                this.fillgrid();
            }

        }
    }
}
