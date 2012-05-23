using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//using System.Data;

public partial class Page2 : System.Web.UI.Page
{


    protected void btnInsert_Click(object sender, EventArgs e)
    {
        System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
            //http://pietschsoft.com/post/2005/12/28/ASPNET-20-How-to-get-a-specific-ConnectionString-from-the-WebConfig-by-name.aspx
        var conString = System.Configuration.ConfigurationManager.ConnectionStrings["democonnection"];
        conn.ConnectionString = conString.ConnectionString;
        conn.Open();

        string sql = "insert into HuberUsers2012spb (username, userpass) values (@username, @userpass)";
        System.Data.SqlClient.SqlCommand comm = new System.Data.SqlClient.SqlCommand();
        comm.Connection = conn;
        comm.CommandText = sql;
        comm.Parameters.AddWithValue("@username", txtUsername.Text);
        comm.Parameters.AddWithValue("@userpass", txtPassword.Text);

        comm.ExecuteNonQuery();

        Response.Redirect("default.aspx");
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(Request.Params["a"]) && !IsPostBack)
        {
            if (Request.Params["a"] == "u")
            {
                //I am performing an update!
                btnInsert.Visible = false;
                btnDelete.Visible = false;
                txtUsername.Enabled = false;

                SelectUser();
            }
            else if (Request.Params["a"] == "d")
            {
                //I am performing a delete!
                btnInsert.Visible = false;
                btnUpdate.Visible = false;
                txtUsername.Enabled = false;
                SelectUser();
            }
            else
            {
                //I am performing an insert!
                btnDelete.Visible = false;
                btnUpdate.Visible = false;
            }
        }
    }

    private void SelectUser()
    {
        System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
        //http://pietschsoft.com/post/2005/12/28/ASPNET-20-How-to-get-a-specific-ConnectionString-from-the-WebConfig-by-name.aspx
        var conString = System.Configuration.ConfigurationManager.ConnectionStrings["democonnection"];
        conn.ConnectionString = conString.ConnectionString;
        conn.Open();

        string sql = "select * from HuberUsers2012spb where username = @username";
        System.Data.SqlClient.SqlCommand comm = new System.Data.SqlClient.SqlCommand();
        comm.Connection = conn;
        comm.CommandText = sql;
        comm.Parameters.AddWithValue("@username", Request.Params["k"]);

        System.Data.DataSet ds = new System.Data.DataSet();
        System.Data.SqlClient.SqlDataAdapter da = new System.Data.SqlClient.SqlDataAdapter();
        da.SelectCommand = comm;

        da.Fill(ds);

        txtUsername.Text = ds.Tables[0].Rows[0].ItemArray[0].ToString();
        txtPassword.Text = ds.Tables[0].Rows[0].ItemArray[1].ToString();
    }
    protected void btnUpdate_Click(object sender, EventArgs e)
    {   
        System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
        //http://pietschsoft.com/post/2005/12/28/ASPNET-20-How-to-get-a-specific-ConnectionString-from-the-WebConfig-by-name.aspx
        var conString = System.Configuration.ConfigurationManager.ConnectionStrings["democonnection"];
        conn.ConnectionString = conString.ConnectionString;
        conn.Open();

        string sql = "update HuberUsers2012spb set userpass = @userpass where username = @username";
        System.Data.SqlClient.SqlCommand comm = new System.Data.SqlClient.SqlCommand();
        comm.Connection = conn;
        comm.CommandText = sql;
        comm.Parameters.AddWithValue("@username", txtUsername.Text);
        comm.Parameters.AddWithValue("@userpass", txtPassword.Text);

        comm.ExecuteNonQuery();

        Response.Redirect("selectrepeater.aspx");
    }
    protected void btnDelete_Click(object sender, EventArgs e)
    {
        System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
        //http://pietschsoft.com/post/2005/12/28/ASPNET-20-How-to-get-a-specific-ConnectionString-from-the-WebConfig-by-name.aspx
        var conString = System.Configuration.ConfigurationManager.ConnectionStrings["democonnection"];
        conn.ConnectionString = conString.ConnectionString;
        conn.Open();

        string sql = "delete from HuberUsers2012spb where username = @username";
        System.Data.SqlClient.SqlCommand comm = new System.Data.SqlClient.SqlCommand();
        comm.Connection = conn;
        comm.CommandText = sql;
        comm.Parameters.AddWithValue("@username", txtUsername.Text);

        comm.ExecuteNonQuery();

        Response.Redirect("selectrepeater.aspx");

    }
}