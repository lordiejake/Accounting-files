using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Collections;
using System.Data;
using System.Windows.Forms;

namespace Test
{
    class Class1
    {
        SqlConnection conn = null;
        private ArrayList Studi = new ArrayList();
        public ArrayList STUDI
        {
            get { return Studi; }
            set { Studi = value; }
        }


        private ArrayList Studiz = new ArrayList();
        public ArrayList STUDIz
        {
            get { return Studiz; }
            set { Studiz = value; }
        }


        private ArrayList trialid = new ArrayList();
        public ArrayList TRIALID
        {
            get { return trialid; }
            set { trialid = value; }
        }

        private ArrayList trialidz = new ArrayList();
        public ArrayList TRIALIDz
        {
            get { return trialidz; }
            set { trialidz = value; }
        }

        private double st;
        public double ST 
        {
            get { return st; }
            set { st = value; }
        }

        private double stz;
        public double STz
        {
            get { return stz; }
            set { stz = value; }
        }

        private double trz;
        public double TRz
        {
            get { return trz; }
            set { trz = value; }
        }

        public SqlDataReader AllStudents(SqlConnection conn)
        {
            string sqlSelect = "SELECT  * FROM tbl_Student ORDER BY LastName";
            SqlCommand cmd = new SqlCommand(sqlSelect, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }

        public SqlDataReader RealQuerryHard(SqlConnection conn)
        {
            string sqlSelect = "SELECT     tbl_Student.LastName, tbl_Student.FirstName, tbl_Trial.Trial, tbl_ResultsReports.Items, tbl_ResultsReports.Status, tbl_Category.CategoryName    FROM         tbl_ResultsReports INNER JOIN    tbl_Student ON tbl_ResultsReports.StudID = tbl_Student.StudID INNER JOIN    tbl_Trial ON tbl_ResultsReports.TrialID = tbl_Trial.TrailID INNER JOIN  tbl_Category ON tbl_ResultsReports.CategoryID = tbl_Category.CategoryID    WHERE   (tbl_ResultsReports.CategoryID = 1) AND tbl_ResultsReports.StudID = '" + stz + "' AND tbl_ResultsReports.TrialID = '" + trz  + "'";
            SqlCommand cmd = new SqlCommand(sqlSelect, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }

        public SqlDataReader RealQuerryHard2(SqlConnection conn)
        {
            string sqlSelect = "SELECT     tbl_Student.LastName, tbl_Student.FirstName, tbl_Trial.Trial, tbl_ResultsReports.Items, tbl_ResultsReports.Status, tbl_Category.CategoryName    FROM         tbl_ResultsReports INNER JOIN    tbl_Student ON tbl_ResultsReports.StudID = tbl_Student.StudID INNER JOIN    tbl_Trial ON tbl_ResultsReports.TrialID = tbl_Trial.TrailID INNER JOIN  tbl_Category ON tbl_ResultsReports.CategoryID = tbl_Category.CategoryID    WHERE   (tbl_ResultsReports.CategoryID = 2) AND tbl_ResultsReports.StudID = '" + stz + "' AND tbl_ResultsReports.TrialID = '" + trz + "'";
            SqlCommand cmd = new SqlCommand(sqlSelect, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }

        public SqlDataReader RealQuerryHard3(SqlConnection conn)
        {
            string sqlSelect = "SELECT     tbl_Student.LastName, tbl_Student.FirstName, tbl_Trial.Trial, tbl_ResultsReports.Items, tbl_ResultsReports.Status, tbl_Category.CategoryName    FROM         tbl_ResultsReports INNER JOIN    tbl_Student ON tbl_ResultsReports.StudID = tbl_Student.StudID INNER JOIN    tbl_Trial ON tbl_ResultsReports.TrialID = tbl_Trial.TrailID INNER JOIN  tbl_Category ON tbl_ResultsReports.CategoryID = tbl_Category.CategoryID    WHERE   (tbl_ResultsReports.CategoryID = 3) AND tbl_ResultsReports.StudID = '" + stz + "' AND tbl_ResultsReports.TrialID = '" + trz + "'";
            SqlCommand cmd = new SqlCommand(sqlSelect, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }

        public SqlDataReader AllStudents1(SqlConnection conn)
        {
            string sqlSelect = "SELECT  * FROM tbl_Student ORDER BY LastName";
            SqlCommand cmd = new SqlCommand(sqlSelect, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }

        public SqlDataReader TotalCategory(SqlConnection conn)
        {
            string sqlSelect = "SELECT     tbl_Trial.Trial, tbl_Category.CategoryName, tbl_CategoryFormResults.CategoryScore, tbl_CategoryFormResults.CategoryRatings    FROM         tbl_CategoryFormResults INNER JOIN   tbl_Student ON tbl_CategoryFormResults.StudID = tbl_Student.StudID INNER JOIN   tbl_Trial ON tbl_CategoryFormResults.TrailID = tbl_Trial.TrailID INNER JOIN  tbl_Category ON tbl_CategoryFormResults.CategoryID = tbl_Category.CategoryID  WHERE  tbl_CategoryFormResults.StudID = '" + stz + "' AND tbl_CategoryFormResults.TrailID = '" + trz + "'";
            SqlCommand cmd = new SqlCommand(sqlSelect, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }

        public SqlDataReader TotalCategoryALL(SqlConnection conn)
        {
            string sqlSelect = "SELECT     tbl_Trial.Trial, tbl_OverAllResultsGeneral.OverAllScore, tbl_OverAllResultsGeneral.OverAllRatings, tbl_Student.StudID       FROM         tbl_Student INNER JOIN      tbl_OverAllResultsGeneral ON tbl_Student.StudID = tbl_OverAllResultsGeneral.StudID INNER JOIN   tbl_Trial ON tbl_OverAllResultsGeneral.TrialID = tbl_Trial.TrailID    WHERE  tbl_Student.StudID = '" + stz + "' AND tbl_OverAllResultsGeneral.TrialID = '" + trz + "'";
            SqlCommand cmd = new SqlCommand(sqlSelect, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }

        public SqlDataReader DetectTrial(SqlConnection conn)
        {
            string sqlSelect = "SELECT     tbl_Trial.Trial, tbl_OverAllResultsGeneral.OverAllScore, tbl_OverAllResultsGeneral.OverAllRatings, tbl_Student.StudID       FROM         tbl_Student INNER JOIN      tbl_OverAllResultsGeneral ON tbl_Student.StudID = tbl_OverAllResultsGeneral.StudID INNER JOIN   tbl_Trial ON tbl_OverAllResultsGeneral.TrialID = tbl_Trial.TrailID    WHERE  tbl_Student.StudID = '" + st + "' AND tbl_OverAllResultsGeneral.TrialID = '" + tr + "'";
            SqlCommand cmd = new SqlCommand(sqlSelect, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }

        public SqlDataReader AllStudentsSelect(SqlConnection conn)
        {
            string sqlSelect = "SELECT  * FROM tbl_Student WHERE StudID = '" + st + "'";
            SqlCommand cmd = new SqlCommand(sqlSelect, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }

        public SqlDataReader AllTrials(SqlConnection conn)
        {
            string sqlSelect = "SELECT  * FROM tbl_Trial";
            SqlCommand cmd = new SqlCommand(sqlSelect, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }


        private double tr;
        public double TR
        {
            get { return tr; }
            set { tr = value; }
        }
        public SqlDataReader AllTrialsSELECT(SqlConnection conn)
        {
            string sqlSelect = "SELECT  * FROM tbl_Trial WHERE TrialID = '" + tr + "'";
            SqlCommand cmd = new SqlCommand(sqlSelect, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }


        private double categoryScore;
        private double OverAllScore;
        private string categoryRate;
        private string OverAllRate;


        public double CATEGORYSCORE 
        {
            get { return categoryScore; }
            set { categoryScore = value; }
        }
        public double OVERALLSCORE 
        {
            get { return OverAllScore; }
            set { OverAllScore = value; }
        }
        public string CATEGORYRATE 
        {
            get { return categoryRate; }
            set { categoryRate = value; }
        }
        public string OVERALLRATE
        {
            get { return OverAllRate; }
            set { OverAllRate = value; }
        }

        public void AddRecordsColors(DataGridView grid)
        {
            try
            {
                conn = Connection.ConnectToServer();
                if (conn.State == ConnectionState.Open)
                {
                    for (int i = 0; i < grid.Rows.Count; i++)
                    {
                        string sqlInsertDetails = "INSERT INTO tbl_ResultsReports(StudID,TrialID,CategoryID,Items,Status,BoolStatus,CategoryScore,CategoryRate,OverAllScore,OverAllRate)VALUES(@StudID,@TrialID,@CategoryID,@Items,@Status,@BoolStatus,@CategoryScore,@CategoryRate,@OverAllScore,@OverAllRate)";
                        SqlCommand cmdInsert = new SqlCommand(sqlInsertDetails, conn);
                        cmdInsert.CommandType = CommandType.Text;
                        cmdInsert.Parameters.Add(new SqlParameter("@StudID", double.Parse(st.ToString())));
                        cmdInsert.Parameters.Add(new SqlParameter("@TrialID", double.Parse(tr.ToString())));
                        cmdInsert.Parameters.Add(new SqlParameter("@CategoryID", 1));
                        cmdInsert.Parameters.Add(new SqlParameter("@Items", grid.Rows[i].Cells[0].Value.ToString()));
                        cmdInsert.Parameters.Add(new SqlParameter("@Status", grid.Rows[i].Cells[1].Value.ToString()));
                        cmdInsert.Parameters.Add(new SqlParameter("@BoolStatus", grid.Rows[i].Cells[2].Value.ToString()));
                        cmdInsert.Parameters.Add(new SqlParameter("@CategoryScore", double.Parse(categoryScore.ToString())));
                        cmdInsert.Parameters.Add(new SqlParameter("@CategoryRate", categoryRate.ToString()));
                        cmdInsert.Parameters.Add(new SqlParameter("@OverAllScore", double.Parse(OverAllScore.ToString())));
                        cmdInsert.Parameters.Add(new SqlParameter("@OverAllRate", OverAllRate.ToString()));
                        cmdInsert.ExecuteNonQuery();

                    }
                    MessageBox.Show("Successfully Recorded! NEXT------>");
                   
                }
            }
            catch (Exception)
            {
                //throw;
                DialogResult okay = new DialogResult();
                okay = MessageBox.Show("Select A name/trial Above", "Inventory", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (okay == DialogResult.OK)
                {
                    Application.DoEvents();
                }
            }
            finally { conn.Close(); }
        }

        public void AddRecordsShapes(DataGridView grid)
        {
            try
            {
                conn = Connection.ConnectToServer();
                if (conn.State == ConnectionState.Open)
                {
                    for (int i = 0; i < grid.Rows.Count; i++)
                    {
                        string sqlInsertDetails = "INSERT INTO tbl_ResultsReports(StudID,TrialID,CategoryID,Items,Status,BoolStatus,CategoryScore,CategoryRate,OverAllScore,OverAllRate)VALUES(@StudID,@TrialID,@CategoryID,@Items,@Status,@BoolStatus,@CategoryScore,@CategoryRate,@OverAllScore,@OverAllRate)";
                        SqlCommand cmdInsert = new SqlCommand(sqlInsertDetails, conn);
                        cmdInsert.CommandType = CommandType.Text;
                        cmdInsert.Parameters.Add(new SqlParameter("@StudID", double.Parse(st.ToString())));
                        cmdInsert.Parameters.Add(new SqlParameter("@TrialID", double.Parse(tr.ToString())));
                        cmdInsert.Parameters.Add(new SqlParameter("@CategoryID", 2));
                        cmdInsert.Parameters.Add(new SqlParameter("@Items", grid.Rows[i].Cells[0].Value.ToString()));
                        cmdInsert.Parameters.Add(new SqlParameter("@Status", grid.Rows[i].Cells[1].Value.ToString()));
                        cmdInsert.Parameters.Add(new SqlParameter("@BoolStatus", grid.Rows[i].Cells[2].Value.ToString()));
                        cmdInsert.Parameters.Add(new SqlParameter("@CategoryScore", double.Parse(categoryScore.ToString())));
                        cmdInsert.Parameters.Add(new SqlParameter("@CategoryRate", categoryRate.ToString()));
                        cmdInsert.Parameters.Add(new SqlParameter("@OverAllScore", double.Parse(OverAllScore.ToString())));
                        cmdInsert.Parameters.Add(new SqlParameter("@OverAllRate", OverAllRate.ToString()));
                        cmdInsert.ExecuteNonQuery();

                    }
                    //grid.Rows.Clear();

                }
            }
            catch (Exception)
            {
                //throw;
                DialogResult okay = new DialogResult();
                okay = MessageBox.Show("Select A name/trial Above", "Inventory", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (okay == DialogResult.OK)
                {
                    Application.DoEvents();
                }
            }
            finally { conn.Close(); }
        }

        public void AddRecordsNumbers(DataGridView grid)
        {
            try
            {
                conn = Connection.ConnectToServer();
                if (conn.State == ConnectionState.Open)
                {
                    for (int i = 0; i < grid.Rows.Count; i++)
                    {
                        string sqlInsertDetails = "INSERT INTO tbl_ResultsReports(StudID,TrialID,CategoryID,Items,Status,BoolStatus,CategoryScore,CategoryRate,OverAllScore,OverAllRate)VALUES(@StudID,@TrialID,@CategoryID,@Items,@Status,@BoolStatus,@CategoryScore,@CategoryRate,@OverAllScore,@OverAllRate)";
                        SqlCommand cmdInsert = new SqlCommand(sqlInsertDetails, conn);
                        cmdInsert.CommandType = CommandType.Text;
                        cmdInsert.Parameters.Add(new SqlParameter("@StudID", double.Parse(st.ToString())));
                        cmdInsert.Parameters.Add(new SqlParameter("@TrialID", double.Parse(tr.ToString())));
                        cmdInsert.Parameters.Add(new SqlParameter("@CategoryID", 3));
                        cmdInsert.Parameters.Add(new SqlParameter("@Items", grid.Rows[i].Cells[0].Value.ToString()));
                        cmdInsert.Parameters.Add(new SqlParameter("@Status", grid.Rows[i].Cells[1].Value.ToString()));
                        cmdInsert.Parameters.Add(new SqlParameter("@BoolStatus", grid.Rows[i].Cells[2].Value.ToString()));
                        cmdInsert.Parameters.Add(new SqlParameter("@CategoryScore", double.Parse(categoryScore.ToString())));
                        cmdInsert.Parameters.Add(new SqlParameter("@CategoryRate", categoryRate.ToString()));
                        cmdInsert.Parameters.Add(new SqlParameter("@OverAllScore", double.Parse(OverAllScore.ToString())));
                        cmdInsert.Parameters.Add(new SqlParameter("@OverAllRate", OverAllRate.ToString()));
                        cmdInsert.ExecuteNonQuery();

                    }
                    //grid.Rows.Clear();

                }
            }
            catch (Exception)
            {
                //throw;
                DialogResult okay = new DialogResult();
                okay = MessageBox.Show("Select A name/trial Above", "Inventory", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (okay == DialogResult.OK)
                {
                    Application.DoEvents();
                }
            }
            finally { conn.Close(); }
        }





        public void AddRecordsColorsCATEGORIZED()
        {
            try
            {
                conn = Connection.ConnectToServer();
                if (conn.State == ConnectionState.Open)
                {
                    
                        string sqlInsertDetails = "INSERT INTO tbl_CategoryFormResults(StudID,TrailID,CategoryID,CategoryScore,CategoryRatings)VALUES('" + double.Parse(st.ToString()) + "','" + double.Parse(tr.ToString()) + "','" + 1 + "','" + double.Parse(categoryScore.ToString()) + "','" + categoryRate.ToString() + "')";
                        SqlCommand cmdInsert = new SqlCommand(sqlInsertDetails, conn);
                        cmdInsert.CommandType = CommandType.Text;
                        cmdInsert.ExecuteNonQuery();

                }
            }
            catch (Exception)
            {
                string x = "x";
            }
            finally { conn.Close(); }
        }



        public void AddRecordsShapesCATEGORIZED()
        {
            try
            {
                conn = Connection.ConnectToServer();
                if (conn.State == ConnectionState.Open)
                {

                    string sqlInsertDetails = "INSERT INTO tbl_CategoryFormResults(StudID,TrailID,CategoryID,CategoryScore,CategoryRatings)VALUES('" + double.Parse(st.ToString()) + "','" + double.Parse(tr.ToString()) + "','" + 2 + "','" + double.Parse(categoryScore.ToString()) + "','" + categoryRate.ToString() + "')";
                    SqlCommand cmdInsert = new SqlCommand(sqlInsertDetails, conn);
                    cmdInsert.CommandType = CommandType.Text;
                    cmdInsert.ExecuteNonQuery();

                }
            }
            catch (Exception)
            {
                string x = "x";
            }
            finally { conn.Close(); }
        }

        public void AddRecordsNumbersCATEGORIZED()
        {
            try
            {
                conn = Connection.ConnectToServer();
                if (conn.State == ConnectionState.Open)
                {

                    string sqlInsertDetails = "INSERT INTO tbl_CategoryFormResults(StudID,TrailID,CategoryID,CategoryScore,CategoryRatings)VALUES('" + double.Parse(st.ToString()) + "','" + double.Parse(tr.ToString()) + "','" + 3 + "','" + double.Parse(categoryScore.ToString()) + "','" + categoryRate.ToString() + "')";
                    SqlCommand cmdInsert = new SqlCommand(sqlInsertDetails, conn);
                    cmdInsert.CommandType = CommandType.Text;
                    cmdInsert.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                string x = "x";
            }
            finally { conn.Close(); }
        }




        public void AddRecordsCOLORS_ALL()
        {
            try
            {
                conn = Connection.ConnectToServer();
                if (conn.State == ConnectionState.Open)
                {

                    string sqlInsertDetails = "INSERT INTO tbl_OverAllResultsGeneral(StudID,TrialID,OverAllScore,OverAllRatings)VALUES('" + double.Parse(st.ToString()) + "','" + double.Parse(tr.ToString()) + "','" + double.Parse(OverAllScore.ToString()) + "','" + OverAllRate.ToString() + "')";
                    SqlCommand cmdInsert = new SqlCommand(sqlInsertDetails, conn);
                    cmdInsert.CommandType = CommandType.Text;
                    cmdInsert.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                string x = "x";
            }
            finally { conn.Close(); }
        }

        public void AddRecordsSHAPES_ALL()
        {
            try
            {
                conn = Connection.ConnectToServer();
                if (conn.State == ConnectionState.Open)
                {

                    string sqlInsertDetails = "INSERT INTO tbl_OverAllResultsGeneral(StudID,TrialID,CategoryID,OverAllScore,OverAllRatings)VALUES('" + double.Parse(st.ToString()) + "','" + double.Parse(tr.ToString()) + "','" + 2 + "','" + double.Parse(OverAllScore.ToString()) + "','" + OverAllRate.ToString() + "')";
                    SqlCommand cmdInsert = new SqlCommand(sqlInsertDetails, conn);
                    cmdInsert.CommandType = CommandType.Text;
                    cmdInsert.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                string x = "x";
            }
            finally { conn.Close(); }
        }

        public void AddRecordsNUMBERS_ALL()
        {
            try
            {
                conn = Connection.ConnectToServer();
                if (conn.State == ConnectionState.Open)
                {

                    string sqlInsertDetails = "INSERT INTO tbl_OverAllResultsGeneral(StudID,TrialID,CategoryID,OverAllScore,OverAllRatings)VALUES('" + double.Parse(st.ToString()) + "','" + double.Parse(tr.ToString()) + "','" + 3 + "','" + double.Parse(OverAllScore.ToString()) + "','" + OverAllRate.ToString() + "')";
                    SqlCommand cmdInsert = new SqlCommand(sqlInsertDetails, conn);
                    cmdInsert.CommandType = CommandType.Text;
                    cmdInsert.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                string x = "x";
            }
            finally { conn.Close(); }
        }



        public void AddStudents(DataGridView grid)
        {
            try
            {
                conn = Connection.ConnectToServer();
                if (conn.State == ConnectionState.Open)
                {
                    for (int i = 0; i < grid.Rows.Count; i++)
                    {
                        string sqlInsertDetails = "INSERT INTO tbl_Student(LastName,FirstName,MiddleName,Age)VALUES(@LastName,@FirstName,@MiddleName,@Age)";
                        SqlCommand cmdInsert = new SqlCommand(sqlInsertDetails, conn);
                        cmdInsert.CommandType = CommandType.Text;
                        cmdInsert.Parameters.Add(new SqlParameter("@LastName", grid.Rows[i].Cells[0].Value.ToString()));
                        cmdInsert.Parameters.Add(new SqlParameter("@FirstName", grid.Rows[i].Cells[1].Value.ToString()));
                        cmdInsert.Parameters.Add(new SqlParameter("@MiddleName", grid.Rows[i].Cells[2].Value.ToString()));
                        cmdInsert.Parameters.Add(new SqlParameter("@Age", grid.Rows[i].Cells[3].Value.ToString()));
                        cmdInsert.ExecuteNonQuery();

                    }
                    MessageBox.Show("Successfully Recorded!");
                    grid.Rows.Clear();

                }
            }
            catch (Exception)
            {
                //throw;
                DialogResult okay = new DialogResult();
                okay = MessageBox.Show("Input Is Invalid", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (okay == DialogResult.OK)
                {
                    Application.DoEvents();
                }
            }
            finally { conn.Close(); }
        }
    }
}
