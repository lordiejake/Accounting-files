using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Collections;
using System.Data; 

namespace OrderManagementSystem
{
    class Class3
    {
        SqlConnection conn = new SqlConnection(@"Server=.\sqlexpress;Database=Ordering;Trusted_Connection=Yes");
        private ArrayList supid = new ArrayList();
        private double sup;
        double zero = 0;

        public double ID
        {
            get { return sup; }
            set { sup = value; }
        }

        public ArrayList SUPIDD
        {
            get { return supid; }
            set { supid = value; }
        }

        public SqlDataReader EmployeeUsers(SqlConnection conn)
        {
            string sqlSelect = "SELECT * FROM Employee";
            SqlCommand cmd = new SqlCommand(sqlSelect, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }

        public SqlDataReader SearchSupplier(SqlConnection conn)
        {
            string sqlSelect = "SELECT * FROM Supplier ORDER BY SupLN,SupID";
            SqlCommand cmd = new SqlCommand(sqlSelect, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }

        private string cde;

        public string codesss
        {
            get { return cde; }
            set { cde = value; }
        }

        public SqlDataReader coding(SqlConnection conn)
        {
            string sqlSelect = "SELECT * FROM Codes WHERE Code = '" + cde + "'";
            SqlCommand cmd = new SqlCommand(sqlSelect, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }

        public SqlDataReader Warnings(SqlConnection conn)
        {
            string sqlSelect = "SELECT TOP (100) PERCENT ProdDesc, ProdQty, MinQty FROM Products WHERE  (MinQty > ProdQty) ORDER BY ProdDesc";
            SqlCommand cmd = new SqlCommand(sqlSelect, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }


        public SqlDataReader SearchSupplierID(SqlConnection conn)
        {
            string sqlSelect = "SELECT        TOP (100) PERCENT PO.Date, Products.ProdDesc, Products.ProdDPrice, POData.Qty, PO.Total FROM            PO INNER JOIN POData ON PO.POnum = POData.POnum INNER JOIN  Supplier ON PO.SupID = Supplier.SupID AND POData.SupID = Supplier.SupID INNER JOIN Products ON POData.ProdID = Products.ProdID WHERE Supplier.SupID = '" + sup + "'ORDER BY PO.Date";
            SqlCommand cmd = new SqlCommand(sqlSelect, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }

        public SqlDataReader count(SqlConnection conn)
        {
            string sqlSelect = "SELECT COUNT(ProdID) AS t FROM Products";
            SqlCommand cmd = new SqlCommand(sqlSelect, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }

        private double ProductSupplierID;

        public double PRODUCTs_SUPPLIERID
        {
            get { return ProductSupplierID; }
            set { ProductSupplierID = value; }
        }
        public SqlDataReader ClickSupplier(SqlConnection conn)
        {
            string sqlSelect = "SELECT     dbo.Supplier.SupLN, dbo.Supplier.SupFN, dbo.Supplier.SupCompany, dbo.Products.ProdID, dbo.Products.ProdDesc, dbo.DeliveryData.SalesQty,    dbo.Delivery.Date   FROM         dbo.Supplier INNER JOIN        dbo.Delivery ON dbo.Supplier.SupID = dbo.Delivery.SupID INNER JOIN  dbo.DeliveryData ON dbo.Supplier.SupID = dbo.DeliveryData.SupID AND dbo.Delivery.DelID = dbo.DeliveryData.DelID INNER JOIN     dbo.Products ON dbo.DeliveryData.ProdID = dbo.Products.ProdID  WHERE Products.ProdID = '" + ProductSupplierID + "'";
            SqlCommand cmd = new SqlCommand(sqlSelect, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }


        public SqlDataReader countAll(SqlConnection conn)
        {
            string sqlSelect = "SELECT COUNT(ProdID) AS t FROM Products";
            SqlCommand cmd = new SqlCommand(sqlSelect, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }

        public SqlDataReader countZero(SqlConnection conn)
        {
            string sqlSelect = "SELECT        COUNT(ProdID) AS Expr1 FROM Products WHERE (ProdQty = 0)";
            SqlCommand cmd = new SqlCommand(sqlSelect, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }

        private double ii;
        public double IDe
        {
            get { return ii; }
            set { ii = value; }
        }
        public SqlDataReader countORDERS(SqlConnection conn)
        {
            string sqlSelect = "SELECT        COUNT(PO.POnum) AS Expr1, Products.ProdDesc FROM            PO INNER JOIN       POData ON PO.POnum = POData.POnum INNER JOIN   Products ON POData.ProdID = Products.ProdID WHERE Products.ProdID = '" + ii + "'GROUP BY Products.ProdDesc";
            SqlCommand cmd = new SqlCommand(sqlSelect, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }

        public SqlDataReader ZeroQuantity(SqlConnection conn)
        {
            string sqlSelect = "SELECT * FROM Products WHERE (ProdQty = 0)";
            SqlCommand cmd = new SqlCommand(sqlSelect, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }

        private string lastname = "";
        private string firstname = "";
        private double Min;
        private string contactss = "";
        private string adddresss = "";
        private double IDCustomer;

        public double CUSTOMERid
        {
            get { return IDCustomer; }
            set { IDCustomer = value; }
        }

        public double MINI
        {
            get { return Min; }
            set { Min = value; }
        } 

        public string LAST
        {
            get { return lastname; }
            set { lastname = value; }
        }

        public string FIRST
        {
            get { return firstname; }
            set { firstname = value; }
        }

        public string CONTACT
        {
            get { return contactss; }
            set { contactss = value; }
        }


        public string ADDRESS
        {
            get { return adddresss; }
            set { adddresss = value; }
        }


        public void UpdateCustomerInformation(SqlConnection conn)
        {
            string SqlSelect = "UPDATE Customer SET CustLN = '" + lastname + "',CustFN='" + firstname + "',CustPhone='" + contactss + "',CustAddress='" + adddresss + "',CustLimit='" + Min + "'WHERE CustID='" + IDCustomer + "'";
            SqlCommand cmd = new SqlCommand(SqlSelect, conn);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
        }

        //============================================================================================================================ ================= =                             ===========

        private double Empidd;
        private string last;
        private string first;
        private double rate;
        private string empstat;
        private string phon;
        private string stat;
        private string userN;
        private string passw;
        private string strtNum;
        private string citii;
        private string stateee;
        private string zipcodes;

        public double EmpIDDd
        {
            get { return Empidd; }
            set { Empidd = value; }
        }

        public string last1
        {
            get { return last; }
            set { last = value; }
        }

        public string first1
        {
            get { return first; }
            set { first = value; }
        }

        public double rate1
        {
            get { return rate; }
            set { rate = value; }
        }

        public string empstat1
        {
            get { return empstat; }
            set { empstat = value; }
        }

        public string phon1
        {
            get { return phon; }
            set { phon = value; }
        }

        public string stat1
        {
            get { return stat; }
            set { stat = value; }
        }

        public string userN1
        {
            get { return userN; }
            set { userN = value; }
        }

        public string passW1
        {
            get { return passw; }
            set { passw = value; }
        }

        public string strtnum1
        {
            get { return strtNum; }
            set { strtNum = value; }
        }

        public string citii1
        {
            get { return citii; }
            set { citii = value; }
        }

        public string statee1
        {
            get { return stateee; }
            set { stateee = value; }
        }

        public string zipcodes1
        {
            get { return zipcodes; }
            set { zipcodes = value; }
        }

        public void UpdateEmployeeInformation(SqlConnection conn)
        {
            string SqlSelect = "UPDATE Employee SET EmpLN = '" + last + "',EmpFN='" + first + "',EmpRate='" + rate + "',EmpStatus='" + empstat + "',Phone='" + phon + "',Status='" + stat + "',UserName='" + userN + "',Password='" + passw + "',NumberStreet='" + strtNum + "',city='" + citii + "',state='" + stateee + "',zipcode='" + zipcodes + "'WHERE EmpID='" + Empidd + "'";
            SqlCommand cmd = new SqlCommand(SqlSelect, conn);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
        }

    }
}
