using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.IO;
using System.Data.SqlClient;

public partial class Select_Products_Transactions_CkecksOut : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Load_GridData();
            SearchUserNameDuplicate();

        }

    }

    void Load_GridData()
    {
        double prods = 0;
        string productID = (string)(Session["ProductNum"]);
        prods = double.Parse(productID.ToString());

        //GridView GridImageRetrieve = Article2.ContentPlaceholder.Controls[0].FindControl("GridImageRetrieve") as GridView;
        SqlConnection conn = new System.Data.SqlClient.SqlConnection(ConfigurationManager.ConnectionStrings["dbaseconnection"].ConnectionString);
        SqlCommand command = new SqlCommand("SELECT * FROM PRODUCT WHERE Product_Num = '" + double.Parse(prods.ToString()) + "'", conn);
        SqlDataAdapter daimages = new SqlDataAdapter(command);
        DataTable dt = new DataTable();
        daimages.Fill(dt);
        GridImageRetrieve.DataSource = dt;
        GridImageRetrieve.DataBind();
        GridImageRetrieve.Attributes.Add("bordercolor", "black");
    }

    void SearchUserNameDuplicate()
    {
        try
        {
            double prods = 0;
            string productID = (string)(Session["ProductNum"]);
            prods = double.Parse(productID.ToString());
            SqlConnection conn = ClassConnection.ConnectToServer();
            //Label Label1 = Article1.ContentPlaceholder.Controls[0].FindControl("Label1") as Label; //name
            //Label Label2 = Article1.ContentPlaceholder.Controls[0].FindControl("Label2") as Label;  //description
            //Label Label3 = Article1.ContentPlaceholder.Controls[0].FindControl("Label3") as Label; //price
            //Label Label4 = Article1.ContentPlaceholder.Controls[0].FindControl("Label4") as Label; //status
            SqlCommand command = new SqlCommand("SELECT * FROM PRODUCT WHERE Product_Num = '" + double.Parse(prods.ToString()) + "'", conn);
            SqlDataReader dr = command.ExecuteReader();
            if (dr.HasRows)
            {
                Label1.Text = "[Product Name]";
                Label2.Text = "[Description]";
                Label3.Text = "[Price]";
                Label4.Text = "[Status]";
                while (dr.Read())
                {
                    Label1.Text = "[ " + dr[4].ToString() + " ]";
                    Label2.Text = "[ " + dr[5].ToString() + " ]";
                    Label3.Text = "[ " + dr[6].ToString() + " ]";
                    Label4.Text = "[ " + dr[7].ToString() + " ]";
                    Label5.Text = dr[0].ToString();
                    Label6.Text = (string)(Session["clientID"]);
                    Label7.Text = dr[6].ToString();
                }
            }
            else
            {
                Label1.Text = "[Product Name]";
                Label2.Text = "[Description]";
                Label3.Text = "[Price]";
                Label4.Text = "[Status]";
            }
        }
        catch (Exception)
        {
            Response.Redirect("Default.aspx");
        }
    }


    void SearchProductsDuplicate()
    {
        try
        {
            SqlConnection conn = ClassConnection.ConnectToServer();
            SqlCommand command = new SqlCommand("SELECT * FROM OrderFacts_StoredDatas WHERE Product_Num_stored = '" + double.Parse(Label5.Text) + "'AND Cust_Num = '" + double.Parse(Label6.Text) + "'", conn);
            SqlDataReader dr = command.ExecuteReader();
            if (dr.HasRows)
            {
                
                while (dr.Read())
                {
                    Response.Redirect("Select-Products-Transactions-CkecksOut-Shopping-Cart-Orders.aspx");
                }
            }
            else
            {
                CreateCarts();  
            }
        }
        catch (Exception)
        {
            throw;
            //Response.Redirect("Default.aspx");
        }
    }

    public void CreateCarts()
    {
        try
        {
            double idx = 1;
            SqlConnection conn = ClassConnection.ConnectToServer();
            System.Data.SqlClient.SqlCommand insertCommand = new System.Data.SqlClient.SqlCommand("Insert into [OrderFacts_StoredDatas] (Product_Num_stored,Product_Name_stored,Product_Description_stored,Product_Price_stored,Product_Status_stored,Cust_Num,ProductItemsStored,ProductAmountStored) Values (@Product_Num_stored,@Product_Name_stored,@Product_Description_stored,@Product_Price_stored,@Product_Status_stored,@Cust_Num,@ProductItemsStored,@ProductAmountStored)", conn);
            insertCommand.Parameters.Add(new SqlParameter("@Product_Num_stored", double.Parse(Label5.Text)));// @Product_Price_stored,@Product_Status_stored,@Cust_Num
            insertCommand.Parameters.Add(new SqlParameter("@Product_Name_stored", Label1.Text));
            insertCommand.Parameters.Add(new SqlParameter("@Product_Description_stored", Label2.Text));
            insertCommand.Parameters.Add(new SqlParameter("@Product_Price_stored", double.Parse(Label7.Text)));
            insertCommand.Parameters.Add(new SqlParameter("@Product_Status_stored", Label4.Text));
            insertCommand.Parameters.Add(new SqlParameter("@Cust_Num", double.Parse(Label6.Text)));
            insertCommand.Parameters.Add(new SqlParameter("@ProductItemsStored", idx));
            insertCommand.Parameters.Add(new SqlParameter("@ProductAmountStored", double.Parse(Label7.Text)));

            int queryResult = insertCommand.ExecuteNonQuery();
            if (queryResult == 1)
            {
                Response.Redirect("Select-Products-Transactions-CkecksOut-Shopping-Cart-Orders.aspx");
            }
        }
        catch (Exception)
        {
            throw;
            //Response.Redirect("IndexLogin.aspx");
        }
    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
            if (Session["clientID"] != null)
            {
                SearchProductsDuplicate();
            }
            else
            {
                Response.Redirect("IndexLogin.aspx");
            }
        }
        catch (Exception)
        {
           // Response.Redirect("IndexLogin.aspx");
        }
        
    }
}