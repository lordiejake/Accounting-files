<%@ WebHandler Language="C#" Class="Handler" %>

using System;
using System.Web;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web.Services;
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]

public class Handler : IHttpHandler {

    SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["dbaseconnection"].ConnectionString);
    public void ProcessRequest(HttpContext context)
    {
        string imageid = context.Request.QueryString["ImID"];
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["dbaseconnection"].ConnectionString);
        conn.Open();
        SqlCommand command = new SqlCommand("SELECT Product_Image from PRODUCT where Product_Num =" + imageid, conn);
        SqlDataReader dr = command.ExecuteReader();
        dr.Read();
        context.Response.BinaryWrite((Byte[])dr[0]);
        conn.Close();
        context.Response.End();
    }

 
    public bool IsReusable {
        get {
            return false;
        }
    }

}