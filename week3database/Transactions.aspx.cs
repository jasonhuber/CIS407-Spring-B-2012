using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class Transactions : System.Web.UI.Page
{
  
    protected void btnGo_Click(object sender, EventArgs e)
    {
        //what I see in the textbox should look like:
        //accountnumber, check#, amount
        //1,123,95
        //1,124,100

        System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
            //http://pietschsoft.com/post/2005/12/28/ASPNET-20-How-to-get-a-specific-ConnectionString-from-the-WebConfig-by-name.aspx
        var conString = System.Configuration.ConfigurationManager.ConnectionStrings["democonnection"];
        conn.ConnectionString = conString.ConnectionString;
        conn.Open();
        
        
        System.Data.SqlClient.SqlCommand comm = new System.Data.SqlClient.SqlCommand();
        comm.Connection = conn;
        System.Data.SqlClient.SqlTransaction trans = conn.BeginTransaction();

        comm.Transaction = trans;

        //http://www.dreamincode.net/forums/topic/111666-reading-from-csv-and-storing-items-in-array/
        string sinput = txtTransactions.Text;
        string[] sarray;

        //this gets each row.
        sarray = sinput.Split((char)126);

        string[] sinnerarray;
        bool error1 = false;
        foreach (string item in sarray)
        {
            string newitem = item.Replace("~", "");

                // now get the account, check, and amount from the row
            sinnerarray = newitem.Split((char)44);
           if (deductfromaccount(sinnerarray[0],sinnerarray[2],comm) <0 && !error1)
	        {
		         //I have received a negative amount!
                //email the user, rollback the transaction.
                System.Net.Mail.MailMessage mailObj = new System.Net.Mail.MailMessage(
                    "admin@mybank.com", "accountholder@mybank.com", "Overdrawn!", "Your account was overdrawn! We rolled back the transaction, so no worries.");
                System.Net.Mail.SmtpClient SMTPServer = new System.Net.Mail.SmtpClient("localhost");
                 //  SMTPServer.Send(mailObj);
               //cannot actually send mail...

               //do the rollback
                   trans.Rollback();

                   error1 = true;
           }

        }
        if (!error1)
        {
            trans.Commit();
        }
        
    }

    public int deductfromaccount(string account, string amount, System.Data.SqlClient.SqlCommand comm)
    {
        //actually remove the amount from the account, check the balance, return the balance
        string sql = "update huber_bankaccounts set balance = balance - @amount where accountnumber = @accountnumber";
        comm.CommandText = sql;
        comm.Parameters.Clear();
        comm.Parameters.AddWithValue("@amount", amount);
        comm.Parameters.AddWithValue("@accountnumber", account);

        comm.ExecuteNonQuery();


        sql = "select balance from huber_bankaccounts where accountnumber = @accountnumber ";

        comm.CommandText = sql;
        comm.Parameters.Clear();
        comm.Parameters.AddWithValue("@accountnumber", account);

        var result = comm.ExecuteScalar();

        if (result != null)
        {
            return int.Parse(result.ToString());
        }
        else
        {
            return -1; // (really an error code) 
        }

        
    }

}