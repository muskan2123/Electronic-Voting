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
    public partial class AdminModification : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            
        }

        

        

   

     

    

        protected void Wizard1_FinishButtonClick(object sender, WizardNavigationEventArgs e)
        {

        }

 

      

        protected void LinkButton3_Click1(object sender, EventArgs e)
        {
            Response.Redirect("HomePage");
        }

      

        protected void LinkButton4_Click(object sender, EventArgs e)
        {
            Response.Redirect("list of voters");
        }

        protected void LinkButton5_Click(object sender, EventArgs e)
        {
            Response.Redirect("ListOfCandidates");
        }
    }


    
}