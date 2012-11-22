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
using System.IO;

public partial class Admin_Control_Panel_IndexProductsDescriptionsPanel : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Article2.DataBind();
        if (!IsPostBack)
        {
            PopulateAllCategories();
            PopulateAllGenderType();
            PopulateAllCollectionsCategory();
        }
    }


    protected void btnCreate_Click(object sender, EventArgs e)
    {
        PopulateAllCategoriesID();
        PopulateAllGenderTypeID();
        PopulateAllCollectionsCategoryID();

        try
        {
            TextBox txtprice = Article2.ContentPlaceholder.Controls[0].FindControl("txtprice") as TextBox;
            if (double.Parse(txtprice.Text) >= 0)
            {
                CreateProducts();
            }
            else
            {
                Panel CategoryExistsPanel = Article2.ContentPlaceholder.Controls[0].FindControl("CategoryExistsPanel") as Panel;
                Panel CategoryAdded = Article2.ContentPlaceholder.Controls[0].FindControl("CategoryAdded") as Panel;

                CategoryExistsPanel.Visible = true;
                CategoryAdded.Visible = false;
            }

        }
        catch (Exception)
        {
            Panel CategoryExistsPanel = Article2.ContentPlaceholder.Controls[0].FindControl("CategoryExistsPanel") as Panel;
            Panel CategoryAdded = Article2.ContentPlaceholder.Controls[0].FindControl("CategoryAdded") as Panel;

            CategoryExistsPanel.Visible = true;
            CategoryAdded.Visible = false;
        }

        
    }

    void PopulateAllCategories()
    {
        try
        {
            SqlConnection conn = ClassConnection.ConnectToServer();
            DropDownList DrpCategory = Article2.ContentPlaceholder.Controls[0].FindControl("DrpCategory") as DropDownList;
            SqlCommand command = new SqlCommand("SELECT * FROM CATEGORY ORDER BY CategoryName", conn); 
            SqlDataReader dr = command.ExecuteReader();
            if (dr.HasRows)
            {
                DrpCategory.Items.Clear();
                while (dr.Read())
                {
                    DrpCategory.Items.Add(dr["CategoryName"].ToString());
                }
            }
            else
            {
                DrpCategory.Items.Clear();
            }
        }
        catch (Exception)
        {

        }
    }

    void PopulateAllGenderType()
    {
        try
        {
            SqlConnection conn = ClassConnection.ConnectToServer();
            DropDownList DrpGender = Article2.ContentPlaceholder.Controls[0].FindControl("DrpGender") as DropDownList;
            SqlCommand command = new SqlCommand("SELECT * FROM GENDERCATEGORY ORDER BY GenderType", conn);
            SqlDataReader dr = command.ExecuteReader();
            if (dr.HasRows)
            {
                DrpGender.Items.Clear();
                while (dr.Read())
                {
                    DrpGender.Items.Add(dr["GenderType"].ToString());
                }
            }
            else
            {
                DrpGender.Items.Clear();
            }
        }
        catch (Exception)
        {

        }
    }

    void PopulateAllCollectionsCategory()
    {
        try
        {
            SqlConnection conn = ClassConnection.ConnectToServer();
            DropDownList DrpCollections = Article2.ContentPlaceholder.Controls[0].FindControl("DrpCollections") as DropDownList;
            SqlCommand command = new SqlCommand("SELECT * FROM COLLECTIONCATEGORY ORDER BY CollectionDescription", conn);
            SqlDataReader dr = command.ExecuteReader();
            if (dr.HasRows)
            {
                DrpCollections.Items.Clear();
                while (dr.Read())
                {
                    DrpCollections.Items.Add(dr["CollectionDescription"].ToString());
                }
            }
            else
            {
                DrpCollections.Items.Clear();
            }
        }
        catch (Exception)
        {

        }
    }


    //gENERATE Id Area;



    void PopulateAllCategoriesID()
    {
        Label lblcat = Article2.ContentPlaceholder.Controls[0].FindControl("lblcat") as Label;
        try
        {
            SqlConnection conn = ClassConnection.ConnectToServer();
            DropDownList DrpCategory = Article2.ContentPlaceholder.Controls[0].FindControl("DrpCategory") as DropDownList;
            SqlCommand command = new SqlCommand("SELECT * FROM CATEGORY WHERE CategoryName = '" + DrpCategory.Text + "'", conn);
            SqlDataReader dr = command.ExecuteReader();
            if (dr.HasRows)
            {
                lblcat.Text = string.Empty;
                while (dr.Read())
                {
                    lblcat.Text = dr[0].ToString();
                }
            }
            else
            {
                lblcat.Text = string.Empty;
            }
        }
        catch (Exception)
        {

        }
    }

    void PopulateAllGenderTypeID()
    {
        Label lblgender = Article2.ContentPlaceholder.Controls[0].FindControl("lblgender") as Label;
        try
        {
            SqlConnection conn = ClassConnection.ConnectToServer();
            DropDownList DrpGender = Article2.ContentPlaceholder.Controls[0].FindControl("DrpGender") as DropDownList;
            SqlCommand command = new SqlCommand("SELECT * FROM GENDERCATEGORY WHERE GenderType = '" + DrpGender.Text + "'", conn);
            SqlDataReader dr = command.ExecuteReader();
            if (dr.HasRows)
            {
                lblgender.Text = string.Empty;
                while (dr.Read())
                {
                    lblgender.Text = dr[0].ToString();
                }
            }
            else
            {
                lblgender.Text = string.Empty;
            }
        }
        catch (Exception)
        {

        }
    }

    void PopulateAllCollectionsCategoryID()
    {
        Label lblcollection = Article2.ContentPlaceholder.Controls[0].FindControl("lblcollection") as Label;

        try
        {
            SqlConnection conn = ClassConnection.ConnectToServer();
            DropDownList DrpCollections = Article2.ContentPlaceholder.Controls[0].FindControl("DrpCollections") as DropDownList;
            SqlCommand command = new SqlCommand("SELECT * FROM COLLECTIONCATEGORY WHERE CollectionDescription = '" + DrpCollections.Text + "'", conn);
            SqlDataReader dr = command.ExecuteReader();
            if (dr.HasRows)
            {
                lblcollection.Text = string.Empty;
                while (dr.Read())
                {
                    lblcollection.Text = dr[0].ToString();
                }
            }
            else
            {
                lblcollection.Text = string.Empty;
            }
        }
        catch (Exception)
        {

        }
    }


    private byte[] ConvertImageToByteArray(System.Drawing.Image imageToConvert, System.Drawing.Imaging.ImageFormat formatOfImage)
    {
        byte[] Ret;
        try
        {
            using (MemoryStream ms = new MemoryStream())
            {
                imageToConvert.Save(ms, formatOfImage);
                Ret = ms.ToArray();
            }
        }
        catch (Exception) { throw; }
        return Ret;
    }

    public void CreateProducts()
    {
        try
        {
            TextBox txtproduct = Article2.ContentPlaceholder.Controls[0].FindControl("txtproduct") as TextBox;
            TextBox txtdescription = Article2.ContentPlaceholder.Controls[0].FindControl("txtdescription") as TextBox;
            TextBox txtprice = Article2.ContentPlaceholder.Controls[0].FindControl("txtprice") as TextBox;
            TextBox txtstatus = Article2.ContentPlaceholder.Controls[0].FindControl("txtstatus") as TextBox;
            FileUpload ImageUpload = Article2.ContentPlaceholder.Controls[0].FindControl("ImageUpload") as FileUpload;
            System.Drawing.Image imag = System.Drawing.Image.FromStream( ImageUpload.PostedFile.InputStream);
            Label lblcat = Article2.ContentPlaceholder.Controls[0].FindControl("lblcat") as Label;
            Label lblgender = Article2.ContentPlaceholder.Controls[0].FindControl("lblgender") as Label;
            Label lblcollection = Article2.ContentPlaceholder.Controls[0].FindControl("lblcollection") as Label;
            
            SqlConnection conn = ClassConnection.ConnectToServer();
            System.Data.SqlClient.SqlCommand insertCommand = new System.Data.SqlClient.SqlCommand("Insert into [PRODUCT] (Category_Num,GenderCategory_Num,Collection_Num,Product_Name,Product_UpdatedDescription,Product_UpdatedPrice,Product_Status,Product_Image) Values (@Category_Num,@GenderCategory_Num,@Collection_Num,@Product_Name,@Product_UpdatedDescription,@Product_UpdatedPrice,@Product_Status,@Product_Image)", conn);
            insertCommand.Parameters.Add(new SqlParameter("@Category_Num", lblcat.Text));
            insertCommand.Parameters.Add(new SqlParameter("@GenderCategory_Num", lblgender.Text));
            insertCommand.Parameters.Add(new SqlParameter("@Collection_Num", lblcollection.Text));
            insertCommand.Parameters.Add(new SqlParameter("@Product_Name", txtproduct.Text));
            insertCommand.Parameters.Add(new SqlParameter("@Product_UpdatedDescription", txtdescription.Text));
            insertCommand.Parameters.Add(new SqlParameter("@Product_UpdatedPrice", double.Parse(txtprice.Text)));
            insertCommand.Parameters.Add(new SqlParameter("@Product_Status", txtstatus.Text));
            insertCommand.Parameters.Add("Product_Image", SqlDbType.Image, 0).Value = ConvertImageToByteArray(imag, System.Drawing.Imaging.ImageFormat.Jpeg);
            int queryResult = insertCommand.ExecuteNonQuery();
            if (queryResult == 1)
            {
                Panel CategoryExistsPanel = Article2.ContentPlaceholder.Controls[0].FindControl("CategoryExistsPanel") as Panel;
                Panel CategoryAdded = Article2.ContentPlaceholder.Controls[0].FindControl("CategoryAdded") as Panel;

                CategoryExistsPanel.Visible = false;
                CategoryAdded.Visible = true;

                //txtdescription.Text = string.Empty;
                //txtprice.Text = string.Empty;
                //txtproduct.Text = string.Empty;
                //txtstatus.Text = string.Empty;
                //lblcat.Text = null;
                //lblcollection.Text = null;
                //lblgender.Text = null;
            }
        }
        catch (Exception)
        {

            throw;
        }
    }
}