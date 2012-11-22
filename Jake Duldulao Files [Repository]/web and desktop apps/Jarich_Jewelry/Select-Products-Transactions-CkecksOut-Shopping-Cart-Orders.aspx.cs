using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

public partial class Select_Products_Transactions_CkecksOut_Shopping_Cart_Orders : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Load_GridData();
        Article3.DataBind();
        if (!IsPostBack)
        {
            DropDownList DropDownCreditCards = Article3.ContentPlaceholder.Controls[0].FindControl("DropDownCreditCards") as DropDownList;
            DropDownCreditCards.Text = "[Select Credit Card]";
            if (Session["clientID"] != null)
            {
                Txtcustomer.Text = (string)(Session["clientID"]);
                SearchCustomerGeneralBalance();
            }
            else 
            {
                Response.Redirect("IndexLogin.aspx");
            }
            
        }
    }

    void Load_GridData()
    {
        string CustomerId = (string)(Session["clientID"]);
        double custid = double.Parse(CustomerId.ToString());
        SqlConnection conn = new System.Data.SqlClient.SqlConnection(ConfigurationManager.ConnectionStrings["dbaseconnection"].ConnectionString);
        SqlCommand command = new SqlCommand("SELECT * FROM OrderFacts_StoredDatas WHERE Cust_Num = '" + double.Parse(custid.ToString()) + "'", conn);
        SqlDataAdapter daimages = new SqlDataAdapter(command);
        DataTable dt = new DataTable();
        daimages.Fill(dt);
        GridImageRetrieve.DataSource = dt;
        GridImageRetrieve.DataBind();
        GridImageRetrieve.Attributes.Add("bordercolor", "black");
    }
    protected void GridImageRetrieve_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        int index = int.Parse(e.CommandArgument.ToString());
        if (e.CommandName.Equals("Select"))
        {
            int cat = int.Parse(GridImageRetrieve.DataKeys[index].Value.ToString());
            //Response.Redirect("Select-Products-Transactions-CkecksOut.aspx?Product_Num=" + int.Parse(GridImageRetrieve.DataKeys[index].Value.ToString()));
            DeleteRecords_Cart(cat);

        }

        if (e.CommandName.Equals("SelectEdit"))
        {
            int cat = int.Parse(GridImageRetrieve.DataKeys[index].Value.ToString());
            SearchCarting(cat);  
        }
    }

    void SearchCarting(double orderFacts_Num)
    {
        try
        {
            SqlConnection conn = ClassConnection.ConnectToServer();
            SqlCommand command = new SqlCommand("SELECT * FROM OrderFacts_StoredDatas WHERE orderFacts_Num = '" + orderFacts_Num + "'", conn);
            SqlDataReader dr = command.ExecuteReader();
            if (dr.HasRows)
            {
                PanelEdit.Visible = false;
                while (dr.Read())
                {
                    PanelEdit.Visible = true;
                    txtorderCartId.Text = dr[0].ToString();
                    LblProductNameEdit.Text = dr[2].ToString();
                    TxtPrice.Text = dr[4].ToString();
                    txtQuantityEdit.Text = dr[7].ToString();
                }
            }
            else
            {
                PanelEdit.Visible = false;
            }
        }
        catch (Exception)
        {
            throw;
            //Response.Redirect("Default.aspx");
        }
    }


    void SearchCustomerGeneralBalance()
    {
        try
        {
            SqlConnection conn = ClassConnection.ConnectToServer();
            SqlCommand command = new SqlCommand("SELECT * FROM CUSTOMER WHERE Cust_Num = '" + double.Parse(Txtcustomer.Text) + "'", conn);
            SqlDataReader dr = command.ExecuteReader();
            if (dr.HasRows)
            {
                
                while (dr.Read())
                {
                    txtcustomerbalanceGeneral.Text = dr["Cust_General_Balance"].ToString();
                }
            }
            else
            {
               
            }
        }
        catch (Exception)
        {
            
        }
    }

    void DeleteRecords_Cart(double orderFacts_Num)
    {
        
        try
        {
            SqlConnection conn = ClassConnection.ConnectToServer();
            System.Data.SqlClient.SqlCommand DeleteCommand = new System.Data.SqlClient.SqlCommand("DELETE FROM OrderFacts_StoredDatas WHERE orderFacts_Num = '" + orderFacts_Num + "'", conn);
            int queryResult = DeleteCommand.ExecuteNonQuery();
            if (queryResult == 1)
            {
                double f = 0;
                try
                {
                    for (int i = 0; i < GridImageRetrieve.Rows.Count; i++)
                    {
                        f = double.Parse(f.ToString()) + Convert.ToDouble(GridImageRetrieve.Rows[i].Cells[7].Text.ToString());
                        lbltotal.Text = f.ToString();

                    }

                }
                catch (Exception)
                {
                    //throw;
                }
                Response.Redirect("Select-Products-Transactions-CkecksOut-Shopping-Cart-Orders.aspx");
            }
        }
        catch (Exception)
        {
            //throw;
        }
    }
    protected void BtnRefresh_Click(object sender, EventArgs e)
    {
            double f = 0;
            try
            {
                for (int i = 0; i < GridImageRetrieve.Rows.Count; i++)
                {
                    f = double.Parse(f.ToString()) + Convert.ToDouble(GridImageRetrieve.Rows[i].Cells[7].Text.ToString());
                    lbltotal.Text = f.ToString();

                }

            }
            catch (Exception)
            {
                //throw;
            }

            try
            {
                double x = double.Parse(lbltotal.Text);
                double y = double.Parse(txtcustomerbalanceGeneral.Text);
                double z = x + y;
                txtcustomerbalanceGeneralFinal.Text = z.ToString();
            }
            catch (Exception)
            {
               
            }
    }

    
    protected void GridImageRetrieve_RowDataBound(object sender, GridViewRowEventArgs e)
    {

    }


    protected void GridImageRetrieve_SelectedIndexChanged(object sender, EventArgs e)
    {
        
    }
    protected void Btnedit_Click(object sender, EventArgs e)
    {
        try
        {
            if (double.Parse(txtQuantityEdit.Text)>0)
            {
                double x = double.Parse(txtQuantityEdit.Text);
                double y = double.Parse(TxtPrice.Text);
                double z = x * y;
                txttotal.Text = z.ToString();
                UpdateCart();
            }
            
        }
        catch (Exception)
        {

        }
    }


    void UpdateCart()
    {
        try
        {
            // double loadedid = double.Parse(iid.ToString());
            SqlConnection conn = ClassConnection.ConnectToServer();
            System.Data.SqlClient.SqlCommand insertCommand = new System.Data.SqlClient.SqlCommand("UPDATE OrderFacts_StoredDatas SET ProductItemsStored ='" + txtQuantityEdit.Text + "', ProductAmountStored = '" + txttotal.Text + "'WHERE orderFacts_Num = '" + txtorderCartId.Text + "'", conn);
            int queryResult = insertCommand.ExecuteNonQuery();
            if (queryResult == 1)
            {
                PanelEdit.Visible = false;
                Response.Redirect("Select-Products-Transactions-CkecksOut-Shopping-Cart-Orders.aspx");
            }
        }
        catch (Exception)
        {
            
        }
    }

    void OrderNum()
    {
        try
        {
            SqlConnection conn = ClassConnection.ConnectToServer();
            SqlCommand command = new SqlCommand("SELECT  TOP (1) Order_Num FROM ORDERGENERAL ORDER BY Order_Num DESC", conn);
            SqlDataReader dr = command.ExecuteReader();
            if (dr.HasRows)
            {

                while (dr.Read())
                {
                    txtOrderNum.Text = dr[0].ToString();
                }
            }
            else
            {

            }
        }
        catch (Exception)
        {

        }
    }

    void DeleteCustomerOrderFacts()
    {

        try
        {
            SqlConnection conn = ClassConnection.ConnectToServer();
            System.Data.SqlClient.SqlCommand DeleteCommand = new System.Data.SqlClient.SqlCommand("DELETE FROM OrderFacts_StoredDatas WHERE  Cust_Num = '" + double.Parse(Txtcustomer.Text) + "'", conn);
            int queryResult = DeleteCommand.ExecuteNonQuery();
            if (queryResult == 1)
            {
               
            }
        }
        catch (Exception)
        {
            //throw;
        }
    }

    void UpdateCustomerBalance()
    {
        try
        {
            // double loadedid = double.Parse(iid.ToString());
            SqlConnection conn = ClassConnection.ConnectToServer();
            System.Data.SqlClient.SqlCommand insertCommand = new System.Data.SqlClient.SqlCommand("UPDATE CUSTOMER SET Cust_General_Balance ='" + double.Parse(txtcustomerbalanceGeneralFinal.Text) + "'WHERE Cust_Num = '" + double.Parse(Txtcustomer.Text) + "'", conn);
            int queryResult = insertCommand.ExecuteNonQuery();
            if (queryResult == 1)
            {
                
            }
        }
        catch (Exception)
        {

        }
    }



    void addItems() 
    {
        try
        {
            SqlConnection conn = ClassConnection.ConnectToServer();
            for (int i = 0; i < GridImageRetrieve.Rows.Count; i++)
            {
                string sqlInsertDetails = "INSERT INTO ORDER_ITEM(Order_Num,Product_Num,Product_Current_Price,Product_Order_Quantity,Percent_Deduction,Total_Amount)VALUES(@Order_Num,@Product_Num,@Product_Current_Price,@Product_Order_Quantity,@Percent_Deduction,@Total_Amount)";
                SqlCommand cmdInsert = new SqlCommand(sqlInsertDetails, conn);
                cmdInsert.CommandType = CommandType.Text;
                cmdInsert.Parameters.Add(new SqlParameter("@Order_Num", double.Parse(txtOrderNum.Text)));
                cmdInsert.Parameters.Add(new SqlParameter("@Product_Num", double.Parse(GridImageRetrieve.Rows[i].Cells[1].Text.ToString())));
                cmdInsert.Parameters.Add(new SqlParameter("@Product_Current_Price", double.Parse(GridImageRetrieve.Rows[i].Cells[4].Text.ToString())));
                cmdInsert.Parameters.Add(new SqlParameter("@Product_Order_Quantity", int.Parse(GridImageRetrieve.Rows[i].Cells[6].Text.ToString())));
                cmdInsert.Parameters.Add(new SqlParameter("@Percent_Deduction", "0.0000"));
                cmdInsert.Parameters.Add(new SqlParameter("@Total_Amount", double.Parse(GridImageRetrieve.Rows[i].Cells[7].Text.ToString())));
                cmdInsert.ExecuteNonQuery();
            }
        }
        catch (Exception)
        {
            
            throw;
        }
    }

    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
            DropDownList DropDownCreditCards = Article3.ContentPlaceholder.Controls[0].FindControl("DropDownCreditCards") as DropDownList;
            TextBox txtvisaValidation = Article3.ContentPlaceholder.Controls[0].FindControl("txtvisaValidation") as TextBox;
            TextBox txtMasterCardNumber = Article3.ContentPlaceholder.Controls[0].FindControl("txtMasterCardNumber") as TextBox;
            TextBox txtAmericanExpressNumber = Article3.ContentPlaceholder.Controls[0].FindControl("txtAmericanExpressNumber") as TextBox;
            Panel Panel1 = Article3.ContentPlaceholder.Controls[0].FindControl("Panel1") as Panel;
            Panel Panel2 = Article3.ContentPlaceholder.Controls[0].FindControl("Panel2") as Panel;
            Panel Panel3 = Article3.ContentPlaceholder.Controls[0].FindControl("Panel3") as Panel;

                SqlConnection conn = ClassConnection.ConnectToServer();
                //tran = conn.BeginTransaction();
                string insert = "INSERT INTO ORDERGENERAL(Cust_Num,Promo_Num,Total_Price,Cust_Order_CurrentBalance,Payment_OrderStatus,Order_Date,CreditCard,CreditCardNum)VALUES(@Cust_Num,@Promo_Num,@Total_Price,@Cust_Order_CurrentBalance,@Payment_OrderStatus,@Order_Date,@CreditCard,@CreditCardNum)";
                SqlCommand cmd = new SqlCommand(insert, conn);
                cmd.Parameters.Add(new SqlParameter("@Cust_Num", double.Parse(Txtcustomer.Text)));
                cmd.Parameters.Add(new SqlParameter("@Promo_Num", "1"));
                cmd.Parameters.Add(new SqlParameter("@Total_Price", double.Parse(lbltotal.Text)));
                cmd.Parameters.Add(new SqlParameter("@Cust_Order_CurrentBalance", double.Parse(lbltotal.Text)));
                cmd.Parameters.Add(new SqlParameter("@Payment_OrderStatus", "Ordered and not yet Paid"));
                cmd.Parameters.Add(new SqlParameter("@Order_Date", DateTime.Now.ToString()));
                cmd.Parameters.Add(new SqlParameter("@CreditCard", DropDownCreditCards.Text));

                if (DropDownCreditCards.Text == "[Visa]")
                {
                    cmd.Parameters.Add(new SqlParameter("@CreditCardNum", txtvisaValidation.Text));
                }
                if (DropDownCreditCards.Text == "[Master Card]")
                {
                    cmd.Parameters.Add(new SqlParameter("@CreditCardNum", txtMasterCardNumber.Text));
                }
                if (DropDownCreditCards.Text == "[American Express]")
                {
                    cmd.Parameters.Add(new SqlParameter("@CreditCardNum", txtAmericanExpressNumber.Text));
                }   

               int queryResult = cmd.ExecuteNonQuery();
               if (queryResult == 1)
               {
                   UpdateCustomerBalance();
                   OrderNum();
                   addItems();
                   DeleteCustomerOrderFacts();

                   txtvisaValidation.Text = null;
                   txtMasterCardNumber.Text = null;
                   txtAmericanExpressNumber.Text = null;
                   lbltotal.Text = "";
                   Panel1.Visible = false;
                   Panel2.Visible = false;
                   Panel3.Visible = false;

                   Response.Redirect("Confirmation.aspx");
                   Panel4.Visible = false;
                   Panel5.Visible = true;
               }
                
           
        }
        catch (Exception)
        {
           
            throw;
        }
        
    }
    protected void DropDownCreditCards_SelectedIndexChanged(object sender, EventArgs e)
    {
        
    }
    protected void btnGo_Click(object sender, EventArgs e)
    {
        Panel Panel1 = Article3.ContentPlaceholder.Controls[0].FindControl("Panel1") as Panel;
        Panel Panel2 = Article3.ContentPlaceholder.Controls[0].FindControl("Panel2") as Panel;
        Panel Panel3 = Article3.ContentPlaceholder.Controls[0].FindControl("Panel3") as Panel;
        DropDownList DropDownCreditCards = Article3.ContentPlaceholder.Controls[0].FindControl("DropDownCreditCards") as DropDownList;

        TextBox txtvisaValidation = Article3.ContentPlaceholder.Controls[0].FindControl("txtvisaValidation") as TextBox;
        TextBox txtMasterCardNumber = Article3.ContentPlaceholder.Controls[0].FindControl("txtMasterCardNumber") as TextBox;
        TextBox txtAmericanExpressNumber = Article3.ContentPlaceholder.Controls[0].FindControl("txtAmericanExpressNumber") as TextBox;

        if (DropDownCreditCards.Text == "[Visa]")
        {
            Panel1.Visible = true;
            Panel2.Visible = false;
            Panel3.Visible = false;

            txtMasterCardNumber.Text = null;
            txtAmericanExpressNumber.Text = null;
        }
        if (DropDownCreditCards.Text == "[Master Card]")
        {
            Panel1.Visible = false;
            Panel2.Visible = true;
            Panel3.Visible = false;

            txtvisaValidation.Text = null;
            txtAmericanExpressNumber.Text = null;

        }
        if (DropDownCreditCards.Text == "[American Express]")
        {
            Panel1.Visible = false;
            Panel2.Visible = false;
            Panel3.Visible = true;

            txtvisaValidation.Text = null;
            txtMasterCardNumber.Text = null;
        }
    }
}