using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SelectRepeater : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
        //http://pietschsoft.com/post/2005/12/28/ASPNET-20-How-to-get-a-specific-ConnectionString-from-the-WebConfig-by-name.aspx
        var conString = System.Configuration.ConfigurationManager.ConnectionStrings["democonnection"];
        conn.ConnectionString = conString.ConnectionString;
        conn.Open();

        string sql = "select * from HuberUsers2012spb";


        System.Data.SqlClient.SqlDataReader dr;
        
        
        System.Data.SqlClient.SqlCommand comm = new System.Data.SqlClient.SqlCommand();
        comm.Connection = conn;
        comm.CommandText = sql;

        dr = comm.ExecuteReader();


        rptUsers.DataSource = dr;
        rptUsers.DataBind();



    }
}