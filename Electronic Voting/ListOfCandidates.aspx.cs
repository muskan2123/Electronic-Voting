using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Electronic_Voting
{
    public partial class ListOfCandidates : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                fillgrid("candidate_list");

            }
        }

        private void fillgrid(string s)
        {
            MyComponent obj = new MyComponent();
            DataSet ds = obj.getdata("select * from candidate_list " + s);
            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();

        }
        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}