using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Collections.Generic;
using System.Data.SqlClient;

/// <summary>
/// Summary description for ClassDataManager
/// </summary>
public class ClassDataManager
{
	public ClassDataManager()
	{
		//
		// TODO: Add constructor logic here
		//
	}


    public static List<ClassFields> Illness_Load()
    {
        List<ClassFields> list = new List<ClassFields>();
        using (SqlConnection conn = ClassConnection.ConnectToServer())
        {
            string sql = "SELECT * FROM tbl_Illness ORDER BY IllnessName";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.CommandType = CommandType.Text;
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            ClassFields f = new ClassFields();
                            f.IllnessID = long.Parse(dr["IllnessID"].ToString());
                            f.IllnessName = dr["IllnessName"].ToString();
                            list.Add(f);
                        }
                    }
                }
            }
        }
        return list;
    }


    public static List<ClassFields> Illness_LoadSearching(string ill)
    {
        List<ClassFields> list = new List<ClassFields>();
        using (SqlConnection conn = ClassConnection.ConnectToServer())
        {
            string sql = "SELECT IllnessID,IllnessName FROM tbl_Illness WHERE IllnessName LIKE '" + ill + "%'ORDER BY IllnessName";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.CommandType = CommandType.Text;
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            ClassFields f = new ClassFields();
                            f.IllnessID = long.Parse(dr["IllnessID"].ToString());
                            f.IllnessName = dr["IllnessName"].ToString();
                            list.Add(f);
                        }
                    }
                }
            }
        }
        return list;
    }

    public static List<ClassFields> LoadTreatments(double IllnessID)
    {
        List<ClassFields> list = new List<ClassFields>();
        using (SqlConnection conn = ClassConnection.ConnectToServer())
        {
            string sql = "SELECT * FROM tbl_Treatment WHERE IllnessID = '" + IllnessID + "'";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.CommandType = CommandType.Text;
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            ClassFields f = new ClassFields();
                            f.TreatmentDescription = "-->>     " + dr["TreatmentDescription"].ToString();
                            list.Add(f);
                        }
                    }
                    else 
                    {
                        ClassFields f = new ClassFields();
                        f.TreatmentDescription = "Unavailable";
                        list.Add(f);
                    }
                }
            }
        }
        return list;
    }

    public static List<ClassFields> LoadSymptoms(double IllnessID)
    {
        List<ClassFields> list = new List<ClassFields>();
        using (SqlConnection conn = ClassConnection.ConnectToServer())
        {
            string sql = "SELECT        tbl_Illness.IllnessName, tbl_Symptoms.Symptoms, tbl_Illness.IllnessID  FROM            tbl_Illness INNER JOIN tbl_IllnessSymptoms ON tbl_Illness.IllnessID = tbl_IllnessSymptoms.IllnessID INNER JOIN    tbl_Symptoms ON tbl_IllnessSymptoms.SymptomsID = tbl_Symptoms.SymptomsID WHERE tbl_Illness.IllnessID = '" + IllnessID + "'GROUP BY tbl_Illness.IllnessName, tbl_Symptoms.Symptoms, tbl_Illness.IllnessID";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.CommandType = CommandType.Text;
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            ClassFields f = new ClassFields();
                            f.Symptoms = "-->>     " + dr["Symptoms"].ToString();
                            list.Add(f);
                        }
                    }
                    else 
                    {
                        ClassFields f = new ClassFields();
                        f.Symptoms = "Unavailable";
                        list.Add(f);
                    }
                }
            }
        }
        return list;
    }

    public static List<ClassFields> LoadMedicines(double IllnessID)
    {
        List<ClassFields> list = new List<ClassFields>();
        using (SqlConnection conn = ClassConnection.ConnectToServer())
        {
            string sql = "SELECT     tbl_Drugs.DrugID, tbl_Drugs.DrugName, tbl_Drugs.GenericName, tbl_Drugs.BrandName FROM         tbl_DrugIllness INNER JOIN   tbl_Drugs ON tbl_DrugIllness.DrugID = tbl_Drugs.DrugID INNER JOIN  tbl_Illness ON tbl_DrugIllness.IllnessID = tbl_Illness.IllnessID WHERE tbl_DrugIllness.IllnessID = '" + IllnessID + "'";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.CommandType = CommandType.Text;
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            ClassFields f = new ClassFields();
                            f.DrugID = long.Parse(dr["DrugID"].ToString());
                            f.DrugName = dr["DrugName"].ToString();
                            f.GenericName = dr["GenericName"].ToString();
                            f.BrandName = dr["BrandName"].ToString();
                            list.Add(f);
                        }
                    }
                    else
                    {
                        
                    }
                }
            }
        }
        return list;
    }

    public static List<ClassFields> LoadMedicinesSearchings(double IllnessID,string likename)
    {
        List<ClassFields> list = new List<ClassFields>();
        using (SqlConnection conn = ClassConnection.ConnectToServer())
        {
            string sql = "SELECT     TOP (100) PERCENT tbl_Drugs.DrugID, tbl_Drugs.DrugName, tbl_Drugs.GenericName, tbl_Drugs.BrandName  FROM         tbl_Drugs INNER JOIN  tbl_DrugIllness ON tbl_Drugs.DrugID = tbl_DrugIllness.DrugID INNER JOIN  tbl_Illness ON tbl_DrugIllness.IllnessID = tbl_Illness.IllnessID   WHERE tbl_DrugIllness.IllnessID =  '" + IllnessID + "'AND tbl_Drugs.DrugName LIKE '" + likename + "%'ORDER BY tbl_Drugs.DrugName";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.CommandType = CommandType.Text;
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            ClassFields f = new ClassFields();
                            f.DrugID = long.Parse(dr["DrugID"].ToString());
                            f.DrugName = dr["DrugName"].ToString();
                            f.GenericName = dr["GenericName"].ToString();
                            f.BrandName = dr["BrandName"].ToString();
                            list.Add(f);
                        }
                    }
                    else
                    {

                    }
                }
            }
        }
        return list;
    }


    public static List<ClassFields> AllDrugz()
    {
        List<ClassFields> list = new List<ClassFields>();
        using (SqlConnection conn = ClassConnection.ConnectToServer())
        {
            string sql = "SELECT  * FROM tbl_Drugs ORDER BY DrugName";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.CommandType = CommandType.Text;
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            ClassFields f = new ClassFields();
                            f.DrugID = long.Parse(dr["DrugID"].ToString());
                            f.DrugName = dr["DrugName"].ToString();
                            f.GenericName = dr["GenericName"].ToString();
                            f.BrandName = dr["BrandName"].ToString();
                            list.Add(f);
                        }
                    }
                    else
                    {

                    }
                }
            }
        }
        return list;
    }


    public static List<ClassFields> AllDrugzSearch(string names)
    {
        List<ClassFields> list = new List<ClassFields>();
        using (SqlConnection conn = ClassConnection.ConnectToServer())
        {
            string sql = "SELECT * FROM tbl_Drugs WHERE DrugName LIKE '" + names + "%'ORDER BY DrugName";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.CommandType = CommandType.Text;
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            ClassFields f = new ClassFields();
                            f.DrugID = long.Parse(dr["DrugID"].ToString());
                            f.DrugName = dr["DrugName"].ToString();
                            f.GenericName = dr["GenericName"].ToString();
                            f.BrandName = dr["BrandName"].ToString();
                            list.Add(f);
                        }
                    }
                    else
                    {
                        ClassFields f = new ClassFields();
                       // f.DrugID = long.Parse(dr["DrugID"].ToString());
                        f.DrugName = "No results Found.";
                     
                        list.Add(f);
                    }
                }
            }
        }
        return list;
    }


    public static List<ClassFields> LoadSideEffects(double DrugIDs)
    {
        List<ClassFields> list = new List<ClassFields>();
        using (SqlConnection conn = ClassConnection.ConnectToServer())
        {
            string sql = "SELECT     tbl_Drugs.DrugID, tbl_Drugs.DrugName, tbl_SideEffects.SideEffectsID AS Expr1, tbl_SideEffects.SideEffects  FROM         tbl_drugSideEffects INNER JOIN  tbl_Drugs ON tbl_drugSideEffects.DrugID = tbl_Drugs.DrugID INNER JOIN   tbl_SideEffects ON tbl_drugSideEffects.SideEffectsID = tbl_SideEffects.SideEffectsID WHERE tbl_drugSideEffects.DrugID = '" + DrugIDs + "'";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.CommandType = CommandType.Text;
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            ClassFields f = new ClassFields();
                            f.SideEffects = dr["SideEffects"].ToString();
                            list.Add(f);
                        }
                    }
                    else
                    {

                    }
                }
            }
        }
        return list;
    }


    public static List<ClassFields> LoadDosage(double DrugIDs)
    {
        List<ClassFields> list = new List<ClassFields>();
        using (SqlConnection conn = ClassConnection.ConnectToServer())
        {
            string sql = "SELECT     tbl_Drugs.DrugName, tbl_Dosage.Dosage, tbl_Dosage.DosageID, tbl_Drugs.DrugID  FROM         tbl_Dosage INNER JOIN  tbl_DosageDrugs ON tbl_Dosage.DosageID = tbl_DosageDrugs.DosageID INNER JOIN       tbl_Drugs ON tbl_DosageDrugs.DrugID = tbl_Drugs.DrugID WHERE tbl_DosageDrugs.DrugID = '" + DrugIDs + "'";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.CommandType = CommandType.Text;
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            ClassFields f = new ClassFields();
                            f.Dosage = dr["Dosage"].ToString();
                            list.Add(f);
                        }
                    }
                    else
                    {

                    }
                }
            }
        }
        return list;
    }


    public static List<ClassFields> FormsAvailable(double DrugIDs)
    {
        List<ClassFields> list = new List<ClassFields>();
        using (SqlConnection conn = ClassConnection.ConnectToServer())
        {
            string sql = "SELECT     tbl_Drugs.DrugName, tbl_AvailableForms.AvailableForms   FROM         tbl_AvailableForms INNER JOIN    tbl_AvailableFormsDrugs ON tbl_AvailableForms.FormsID = tbl_AvailableFormsDrugs.FormsID INNER JOIN      tbl_Drugs ON tbl_AvailableFormsDrugs.DrugID = tbl_Drugs.DrugID    WHERE tbl_AvailableFormsDrugs.DrugID = '" + DrugIDs + "'";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.CommandType = CommandType.Text;
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            ClassFields f = new ClassFields();
                            f.AvailableForms = dr["AvailableForms"].ToString();
                            list.Add(f);
                        }
                    }
                    else
                    {
                        ClassFields f = new ClassFields();
                        f.AvailableForms = "On progress";
                        list.Add(f);
                    }
                }
            }
        }
        return list;
    }


    public static List<ClassFields> LoadDrugClass(double DrugIDs)
    {
        List<ClassFields> list = new List<ClassFields>();
        using (SqlConnection conn = ClassConnection.ConnectToServer())
        {
            string sql = "SELECT     tbl_DrugClass.drugClass  FROM         tbl_Drugs INNER JOIN  tbl_MedicineDrugClass ON tbl_Drugs.DrugID = tbl_MedicineDrugClass.DrugID INNER JOIN    tbl_DrugClass ON tbl_MedicineDrugClass.DrugclassID = tbl_DrugClass.DrugclassID WHERE tbl_Drugs.DrugID = '" + DrugIDs + "'";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.CommandType = CommandType.Text;
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            ClassFields f = new ClassFields();
                            f.drugClass = ">>" + dr["drugClass"].ToString();
                            list.Add(f);
                        }
                    }
                    else
                    {
                        ClassFields f = new ClassFields();
                        f.drugClass = "--";
                        list.Add(f);
                    }
                }
            }
        }
        return list;
    }


}
