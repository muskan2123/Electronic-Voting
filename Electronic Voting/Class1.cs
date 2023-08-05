using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace Electronic_Voting
{
    public class MyComponent
    {
        public DataSet getdata(string s)
        {

            SqlConnection con = new SqlConnection("Initial catalog=muskan; integrated security=true;server=OM\\SQLEXPRESS");

            SqlDataAdapter da = new SqlDataAdapter(s, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return (ds);
        }
    }
}