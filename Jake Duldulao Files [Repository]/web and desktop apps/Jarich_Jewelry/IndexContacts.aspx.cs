using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

public partial class IndexContacts : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {



    }


    protected void Button1_Click(object sender, EventArgs e)
    {
        TextBox TextBox1 = Article1.ContentPlaceholder.Controls[0].FindControl("txtname") as TextBox;
        TextBox TextBox2 = Article1.ContentPlaceholder.Controls[0].FindControl("txtcompany") as TextBox;
        TextBox TextBox3 = Article1.ContentPlaceholder.Controls[0].FindControl("txtaddress") as TextBox;
        TextBox TextBox4 = Article1.ContentPlaceholder.Controls[0].FindControl("txtmobilenumber") as TextBox;
        TextBox TextBox5 = Article1.ContentPlaceholder.Controls[0].FindControl("txtemailadd") as TextBox;
        TextBox TextBox6 = Article1.ContentPlaceholder.Controls[0].FindControl("txtmessage") as TextBox;
        SqlConnection conn = ClassConnection.ConnectToServer();
        System.Data.SqlClient.SqlCommand insertCommand = new System.Data.SqlClient.SqlCommand("Insert into [CONTACT] (inq_num,name,company,address,mobileNumer,emailAddress,message) Values (@inq_num,@name,@company,@address,@mobileNumber,@emailAddress,@message)", conn);
        insertCommand.Parameters.Add(new SqlParameter("@name", TextBox1.Text));
        insertCommand.Parameters.Add(new SqlParameter("@company", TextBox1.Text));
        insertCommand.Parameters.Add(new SqlParameter("@address", TextBox1.Text));
        insertCommand.Parameters.Add(new SqlParameter("@mobileNumber", TextBox1.Text));
        insertCommand.Parameters.Add(new SqlParameter("@emailAddress", TextBox1.Text));
        insertCommand.Parameters.Add(new SqlParameter("@emailAddress", TextBox1.Text));
       
    }
}