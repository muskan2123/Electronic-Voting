﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Electronic_Voting
{
    public partial class Voter_Page : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("ListOfCandidates");
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {

        }
    }
}