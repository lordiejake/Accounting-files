using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Collections;
using System.IO;
using System.Windows.Forms ; 

namespace OrderManagementSystem
{
    class Class4
    {
        private PictureBox pics = new PictureBox();
        public PictureBox PICS
        {
            get { return pics; }
            set { pics = value; }
        }

        private ArrayList supid = new ArrayList();
        public ArrayList SUPID
        {
            get { return supid; }
            set { supid = value; }
        }

        private string name;

        public string Lname
        {
            get { return name; }
            set { name = value; }
        }
        public SqlDataReader ViewSupplier(SqlConnection conn)
        {
            string sqlSelect = "SELECT * FROM Supplier WHERE SupLN LIKE'" + name +"%'ORDER BY SupLN,SupID";
            SqlCommand cmd = new SqlCommand(sqlSelect, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }

        private double IDsup;
        public double IDSUP
        {
            get { return IDsup; }
            set { IDsup = value; }
        }
        
        public SqlDataReader ViewSupplierBalance(SqlConnection conn)
        {
            string sqlSelect = "SELECT * FROM Supplier WHERE SupID = '" + IDsup+"'";
            SqlCommand cmd = new SqlCommand(sqlSelect, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }

        private double REturnINsales;
        public double RETURNSSALES
        {
            get { return REturnINsales; }
            set { REturnINsales = value; }
        }

        public SqlDataReader ViewCustomerReturns(SqlConnection conn)
        {
            string sqlSelect = "SELECT        SalesData.ProdID, SalesData.ProdDesc, SalesData.ProductRetailPrice, Products.ProdQty, SalesData.NewSalesQty, SalesData.NewAmount,SalesData.SalesNO,SalesData.ExpiryDate,SalesData.SalesDataID,SalesData.ReturnQtyy  FROM            SalesData INNER JOIN    Products ON SalesData.ProdID = Products.ProdID WHERE SalesData.SalesNO = '" + REturnINsales + "'";
            SqlCommand cmd = new SqlCommand(sqlSelect, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }


       

        public SqlDataReader ViewSupplierDelivery(SqlConnection conn)
        {
            string sqlSelect = "SELECT        TOP (100) PERCENT Delivery.Date, Delivery.Total, Delivery.DelID,Supplier.SupID,Delivery.NewTotalD FROM            Delivery INNER JOIN   DeliveryData ON Delivery.DelID = DeliveryData.DelID INNER JOIN    Products ON DeliveryData.ProdID = Products.ProdID INNER JOIN   Supplier ON Delivery.SupID = Supplier.SupID AND DeliveryData.SupID = Supplier.SupID WHERE Supplier.SupID = '" + IDsup + "'GROUP BY Delivery.Total, Delivery.Date, Delivery.Total, Delivery.DelID, Supplier.SupID,Delivery.NewTotalD ORDER BY Delivery.Date";
            SqlCommand cmd = new SqlCommand(sqlSelect, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }

        private ArrayList DeliveryNo = new ArrayList();
        public ArrayList DELIVERYNUM
        {
            get { return DeliveryNo; }
            set { DeliveryNo = value; }
        }

        private double deliveryn;
        public double DELIVERYID
        {
            get { return deliveryn; }
            set { deliveryn = value; }
        }

        public SqlDataReader ViewSupplierDeliveryWithProducts(SqlConnection conn)
        {
            string sqlSelect = "SELECT        TOP (100) PERCENT DeliveryData.DelID, DeliveryData.ProdDesc, DeliveryData.NewSalesQtyy, DeliveryData.NewAmountD, Supplier.SupID,DeliveryData.ProdDprice FROM            Delivery INNER JOIN  DeliveryData ON Delivery.DelID = DeliveryData.DelID INNER JOIN   Products ON DeliveryData.ProdID = Products.ProdID INNER JOIN      Supplier ON Delivery.SupID = Supplier.SupID AND DeliveryData.SupID = Supplier.SupID WHERE DeliveryData.DelID = '" + deliveryn + "'ORDER BY Delivery.Date";
            SqlCommand cmd = new SqlCommand(sqlSelect, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }

        public SqlDataReader ViewSupplierDeliveryTotal(SqlConnection conn)
        {
            string sqlSelect = "SELECT        TOP (100) PERCENT Total,UpdTotal,NewTotalD FROM Delivery WHERE Delivery.DelID ='" + deliveryn + "'";
            SqlCommand cmd = new SqlCommand(sqlSelect, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }



        public SqlDataReader ViewSupplierDeliveryTotalPaids(SqlConnection conn)
        {
            string sqlSelect = "SELECT SUM(Amount) AS Expr1 FROM PayDelData WHERE DelID ='" + deliveryn + "'GROUP BY DelID";
            SqlCommand cmd = new SqlCommand(sqlSelect, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }


        public SqlDataReader ViewhighestReceiptNO(SqlConnection conn)
        {
            string sqlSelect = "SELECT      TOP (1) PaymentsRecID FROM          PaymentsReceipt ORDER BY PaymentsRecID DESC";
            SqlCommand cmd = new SqlCommand(sqlSelect, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }

        
    }
}
