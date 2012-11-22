using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Test
{
    public partial class Form1 : Form
    {
        SqlConnection conn = null;
        Class1 del = new Class1();
        double colornumber1 = 0;
        double colornumber2 = 0;
        double colornumber3 = 0;
        double colornumber4 = 0;
        double colornumber5 = 0;
        double colornumber6 = 0;
        double colornumber7 = 0;
        double colornumber8 = 0;
        double colornumber9 = 0;
        double colornumber10 = 0;
        double colors;

        string fina = "";

        double acolornumber1 = 0;
        double acolornumber2 = 0;
        double acolornumber3 = 0;
        double acolornumber4 = 0;
        double acolornumber5 = 0;
        double acolornumber6 = 0;
        double acolornumber7 = 0;
        double acolornumber8 = 0;
        double acolornumber9 = 0;
        double acolornumber10 = 0;
        double acolors;

        double ncolornumber1 = 0;
        double ncolornumber2 = 0;
        double ncolornumber3 = 0;
        double ncolornumber4 = 0;
        double ncolornumber5 = 0;
        double ncolornumber6 = 0;
        double ncolornumber7 = 0;
        double ncolornumber8 = 0;
        double ncolornumber9 = 0;
        double ncolornumber10 = 0;
        double ncolors;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                conn = Connection.ConnectToServer();
                if (conn.State == ConnectionState.Open)
                {
                    SqlDataReader dr = del.AllStudents(conn);
                    if (dr.HasRows)
                    {
                        comboBox1.Items.Clear();
                        del.STUDI.Clear();
                        while (dr.Read())
                        {
                            comboBox1.Items.Add(dr[1].ToString() + ", " + dr[2].ToString() + " " + dr[3].ToString() + ".");
                            del.STUDI.Add(dr[0]);
                        }
                    }
                    else 
                    {
                        comboBox1.Items.Clear();
                        del.STUDI.Clear();
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally { conn.Close(); }

            try
            {
                conn = Connection.ConnectToServer();
                if (conn.State == ConnectionState.Open)
                {
                    SqlDataReader dr = del.AllTrials(conn);
                    if (dr.HasRows)
                    {
                        comboBox2.Items.Clear();
                        del.TRIALID.Clear();
                        while (dr.Read())
                        {
                            comboBox2.Items.Add(dr[1].ToString());
                            del.TRIALID.Add(dr[0]);
                        }
                    }
                    else
                    {
                        comboBox2.Items.Clear();
                        del.TRIALID.Clear();
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally { conn.Close(); }

            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            groupBox2.BringToFront();
            groupBox3.SendToBack();
        }

        private void pictureBox26_Click(object sender, EventArgs e)
        {
            pictureBox43.Visible = true;
            pictureBox44.Visible = false;
            pictureBox188.Visible = false;
            pictureBox187.Visible = false;
            colornumber1 = 1;
        }

        private void pictureBox25_Click(object sender, EventArgs e)
        {
            pictureBox43.Visible = false;
            colornumber1 = 0;
            pictureBox44.Visible = true;
            pictureBox188.Visible = false;
            pictureBox187.Visible = false;
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            colornumber2 = 1;
            pictureBox45.Visible = false;
            pictureBox46.Visible = true;
            pictureBox186.Visible = false;
            pictureBox185.Visible = false;
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            colornumber2 = 0;
            pictureBox46.Visible = false;
            pictureBox45.Visible = true;
            pictureBox186.Visible = false;
            pictureBox185.Visible = false;
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            colornumber3 = 0;
            pictureBox47.Visible = false;
            pictureBox48.Visible = true;
            pictureBox184.Visible = false;
            pictureBox183.Visible = false;
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            pictureBox48.Visible = false;
            pictureBox47.Visible = true;
            pictureBox184.Visible = false;
            pictureBox183.Visible = false;
            colornumber3 = 1;
        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {
            colornumber4 = 0;
            pictureBox49.Visible = false;
            pictureBox50.Visible = true;
            pictureBox182.Visible = false;
            pictureBox181.Visible = false;
        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {
            colornumber4 = 1;
            pictureBox50.Visible = false;
            pictureBox49.Visible = true;
            pictureBox182.Visible = false;
            pictureBox181.Visible = false;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            colornumber5 = 1;
            pictureBox57.Visible = false;
            pictureBox58.Visible = true;
            pictureBox204.Visible = false;
            pictureBox203.Visible = false;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            colornumber5 = 0;
            pictureBox58.Visible = false;
            pictureBox57.Visible = true;
            pictureBox204.Visible = false;
            pictureBox203.Visible = false;
        }

        private void pictureBox29_Click(object sender, EventArgs e)
        {
            colornumber6 = 0;
            pictureBox56.Visible = false;
            pictureBox55.Visible = true;
            pictureBox202.Visible = false;
            pictureBox201.Visible = false;
        }

        private void pictureBox30_Click(object sender, EventArgs e)
        {
            colornumber6 = 1;
            pictureBox55.Visible = false;
            pictureBox56.Visible = true;
            pictureBox202.Visible = false;
            pictureBox201.Visible = false;
        }

        private void pictureBox28_Click(object sender, EventArgs e)
        {
            colornumber7 = 1;
            pictureBox53.Visible = false;
            pictureBox54.Visible = true;
            pictureBox200.Visible = false;
            pictureBox199.Visible = false;
        }

        private void pictureBox27_Click(object sender, EventArgs e)
        {
            colornumber7 = 0;
            pictureBox54.Visible = false;
            pictureBox53.Visible = true;
            pictureBox200.Visible = false;
            pictureBox199.Visible = false;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            pictureBox51.Visible = false;
            pictureBox52.Visible = true;
            colornumber8 = 0;
            pictureBox198.Visible = false;
            pictureBox197.Visible = false;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            pictureBox52.Visible = false;
            pictureBox51.Visible = true;
            colornumber8 = 1;
            pictureBox198.Visible = false;
            pictureBox197.Visible = false;
        }

        private void pictureBox40_Click(object sender, EventArgs e)
        {
            colornumber9 = 1;
            pictureBox65.Visible = false;
            pictureBox66.Visible = true;
            pictureBox216.Visible = false;
            pictureBox215.Visible = false;
        }

        private void pictureBox39_Click(object sender, EventArgs e)
        {
            pictureBox66.Visible = false;
            pictureBox65.Visible = true;
            colornumber9 = 0;
            pictureBox216.Visible = false;
            pictureBox215.Visible = false;
        }

        private void pictureBox42_Click(object sender, EventArgs e)
        {
            colornumber10 = 0;
            pictureBox63.Visible = false;
            pictureBox64.Visible = true;
            pictureBox214.Visible = false;
            pictureBox213.Visible = false;
        }

        private void pictureBox41_Click(object sender, EventArgs e)
        {
            colornumber10 = 1;
            pictureBox64.Visible = false;
            pictureBox63.Visible = true;
            pictureBox214.Visible = false;
            pictureBox213.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label87.Text = "Score:";
            label86.Text = "Rate:";
            label76.Text = "Score:";
            label75.Text = "Rate:";
            label95.Text = "Score:";
            label94.Text = "Rate:";

            pictureBox228.Visible = false;
            pictureBox227.Visible = false;
            pictureBox226.Visible = false;
            pictureBox225.Visible = false;
            pictureBox224.Visible = false;
            pictureBox223.Visible = false;
            pictureBox222.Visible = false;
            pictureBox221.Visible = false;
            pictureBox236.Visible = false;
            pictureBox235.Visible = false;
            pictureBox234.Visible = false;
            pictureBox233.Visible = false;
            pictureBox232.Visible = false;
            pictureBox231.Visible = false;
            pictureBox230.Visible = false;
            pictureBox229.Visible = false;
            pictureBox238.Visible = false;
            pictureBox240.Visible = false;
            pictureBox237.Visible = false;
            pictureBox239.Visible = false; 

            pictureBox188.Visible = false;
            pictureBox187.Visible = false;
            pictureBox186.Visible = false;
            pictureBox185.Visible = false;
            pictureBox184.Visible = false;
            pictureBox183.Visible = false;
            pictureBox182.Visible = false;
            pictureBox181.Visible = false;
            pictureBox204.Visible = false;
            pictureBox203.Visible = false;
            pictureBox202.Visible = false;
            pictureBox201.Visible = false;
            pictureBox200.Visible = false;
            pictureBox199.Visible = false;
            pictureBox198.Visible = false;
            pictureBox197.Visible = false;
            pictureBox216.Visible = false;
            pictureBox215.Visible = false;
            pictureBox214.Visible = false;
            pictureBox213.Visible = false;

            pictureBox143.Visible = false;
            pictureBox144.Visible = false;
            pictureBox142.Visible = false;
            pictureBox141.Visible = false;
            pictureBox140.Visible = false;
            pictureBox139.Visible = false;
            pictureBox138.Visible = false;
            pictureBox137.Visible = false;
            pictureBox164.Visible = false;
            pictureBox163.Visible = false;
            pictureBox162.Visible = false;
            pictureBox161.Visible = false;
            pictureBox160.Visible = false;
            pictureBox159.Visible = false;
            pictureBox158.Visible = false;
            pictureBox157.Visible = false;
            pictureBox176.Visible = false;
            pictureBox175.Visible = false;
            pictureBox174.Visible = false;
            pictureBox173.Visible = false;

            pictureBox43.Visible = false;
            pictureBox44.Visible = false;
            pictureBox45.Visible = false;
            pictureBox46.Visible = false;
            pictureBox47.Visible = false;
            pictureBox48.Visible = false;
            pictureBox49.Visible = false;
            pictureBox50.Visible = false;
            pictureBox57.Visible = false;
            pictureBox58.Visible = false;
            pictureBox55.Visible = false;
            pictureBox56.Visible = false;
            pictureBox53.Visible = false;
            pictureBox54.Visible = false;
            pictureBox51.Visible = false;
            pictureBox52.Visible = false;
            pictureBox65.Visible = false;
            pictureBox66.Visible = false;
            pictureBox63.Visible = false;
            pictureBox64.Visible = false;

            pictureBox70.Visible = false;
            pictureBox69.Visible = false;
            pictureBox68.Visible = false;
            pictureBox67.Visible = false;
            pictureBox62.Visible = false;
            pictureBox61.Visible = false;
            pictureBox60.Visible = false;
            pictureBox59.Visible = false;
            pictureBox93.Visible = false;
            pictureBox92.Visible = false;
            pictureBox91.Visible = false;
            pictureBox90.Visible = false;
            pictureBox89.Visible = false;
            pictureBox88.Visible = false;
            pictureBox87.Visible = false;
            pictureBox86.Visible = false;
            pictureBox112.Visible = false;
            pictureBox111.Visible = false;
            pictureBox110.Visible = false;
            pictureBox109.Visible = false;

            pictureBox108.Visible = false;
            pictureBox107.Visible = false;
            pictureBox106.Visible = false;
            pictureBox105.Visible = false;
            pictureBox85.Visible = false;
            pictureBox84.Visible = false;
            pictureBox83.Visible = false;
            pictureBox82.Visible = false;
            pictureBox125.Visible = false;
            pictureBox124.Visible = false;
            pictureBox123.Visible = false;
            pictureBox122.Visible = false;
            pictureBox121.Visible = false;
            pictureBox120.Visible = false;
            pictureBox119.Visible = false;
            pictureBox118.Visible = false;
            pictureBox136.Visible = false;
            pictureBox135.Visible = false;
            pictureBox134.Visible = false;
            pictureBox133.Visible = false; 

            colornumber1 = 0;
            colornumber2 = 0;
            colornumber3 = 0;
            colornumber4 = 0;
            colornumber5 = 0;
            colornumber6 = 0;
            colornumber7 = 0;
            colornumber8 = 0;
            colornumber9 = 0;
            colornumber10 = 0;
            colors = 0;

            acolornumber1 = 0;
            acolornumber2 = 0;
            acolornumber3 = 0;
            acolornumber4 = 0;
            acolornumber5 = 0;
            acolornumber6 = 0;
            acolornumber7 = 0;
            acolornumber8 = 0;
            acolornumber9 = 0;
            acolornumber10 = 0;
            acolors = 0;

            ncolornumber1 = 0;
            ncolornumber2 = 0;
            ncolornumber3 = 0;
            ncolornumber4 = 0;
            ncolornumber5 = 0;
            ncolornumber6 = 0;
            ncolornumber7 = 0;
            ncolornumber8 = 0;
            ncolornumber9 = 0;
            ncolornumber10 = 0;
            ncolors = 0;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            colors = colornumber1 + colornumber2 + colornumber3 + colornumber4 + colornumber5 + colornumber6 + colornumber7 + colornumber8 + colornumber9 + colornumber10;
            //MessageBox.Show(colors.ToString());
            label76.Text = colors.ToString();
            double res = double.Parse(colors.ToString()) / 2;

            if ((res > 1) && (res <= 2))
            {
                label75.Text = "Fair"; 
            }
            if ((res > 2) && (res <= 3))
            {
                label75.Text = "Good"; 
            }
            if ((res > 3) && (res <= 4))
            {
                label75.Text = "Very Good"; 
            }
            if ((res > 4) && (res <= 5))
            {
                label75.Text = "Outstanding"; 
            }
            if (res <= 1)
            {
                label75.Text = "Poor"; 
            }
                
           // MessageBox.Show(colornumber1.ToString() + "\n" + colornumber2.ToString() + "\n" +colornumber3.ToString() + "\n" +colornumber4.ToString() + "\n" +colornumber5.ToString() + "\n" +colornumber6.ToString() + "\n" +colornumber7.ToString() + "\n" +colornumber8.ToString() + "\n" +colornumber9.ToString() + "\n" +colornumber10.ToString() + "\n");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            pictureBox130.Visible = false;
            groupBox3.BringToFront();
            groupBox4.SendToBack();
            pictureBox3.Visible = true;
            pictureBox2.Visible = false;
            pictureBox4.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox1.BringToFront();
            groupBox2.BringToFront();
            groupBox3.SendToBack();

            pictureBox130.Visible = false;
            pictureBox3.Visible = false;
            pictureBox2.Visible = true;
            pictureBox4.Visible = false; 
        }

        private void pictureBox72_Click(object sender, EventArgs e)
        {
            acolornumber1 = 1;
            pictureBox70.Visible = true;
            pictureBox69.Visible = false;
            pictureBox143.Visible = false;
            pictureBox144.Visible = false; 
        }

        private void pictureBox71_Click(object sender, EventArgs e)
        {
            acolornumber1 = 0;
            pictureBox69.Visible = true;
            pictureBox70.Visible = false;
            pictureBox143.Visible = false;
            pictureBox144.Visible = false; 
        }

        private void pictureBox78_Click(object sender, EventArgs e)
        {
            acolornumber2 = 1;
            pictureBox68.Visible = true;
            pictureBox67.Visible = false;
            pictureBox142.Visible = false;
            pictureBox141.Visible = false; 
        }

        private void pictureBox77_Click(object sender, EventArgs e)
        {
            acolornumber2 = 0;
            pictureBox67.Visible = true;
            pictureBox68.Visible = false;
            pictureBox142.Visible = false;
            pictureBox141.Visible = false; 
        }

        private void pictureBox76_Click(object sender, EventArgs e)
        {
            acolornumber3 = 1;
            pictureBox62.Visible = true;
            pictureBox61.Visible = false;
            pictureBox140.Visible = false;
            pictureBox139.Visible = false;
        }

        private void pictureBox75_Click(object sender, EventArgs e)
        {
            acolornumber3 = 0;
            pictureBox61.Visible = true;
            pictureBox62.Visible = false;
            pictureBox140.Visible = false;
            pictureBox139.Visible = false;
        }

        private void pictureBox74_Click(object sender, EventArgs e)
        {
            acolornumber4 = 0;
            pictureBox60.Visible = true;
            pictureBox59.Visible = false;
            pictureBox138.Visible = false;
            pictureBox137.Visible = false;
        }

        private void pictureBox73_Click(object sender, EventArgs e)
        {
            acolornumber4 = 1;
            pictureBox59.Visible = true;
            pictureBox60.Visible = false;
            pictureBox138.Visible = false;
            pictureBox137.Visible = false;
        }

        private void pictureBox95_Click(object sender, EventArgs e)
        {
            acolornumber5 = 0;
            pictureBox93.Visible = true;
            pictureBox92.Visible = false;
            pictureBox164.Visible = false;
            pictureBox163.Visible = false;
        }

        private void pictureBox94_Click(object sender, EventArgs e)
        {
            acolornumber5 = 1;
            pictureBox92.Visible = true;
            pictureBox93.Visible = false;
            pictureBox164.Visible = false;
            pictureBox163.Visible = false;
        }

        private void pictureBox101_Click(object sender, EventArgs e)
        {
            acolornumber6 = 0;
            pictureBox91.Visible = true;
            pictureBox90.Visible = false;
            pictureBox162.Visible = false;
            pictureBox161.Visible = false;
        }

        private void pictureBox100_Click(object sender, EventArgs e)
        {
            acolornumber6 = 1;
            pictureBox90.Visible = true;
            pictureBox91.Visible = false;
            pictureBox162.Visible = false;
            pictureBox161.Visible = false;
        }

        private void pictureBox99_Click(object sender, EventArgs e)
        {
            acolornumber7 = 1;
            pictureBox89.Visible = true;
            pictureBox88.Visible = false;
            pictureBox160.Visible = false;
            pictureBox159.Visible = false;
        }

        private void pictureBox98_Click(object sender, EventArgs e)
        {
            acolornumber7 = 0;
            pictureBox88.Visible = true;
            pictureBox89.Visible = false;
            pictureBox160.Visible = false;
            pictureBox159.Visible = false;
        }

        private void pictureBox97_Click(object sender, EventArgs e)
        {
            acolornumber8 = 0;
            pictureBox87.Visible = true;
            pictureBox86.Visible = false;
            pictureBox158.Visible = false;
            pictureBox157.Visible = false;
        }

        private void pictureBox96_Click(object sender, EventArgs e)
        {
            acolornumber8 = 1;
            pictureBox86.Visible = true;
            pictureBox87.Visible = false;
            pictureBox158.Visible = false;
            pictureBox157.Visible = false;
        }

        private void pictureBox114_Click(object sender, EventArgs e)
        {
            acolornumber9 = 1;
            pictureBox112.Visible = true;
            pictureBox111.Visible = false;
            pictureBox176.Visible = false;
            pictureBox175.Visible = false;
        }

        private void pictureBox113_Click(object sender, EventArgs e)
        {
            acolornumber9 = 0;
            pictureBox111.Visible = true;
            pictureBox112.Visible = false;
            pictureBox176.Visible = false;
            pictureBox175.Visible = false;
        }

        private void pictureBox116_Click(object sender, EventArgs e)
        {
            acolornumber10 = 0;
            pictureBox110.Visible = true;
            pictureBox109.Visible = false;
            pictureBox174.Visible = false;
            pictureBox173.Visible = false;
        }

        private void pictureBox115_Click(object sender, EventArgs e)
        {
            acolornumber10 = 1;
            pictureBox109.Visible = true;
            pictureBox110.Visible = false;
            pictureBox174.Visible = false;
            pictureBox173.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            acolors = acolornumber1 + acolornumber2 + acolornumber3 + acolornumber4 + acolornumber5 + acolornumber6 + acolornumber7 + acolornumber8 + acolornumber9 + acolornumber10;
            ////MessageBox.Show(acolors.ToString());
            label87.Text = acolors.ToString();
            double res = double.Parse(acolors.ToString()) / 2;

            if ((res > 1) && (res <= 2))
            {
                label86.Text = "Fair";
            }
            if ((res > 2) && (res <= 3))
            {
                label86.Text = "Good";
            }
            if ((res > 3) && (res <= 4))
            {
                label86.Text = "Very Good";
            }
            if ((res > 4) && (res <= 5))
            {
                label86.Text = "Outstanding";
            }
            if (res <= 1)
            {
                label86.Text = "Poor";
            }
            ////MessageBox.Show(acolornumber1.ToString() + "\n" + acolornumber2.ToString() + "\n" + acolornumber3.ToString() + 
            ////    "\n" + acolornumber4.ToString() + "\n" + acolornumber5.ToString() + "\n" + acolornumber6.ToString() + 
            ////    "\n" + acolornumber7.ToString() + "\n" + acolornumber8.ToString() + "\n" + acolornumber9.ToString() + "\n" + acolornumber10.ToString() + "\n");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            groupBox8.SendToBack(); 
            groupBox4.BringToFront();
            pictureBox3.Visible = false;
            pictureBox130.Visible = false;
            pictureBox2.Visible = false;
            pictureBox4.Visible = true;
        }

        private void label48_Click(object sender, EventArgs e)
        {
            pictureBox108.Visible = true;
            pictureBox107.Visible = false;
            pictureBox228.Visible = false;
            pictureBox227.Visible = false;
            ncolornumber1 = 0;
        }

        private void label52_Click(object sender, EventArgs e)
        {
            ncolornumber1 = 1;
            pictureBox107.Visible = true;
            pictureBox108.Visible = false;
            pictureBox228.Visible = false;
            pictureBox227.Visible = false;
        }

        private void label47_Click(object sender, EventArgs e)
        {
            ncolornumber2 = 0;
            pictureBox106.Visible = true;
            pictureBox105.Visible = false;
            pictureBox226.Visible = false;
            pictureBox225.Visible = false;
        }

        private void label51_Click(object sender, EventArgs e)
        {
            ncolornumber2 = 1;
            pictureBox105.Visible = true;
            pictureBox106.Visible = false;
            pictureBox226.Visible = false;
            pictureBox225.Visible = false;
        }

        private void label46_Click(object sender, EventArgs e)
        {
            ncolornumber3 = 1;
            pictureBox85.Visible = true;
            pictureBox84.Visible = false;
            pictureBox224.Visible = false;
            pictureBox223.Visible = false; 
        }

        private void label50_Click(object sender, EventArgs e)
        {
            ncolornumber3 = 0;
            pictureBox84.Visible = true;
            pictureBox85.Visible = false;
            pictureBox224.Visible = false;
            pictureBox223.Visible = false;
        }

        private void tabPage8_Click(object sender, EventArgs e)
        {

        }

        private void label63_Click(object sender, EventArgs e)
        {
            ncolornumber5 = 0;
            pictureBox125.Visible = true;
            pictureBox124.Visible = false;
            pictureBox236.Visible = false;
            pictureBox235.Visible = false; 
        }

        private void label59_Click(object sender, EventArgs e)
        {
            ncolornumber5 = 1;
            pictureBox124.Visible = true;
            pictureBox125.Visible = false;
            pictureBox236.Visible = false;
            pictureBox235.Visible = false; 
        }

        private void label62_Click(object sender, EventArgs e)
        {
            ncolornumber6 = 0;
            pictureBox123.Visible = true;
            pictureBox122.Visible = false;
            pictureBox234.Visible = false;
            pictureBox233.Visible = false;
        }

        private void label58_Click(object sender, EventArgs e)
        {
            ncolornumber6 = 1;
            pictureBox122.Visible = true;
            pictureBox123.Visible = false;
            pictureBox234.Visible = false;
            pictureBox233.Visible = false;
        }

        private void label61_Click(object sender, EventArgs e)
        {
            ncolornumber7 = 0;
            pictureBox121.Visible = true;
            pictureBox120.Visible = false;
            pictureBox232.Visible = false;
            pictureBox231.Visible = false;
        }

        private void label57_Click(object sender, EventArgs e)
        {
            ncolornumber7 = 1;
            pictureBox120.Visible = true;
            pictureBox121.Visible = false;
            pictureBox232.Visible = false;
            pictureBox231.Visible = false;
        }

        private void label60_Click(object sender, EventArgs e)
        {
            ncolornumber8 = 1;
            pictureBox119.Visible = true;
            pictureBox118.Visible = false;
            pictureBox230.Visible = false;
            pictureBox229.Visible = false; 
        }

        private void label42_Click(object sender, EventArgs e)
        {
            ncolornumber8 = 0;
            pictureBox118.Visible = true;
            pictureBox119.Visible = false;
            pictureBox230.Visible = false;
            pictureBox229.Visible = false; 
        }

        private void label78_Click(object sender, EventArgs e)
        {
            ncolornumber9 = 1;
            pictureBox136.Visible = true;
            pictureBox135.Visible = false;
            pictureBox238.Visible = false;
            pictureBox240.Visible = false;
        }

        private void label74_Click(object sender, EventArgs e)
        {
            ncolornumber9 = 0;
            pictureBox135.Visible = true;
            pictureBox136.Visible = false;
            pictureBox238.Visible = false;
            pictureBox240.Visible = false;
        }

        private void label77_Click(object sender, EventArgs e)
        {
            ncolornumber10 = 0;
            pictureBox134.Visible = true;
            pictureBox133.Visible = false;
            pictureBox237.Visible = false;
            pictureBox239.Visible = false; 
        }

        private void label73_Click(object sender, EventArgs e)
        {
            ncolornumber10 = 1;
            pictureBox133.Visible = true;
            pictureBox134.Visible = false;
            pictureBox237.Visible = false;
            pictureBox239.Visible = false; 

        }

        private void label45_Click(object sender, EventArgs e)
        {
            ncolornumber4 = 1;
            pictureBox83.Visible = true;
            pictureBox82.Visible = false;
            pictureBox222.Visible = false;
            pictureBox221.Visible = false;
        }

        private void label49_Click(object sender, EventArgs e)
        {
            ncolornumber4 = 0;
            pictureBox82.Visible = true;
            pictureBox83.Visible = false;
            pictureBox222.Visible = false;
            pictureBox221.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label80.Text = textBox1.Text;
            label79.Text = textBox2.Text;
            label89.Text = textBox1.Text;
            label88.Text = textBox2.Text;
            label97.Text = textBox1.Text;
            label96.Text = textBox2.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            label80.Text = textBox1.Text;
            label79.Text = textBox2.Text;
            label89.Text = textBox1.Text;
            label88.Text = textBox2.Text;
            label97.Text = textBox1.Text;
            label96.Text = textBox2.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ncolors = ncolornumber1 + ncolornumber2 + ncolornumber3 + ncolornumber4 + ncolornumber5 + ncolornumber6 + ncolornumber7 + ncolornumber8 + ncolornumber9 + ncolornumber10;
            //MessageBox.Show(ncolors.ToString());
            label95.Text = ncolors.ToString();

            double res = double.Parse(ncolors.ToString()) / 2;

            if ((res > 1) && (res <= 2))
            {
                label94.Text = "Fair";
            }
            if ((res > 2) && (res <= 3))
            {
                label94.Text = "Good";
            }
            if ((res > 3) && (res <= 4))
            {
                label94.Text = "Very Good";
            }
            if ((res > 4) && (res <= 5))
            {
                label94.Text = "Outstanding";
            }
            if (res <= 1)
            {
                label94.Text = "Poor";
            }

            //MessageBox.Show(ncolornumber1.ToString() + "\n" + ncolornumber2.ToString() + "\n" +ncolornumber3.ToString() + 
            //    "\n" +ncolornumber4.ToString() + "\n" +ncolornumber5.ToString() + "\n" +ncolornumber6.ToString() + 
            //    "\n" +ncolornumber7.ToString() + "\n" +ncolornumber8.ToString() + "\n" +ncolornumber9.ToString() + 
            //    "\n" +ncolornumber10.ToString() + "\n");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
            groupBox8.BringToFront();  

            dataGridView10.Rows.Clear();
            dataGridView9.Rows.Clear();
            dataGridView8.Rows.Clear();
            dataGridView7.Rows.Clear();
            dataGridView6.Rows.Clear();
            comboBox3.Text = "";
            comboBox4.Text = "";
            try
            {
                conn = Connection.ConnectToServer();
                if (conn.State == ConnectionState.Open)
                {
                    SqlDataReader dr = del.AllTrials(conn);
                    if (dr.HasRows)
                    {
                        comboBox3.Items.Clear();
                        del.TRIALIDz.Clear();
                        while (dr.Read())
                        {
                            comboBox3.Items.Add(dr[1].ToString());
                            del.TRIALIDz.Add(dr[0]);
                        }
                    }
                    else
                    {
                        comboBox3.Items.Clear();
                        del.TRIALIDz.Clear();
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally { conn.Close(); }
            try
            {
                conn = Connection.ConnectToServer();
                if (conn.State == ConnectionState.Open)
                {
                    SqlDataReader dr = del.AllStudents(conn);
                    if (dr.HasRows)
                    {
                        comboBox4.Items.Clear();
                        del.STUDIz.Clear();
                        while (dr.Read())
                        {
                            comboBox4.Items.Add(dr[1].ToString() + ", " + dr[2].ToString() + " " + dr[3].ToString() + ".");
                            del.STUDIz.Add(dr[0]);
                        }
                    }
                    else
                    {
                        comboBox4.Items.Clear();
                        del.STUDIz.Clear();
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally { conn.Close(); }
            

            try
            {
                conn = Connection.ConnectToServer();
                if (conn.State == ConnectionState.Open)
                {
                    SqlDataReader dr = del.AllStudents1(conn);
                    if (dr.HasRows)
                    {
                        dataGridView4.Rows.Clear();
                        while (dr.Read())
                        {
                            dataGridView4.Rows.Add(dr[1].ToString(),dr[2].ToString(),dr[3].ToString(),dr[4].ToString());
                            del.STUDI.Add(dr[0]);
                        }
                    }
                    else
                    {
                        dataGridView4.Rows.Clear();
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally { conn.Close(); }

            label112.Text = label76.Text;
            label111.Text = label75.Text;

            label114.Text = label87.Text;
            label113.Text = label86.Text;

            label116.Text = label95.Text;
            label115.Text = label94.Text;

            label120.Text = label76.Text;
            label121.Text = label87.Text;
            label122.Text = label95.Text;


            try
            {
                double co = double.Parse(label120.Text);
                double sh = double.Parse(label121.Text);
                double no = double.Parse(label122.Text);
                double finalrate = co + sh + no;
                label123.Text = finalrate.ToString();
                double ave = double.Parse(finalrate.ToString()) / 3;
                double res = ave / 2;
                //MessageBox.Show(res.ToString());

                if ((res > 1) && (res <= 2))
                {
                    label125.Text = "Fair";
                }
                if ((res > 2) && (res <= 3))
                {
                    label125.Text = "Good";
                }
                if ((res > 3) && (res <= 4))
                {
                    label125.Text = "Very Good";
                }
                if ((res > 4) && (res <= 5))
                {
                    label125.Text = "Outstanding";
                }
                if (res <= 1)
                {
                    label125.Text = "Poor";
                }

            }
            catch (Exception)
            {
                label123.Text = "?";
                label125.Text = "?"; 
            }

            this.dataGridView4.RowsDefaultCellStyle.BackColor = Color.White;
            this.dataGridView4.AlternatingRowsDefaultCellStyle.BackColor = Color.PaleGreen;
            this.dataGridView2.RowsDefaultCellStyle.BackColor = Color.White;
            this.dataGridView2.AlternatingRowsDefaultCellStyle.BackColor = Color.PaleGreen;
            this.dataGridView5.RowsDefaultCellStyle.BackColor = Color.White;
            this.dataGridView5.AlternatingRowsDefaultCellStyle.BackColor = Color.PaleGreen;
            this.dataGridView1.RowsDefaultCellStyle.BackColor = Color.White;
            this.dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.PaleGreen;
            this.dataGridView3.RowsDefaultCellStyle.BackColor = Color.White;
            this.dataGridView3.AlternatingRowsDefaultCellStyle.BackColor = Color.PaleGreen;

            this.dataGridView8.RowsDefaultCellStyle.BackColor = Color.White;
            this.dataGridView8.AlternatingRowsDefaultCellStyle.BackColor = Color.PaleGreen;
            this.dataGridView7.RowsDefaultCellStyle.BackColor = Color.White;
            this.dataGridView7.AlternatingRowsDefaultCellStyle.BackColor = Color.PaleGreen;
            this.dataGridView6.RowsDefaultCellStyle.BackColor = Color.White;
            this.dataGridView6.AlternatingRowsDefaultCellStyle.BackColor = Color.PaleGreen;

            groupBox8.BringToFront();
            
            
            pictureBox130.Visible = true;
            pictureBox3.Visible = false;
            pictureBox2.Visible = false;
            pictureBox4.Visible = false;


            string c1 = "";
            string c2 = "";
            string c3 = "";
            string c4 = "";
            string c5 = "";
            string c6 = "";
            string c7 = "";
            string c8 = "";
            string c9 = "";
            string c10 = "";

            string ac1 = "";
            string ac2 = "";
            string ac3 = "";
            string ac4 = "";
            string ac5 = "";
            string ac6 = "";
            string ac7 = "";
            string ac8 = "";
            string ac9 = "";
            string ac10 = "";


            string nc1 = "";
            string nc2 = "";
            string nc3 = "";
            string nc4 = "";
            string nc5 = "";
            string nc6 = "";
            string nc7 = "";
            string nc8 = "";
            string nc9 = "";
            string nc10 = "";

            if (colornumber1 == 1)
            {
                c1 = "Correct";
            }
            if (colornumber2 == 1)
            {
                c2 = "Correct";
            }
            if (colornumber3 == 1)
            {
                c3 = "Correct";
            }
            if (colornumber4 == 1)
            {
                c4 = "Correct";
            }
            if (colornumber5 == 1)
            {
                c5 = "Correct";
            }
            if (colornumber6 == 1)
            {
                c6 = "Correct";
            }
            if (colornumber7 == 1)
            {
                c7 = "Correct";
            }
            if (colornumber8 == 1)
            {
                c8 = "Correct";
            }
            if (colornumber9 == 1)
            {
                c9 = "Correct";
            }
            if (colornumber10 == 1)
            {
                c10 = "Correct";
            }

            //=====Wrongcolors
            if (colornumber1 == 0)
            {
                c1 = "Wrong";
            }
            if (colornumber2 == 0)
            {
                c2 = "Wrong";
            }
            if (colornumber3 == 0)
            {
                c3 = "Wrong";
            }
            if (colornumber4 == 0)
            {
                c4 = "Wrong";
            }
            if (colornumber5 == 0)
            {
                c5 = "Wrong";
            }
            if (colornumber6 == 0)
            {
                c6 = "Wrong";
            }
            if (colornumber7 == 0)
            {
                c7 = "Wrong";
            }
            if (colornumber8 == 0)
            {
                c8 = "Wrong";
            }
            if (colornumber9 == 0)
            {
                c9 = "Wrong";
            }
            if (colornumber10 == 0)
            {
                c10 = "Wrong";
            }

            //shapes
            if (acolornumber1 == 1)
            {
                ac1 = "Correct";
            }
            if (acolornumber2 == 1)
            {
                ac2 = "Correct";
            }
            if (acolornumber3 == 1)
            {
                ac3 = "Correct";
            }
            if (acolornumber4 == 1)
            {
                ac4 = "Correct";
            }
            if (acolornumber5 == 1)
            {
                ac5 = "Correct";
            }
            if (acolornumber6 == 1)
            {
                ac6 = "Correct";
            }
            if (acolornumber7 == 1)
            {
                ac7 = "Correct";
            }
            if (acolornumber8 == 1)
            {
                ac8 = "Correct";
            }
            if (acolornumber9 == 1)
            {
                ac9 = "Correct";
            }
            if (acolornumber10 == 1)
            {
                ac10 = "Correct";
            }

            //=====Wrongcolors
            if (acolornumber1 == 0)
            {
                ac1 = "Wrong";
            }
            if (acolornumber2 == 0)
            {
                ac2 = "Wrong";
            }
            if (acolornumber3 == 0)
            {
                ac3 = "Wrong";
            }
            if (acolornumber4 == 0)
            {
                ac4 = "Wrong";
            }
            if (acolornumber5 == 0)
            {
                ac5 = "Wrong";
            }
            if (acolornumber6 == 0)
            {
                ac6 = "Wrong";
            }
            if (acolornumber7 == 0)
            {
                ac7 = "Wrong";
            }
            if (acolornumber8 == 0)
            {
                ac8 = "Wrong";
            }
            if (acolornumber9 == 0)
            {
                ac9 = "Wrong";
            }
            if (acolornumber10 == 0)
            {
                ac10 = "Wrong";
            }

            //numbers====




            if (ncolornumber1 == 1)
            {
                nc1 = "Correct";
            }
            if (ncolornumber2 == 1)
            {
                nc2 = "Correct";
            }
            if (ncolornumber3 == 1)
            {
                nc3 = "Correct";
            }
            if (ncolornumber4 == 1)
            {
                nc4 = "Correct";
            }
            if (ncolornumber5 == 1)
            {
                nc5 = "Correct";
            }
            if (ncolornumber6 == 1)
            {
                nc6 = "Correct";
            }
            if (ncolornumber7 == 1)
            {
                nc7 = "Correct";
            }
            if (ncolornumber8 == 1)
            {
                nc8 = "Correct";
            }
            if (ncolornumber9 == 1)
            {
                nc9 = "Correct";
            }
            if (ncolornumber10 == 1)
            {
                nc10 = "Correct";
            }

            //=====Wrongcolors
            if (ncolornumber1 == 0)
            {
                nc1 = "Wrong";
            }
            if (ncolornumber2 == 0)
            {
                nc2 = "Wrong";
            }
            if (ncolornumber3 == 0)
            {
                nc3 = "Wrong";
            }
            if (ncolornumber4 == 0)
            {
                nc4 = "Wrong";
            }
            if (ncolornumber5 == 0)
            {
                nc5 = "Wrong";
            }
            if (ncolornumber6 == 0)
            {
                nc6 = "Wrong";
            }
            if (ncolornumber7 == 0)
            {
                nc7 = "Wrong";
            }
            if (ncolornumber8 == 0)
            {
                nc8 = "Wrong";
            }
            if (ncolornumber9 == 0)
            {
                nc9 = "Wrong";
            }
            if (ncolornumber10 == 0)
            {
                nc10 = "Wrong";
            }

            dataGridView1.Rows.Clear(); 
            dataGridView1.Rows.Add("1.",c1.ToString(),colornumber1.ToString());
            dataGridView1.Rows.Add("2.",c2.ToString(),colornumber2.ToString());
            dataGridView1.Rows.Add("3.",c3.ToString(),colornumber3.ToString());
            dataGridView1.Rows.Add("4.",c4.ToString(),colornumber4.ToString());
            dataGridView1.Rows.Add("5.",c5.ToString(),colornumber5.ToString());
            dataGridView1.Rows.Add("6.",c6.ToString(),colornumber6.ToString());
            dataGridView1.Rows.Add("7.",c7.ToString(),colornumber7.ToString());
            dataGridView1.Rows.Add("8.",c8.ToString(),colornumber8.ToString());
            dataGridView1.Rows.Add("9.",c9.ToString(),colornumber9.ToString());
            dataGridView1.Rows.Add("10.",c10.ToString(),colornumber10.ToString());


            dataGridView2.Rows.Clear();
            dataGridView2.Rows.Add("1.", ac1.ToString(), acolornumber1.ToString());
            dataGridView2.Rows.Add("2.", ac2.ToString(), acolornumber2.ToString());
            dataGridView2.Rows.Add("3.", ac3.ToString(), acolornumber3.ToString());
            dataGridView2.Rows.Add("4.", ac4.ToString(), acolornumber4.ToString());
            dataGridView2.Rows.Add("5.", ac5.ToString(), acolornumber5.ToString());
            dataGridView2.Rows.Add("6.", ac6.ToString(), acolornumber6.ToString());
            dataGridView2.Rows.Add("7.", ac7.ToString(), acolornumber7.ToString());
            dataGridView2.Rows.Add("8.", ac8.ToString(), acolornumber8.ToString());
            dataGridView2.Rows.Add("9.", ac9.ToString(), acolornumber9.ToString());
            dataGridView2.Rows.Add("10.", ac10.ToString(), acolornumber10.ToString());

            dataGridView3.Rows.Clear();
            dataGridView3.Rows.Add("1.", nc1.ToString(), ncolornumber1.ToString());
            dataGridView3.Rows.Add("2.", nc2.ToString(), ncolornumber2.ToString());
            dataGridView3.Rows.Add("3.", nc3.ToString(), ncolornumber3.ToString());
            dataGridView3.Rows.Add("4.", nc4.ToString(), ncolornumber4.ToString());
            dataGridView3.Rows.Add("5.", nc5.ToString(), ncolornumber5.ToString());
            dataGridView3.Rows.Add("6.", nc6.ToString(), ncolornumber6.ToString());
            dataGridView3.Rows.Add("7.", nc7.ToString(), ncolornumber7.ToString());
            dataGridView3.Rows.Add("8.", nc8.ToString(), ncolornumber8.ToString());
            dataGridView3.Rows.Add("9.", nc9.ToString(), ncolornumber9.ToString());
            dataGridView3.Rows.Add("10.", nc10.ToString(), ncolornumber10.ToString());
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                del.ST = Convert.ToInt32(del.STUDI[comboBox1.SelectedIndex]);
                del.TR = Convert.ToInt32(del.TRIALID[comboBox2.SelectedIndex]);
                conn = Connection.ConnectToServer();
                if (conn.State == ConnectionState.Open)
                {
                    SqlDataReader dr = del.DetectTrial(conn);
                    if (dr.HasRows)
                    {
                       
                        while (dr.Read())
                        {
                            DialogResult okay = new DialogResult();
                            okay = MessageBox.Show(comboBox1.Text + " was already finished on " + comboBox2.Text, "Inventory", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            if (okay == DialogResult.OK)
                            {
                                Application.DoEvents();
                            }
                            fina = "ok";
                            button10.Enabled = false;
                        }
                    }
                    else
                    {
                        fina = "not";
                        button10.Enabled = true;
                    }
                }
            }
            catch (Exception)
            {
                string c = "";
            }
            finally { conn.Close(); }


            try
            {
                del.ST = Convert.ToInt32(del.STUDI[comboBox1.SelectedIndex]);
                conn = Connection.ConnectToServer();
                if (conn.State == ConnectionState.Open)
                {
                    SqlDataReader dr = del.AllStudentsSelect(conn);
                    if (dr.HasRows)
                    {
                        textBox1.Clear();
                        textBox2.Clear();
                        while (dr.Read())
                        {
                            textBox1.Text = dr[1].ToString() + ", " + dr[2].ToString() + " " + dr[3].ToString() + ".";
                            textBox2.Text = dr[4].ToString();
                        }
                    }
                    else
                    {
                        textBox1.Clear();
                        textBox2.Clear();
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally { conn.Close(); }


        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            del.TR = Convert.ToInt32(del.TRIALID[comboBox2.SelectedIndex]);

            try
            {
                del.ST = Convert.ToInt32(del.STUDI[comboBox1.SelectedIndex]);
                del.TR = Convert.ToInt32(del.TRIALID[comboBox2.SelectedIndex]);
                conn = Connection.ConnectToServer();
                if (conn.State == ConnectionState.Open)
                {
                    SqlDataReader dr = del.DetectTrial(conn);
                    if (dr.HasRows)
                    {

                        while (dr.Read())
                        {
                            DialogResult okay = new DialogResult();
                            okay = MessageBox.Show(comboBox1.Text + " was already finished on " + comboBox2.Text, "Inventory", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            if (okay == DialogResult.OK)
                            {
                                Application.DoEvents();
                            }

                            fina = "ok";
                            button10.Enabled = false;
                        }
                    }
                    else
                    {
                        fina = "not";
                        button10.Enabled = true;
                    }
                }
            }
            catch (Exception)
            {
                string c = "";
            }
            finally { conn.Close(); }
            //MessageBox.Show(del.TR.ToString());
        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    del.CATEGORYSCORE = double.Parse(label112.Text);
                    del.CATEGORYRATE = label111.Text;
                    del.OVERALLSCORE = double.Parse(label123.Text);
                    del.OVERALLRATE = label125.Text;
                    del.AddRecordsColors(dataGridView1);
                    button10.Enabled = false; 
                }
                catch (Exception)
                {
                    MessageBox.Show("Complete the Details");
                }

                try
                {
                    del.CATEGORYSCORE = double.Parse(label114.Text);
                    del.CATEGORYRATE = label113.Text;
                    del.OVERALLSCORE = double.Parse(label123.Text);
                    del.OVERALLRATE = label125.Text;
                    del.AddRecordsShapes(dataGridView2);
                    button10.Enabled = false; 
                }
                catch (Exception)
                {
                    MessageBox.Show("Complete the Details");
                }


                try
                {
                    del.CATEGORYSCORE = double.Parse(label116.Text);
                    del.CATEGORYRATE = label115.Text;
                    del.OVERALLSCORE = double.Parse(label123.Text);
                    del.OVERALLRATE = label125.Text;
                    del.AddRecordsNumbers(dataGridView3);
                    button10.Enabled = false; 
                }
                catch (Exception)
                {
                    MessageBox.Show("Complete the Details");
                }

                try
                {
                    del.CATEGORYSCORE = double.Parse(label112.Text);
                    del.CATEGORYRATE = label111.Text;
                    del.AddRecordsColorsCATEGORIZED();
                    button10.Enabled = false; 
                    del.CATEGORYSCORE = double.Parse(label114.Text);
                    del.CATEGORYRATE = label113.Text;
                    del.AddRecordsShapesCATEGORIZED();
                    button10.Enabled = false; 

                    del.CATEGORYSCORE = double.Parse(label116.Text);
                    del.CATEGORYRATE = label115.Text;
                    del.AddRecordsNumbersCATEGORIZED();

                    del.OVERALLSCORE = double.Parse(label123.Text);
                    del.OVERALLRATE = label125.Text;

                    del.AddRecordsCOLORS_ALL();


                    button10.Enabled = false; 
                }
                catch (Exception)
                {
                    string x = "x";
                }

                try
                {
                    del.ST = Convert.ToInt32(del.STUDI[comboBox1.SelectedIndex]);
                    del.TR = Convert.ToInt32(del.TRIALID[comboBox2.SelectedIndex]);
                    conn = Connection.ConnectToServer();
                    if (conn.State == ConnectionState.Open)
                    {
                        SqlDataReader dr = del.DetectTrial(conn);
                        if (dr.HasRows)
                        {

                            while (dr.Read())
                            {
                                DialogResult okay = new DialogResult();
                                okay = MessageBox.Show(comboBox1.Text + " was already finished on " + comboBox2.Text + " :Proceed to ----Next Trial", "Inventory", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                if (okay == DialogResult.OK)
                                {
                                    Application.DoEvents();
                                }
                                fina = "ok";
                                button10.Enabled = false;
                            }
                        }
                        else
                        {
                            fina = "not";
                            button10.Enabled = true;
                        }
                    }
                }
                catch (Exception)
                {
                    string c = "";
                }
                finally { conn.Close(); }

            }
            catch (Exception)
            {
                MessageBox.Show("Complete the Details");
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                del.CATEGORYSCORE = double.Parse(label114.Text);
                del.CATEGORYRATE = label113.Text;
                del.OVERALLSCORE = double.Parse(label123.Text);
                del.OVERALLRATE = label125.Text;
                del.AddRecordsShapes(dataGridView2);
            }
            catch (Exception)
            {
                MessageBox.Show("Complete the Details");
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                del.CATEGORYSCORE = double.Parse(label116.Text);
                del.CATEGORYRATE = label115.Text;
                del.OVERALLSCORE = double.Parse(label123.Text);
                del.OVERALLRATE = label125.Text;
                del.AddRecordsNumbers(dataGridView3);
            }
            catch (Exception)
            {
                MessageBox.Show("Complete the Details");
            }
        }

        private void button11_Click_1(object sender, EventArgs e)
        {


            button10.Enabled = true; 
            label87.Text = "Score:";
            label86.Text = "Rate:";
            label76.Text = "Score:";
            label75.Text = "Rate:";
            label95.Text = "Score:";
            label94.Text = "Rate:";

            label111.Text = "?";
            label112.Text = "?";
            label113.Text = "?";
            label114.Text = "?";
            label115.Text = "?";
            label116.Text = "?";

            label120.Text = "?";
            label121.Text = "?";
            label122.Text = "?";
            label123.Text = "?";
            label125.Text = "?";

            pictureBox188.Visible = false;
            pictureBox187.Visible = false;
            pictureBox186.Visible = false;
            pictureBox185.Visible = false;
            pictureBox184.Visible = false;
            pictureBox183.Visible = false;
            pictureBox182.Visible = false;
            pictureBox181.Visible = false;
            pictureBox204.Visible = false;
            pictureBox203.Visible = false;
            pictureBox202.Visible = false;
            pictureBox201.Visible = false;
            pictureBox200.Visible = false;
            pictureBox199.Visible = false;
            pictureBox198.Visible = false;
            pictureBox197.Visible = false;
            pictureBox216.Visible = false;
            pictureBox215.Visible = false;
            pictureBox214.Visible = false;
            pictureBox213.Visible = false;

            pictureBox143.Visible = false;
            pictureBox144.Visible = false;
            pictureBox142.Visible = false;
            pictureBox141.Visible = false;
            pictureBox140.Visible = false;
            pictureBox139.Visible = false;
            pictureBox138.Visible = false;
            pictureBox137.Visible = false;
            pictureBox164.Visible = false;
            pictureBox163.Visible = false;
            pictureBox162.Visible = false;
            pictureBox161.Visible = false;
            pictureBox160.Visible = false;
            pictureBox159.Visible = false;
            pictureBox158.Visible = false;
            pictureBox157.Visible = false;
            pictureBox176.Visible = false;
            pictureBox175.Visible = false;
            pictureBox174.Visible = false;
            pictureBox173.Visible = false;

            pictureBox43.Visible = false;
            pictureBox44.Visible = false;
            pictureBox45.Visible = false;
            pictureBox46.Visible = false;
            pictureBox47.Visible = false;
            pictureBox48.Visible = false;
            pictureBox49.Visible = false;
            pictureBox50.Visible = false;
            pictureBox57.Visible = false;
            pictureBox58.Visible = false;
            pictureBox55.Visible = false;
            pictureBox56.Visible = false;
            pictureBox53.Visible = false;
            pictureBox54.Visible = false;
            pictureBox51.Visible = false;
            pictureBox52.Visible = false;
            pictureBox65.Visible = false;
            pictureBox66.Visible = false;
            pictureBox63.Visible = false;
            pictureBox64.Visible = false;

            pictureBox70.Visible = false;
            pictureBox69.Visible = false;
            pictureBox68.Visible = false;
            pictureBox67.Visible = false;
            pictureBox62.Visible = false;
            pictureBox61.Visible = false;
            pictureBox60.Visible = false;
            pictureBox59.Visible = false;
            pictureBox93.Visible = false;
            pictureBox92.Visible = false;
            pictureBox91.Visible = false;
            pictureBox90.Visible = false;
            pictureBox89.Visible = false;
            pictureBox88.Visible = false;
            pictureBox87.Visible = false;
            pictureBox86.Visible = false;
            pictureBox112.Visible = false;
            pictureBox111.Visible = false;
            pictureBox110.Visible = false;
            pictureBox109.Visible = false;

            pictureBox108.Visible = false;
            pictureBox107.Visible = false;
            pictureBox106.Visible = false;
            pictureBox105.Visible = false;
            pictureBox85.Visible = false;
            pictureBox84.Visible = false;
            pictureBox83.Visible = false;
            pictureBox82.Visible = false;
            pictureBox125.Visible = false;
            pictureBox124.Visible = false;
            pictureBox123.Visible = false;
            pictureBox122.Visible = false;
            pictureBox121.Visible = false;
            pictureBox120.Visible = false;
            pictureBox119.Visible = false;
            pictureBox118.Visible = false;
            pictureBox136.Visible = false;
            pictureBox135.Visible = false;
            pictureBox134.Visible = false;
            pictureBox133.Visible = false;


            pictureBox228.Visible = false;
            pictureBox227.Visible = false;
            pictureBox226.Visible = false;
            pictureBox225.Visible = false;
            pictureBox224.Visible = false;
            pictureBox223.Visible = false;
            pictureBox222.Visible = false;
            pictureBox221.Visible = false;
            pictureBox236.Visible = false;
            pictureBox235.Visible = false;
            pictureBox234.Visible = false;
            pictureBox233.Visible = false;
            pictureBox232.Visible = false;
            pictureBox231.Visible = false;
            pictureBox230.Visible = false;
            pictureBox229.Visible = false;
            pictureBox238.Visible = false;
            pictureBox240.Visible = false;
            pictureBox237.Visible = false;
            pictureBox239.Visible = false; 

            colornumber1 = 0;
            colornumber2 = 0;
            colornumber3 = 0;
            colornumber4 = 0;
            colornumber5 = 0;
            colornumber6 = 0;
            colornumber7 = 0;
            colornumber8 = 0;
            colornumber9 = 0;
            colornumber10 = 0;
            colors = 0;

            acolornumber1 = 0;
            acolornumber2 = 0;
            acolornumber3 = 0;
            acolornumber4 = 0;
            acolornumber5 = 0;
            acolornumber6 = 0;
            acolornumber7 = 0;
            acolornumber8 = 0;
            acolornumber9 = 0;
            acolornumber10 = 0;
            acolors = 0;

            ncolornumber1 = 0;
            ncolornumber2 = 0;
            ncolornumber3 = 0;
            ncolornumber4 = 0;
            ncolornumber5 = 0;
            ncolornumber6 = 0;
            ncolornumber7 = 0;
            ncolornumber8 = 0;
            ncolornumber9 = 0;
            ncolornumber10 = 0;
            ncolors = 0;




            string c1 = "";
            string c2 = "";
            string c3 = "";
            string c4 = "";
            string c5 = "";
            string c6 = "";
            string c7 = "";
            string c8 = "";
            string c9 = "";
            string c10 = "";

            string ac1 = "";
            string ac2 = "";
            string ac3 = "";
            string ac4 = "";
            string ac5 = "";
            string ac6 = "";
            string ac7 = "";
            string ac8 = "";
            string ac9 = "";
            string ac10 = "";


            string nc1 = "";
            string nc2 = "";
            string nc3 = "";
            string nc4 = "";
            string nc5 = "";
            string nc6 = "";
            string nc7 = "";
            string nc8 = "";
            string nc9 = "";
            string nc10 = "";

            if (colornumber1 == 1)
            {
                c1 = "Correct";
            }
            if (colornumber2 == 1)
            {
                c2 = "Correct";
            }
            if (colornumber3 == 1)
            {
                c3 = "Correct";
            }
            if (colornumber4 == 1)
            {
                c4 = "Correct";
            }
            if (colornumber5 == 1)
            {
                c5 = "Correct";
            }
            if (colornumber6 == 1)
            {
                c6 = "Correct";
            }
            if (colornumber7 == 1)
            {
                c7 = "Correct";
            }
            if (colornumber8 == 1)
            {
                c8 = "Correct";
            }
            if (colornumber9 == 1)
            {
                c9 = "Correct";
            }
            if (colornumber10 == 1)
            {
                c10 = "Correct";
            }

            //=====Wrongcolors
            if (colornumber1 == 0)
            {
                c1 = "Wrong";
            }
            if (colornumber2 == 0)
            {
                c2 = "Wrong";
            }
            if (colornumber3 == 0)
            {
                c3 = "Wrong";
            }
            if (colornumber4 == 0)
            {
                c4 = "Wrong";
            }
            if (colornumber5 == 0)
            {
                c5 = "Wrong";
            }
            if (colornumber6 == 0)
            {
                c6 = "Wrong";
            }
            if (colornumber7 == 0)
            {
                c7 = "Wrong";
            }
            if (colornumber8 == 0)
            {
                c8 = "Wrong";
            }
            if (colornumber9 == 0)
            {
                c9 = "Wrong";
            }
            if (colornumber10 == 0)
            {
                c10 = "Wrong";
            }

            //shapes
            if (acolornumber1 == 1)
            {
                ac1 = "Correct";
            }
            if (acolornumber2 == 1)
            {
                ac2 = "Correct";
            }
            if (acolornumber3 == 1)
            {
                ac3 = "Correct";
            }
            if (acolornumber4 == 1)
            {
                ac4 = "Correct";
            }
            if (acolornumber5 == 1)
            {
                ac5 = "Correct";
            }
            if (acolornumber6 == 1)
            {
                ac6 = "Correct";
            }
            if (acolornumber7 == 1)
            {
                ac7 = "Correct";
            }
            if (acolornumber8 == 1)
            {
                ac8 = "Correct";
            }
            if (acolornumber9 == 1)
            {
                ac9 = "Correct";
            }
            if (acolornumber10 == 1)
            {
                ac10 = "Correct";
            }

            //=====Wrongcolors
            if (acolornumber1 == 0)
            {
                ac1 = "Wrong";
            }
            if (acolornumber2 == 0)
            {
                ac2 = "Wrong";
            }
            if (acolornumber3 == 0)
            {
                ac3 = "Wrong";
            }
            if (acolornumber4 == 0)
            {
                ac4 = "Wrong";
            }
            if (acolornumber5 == 0)
            {
                ac5 = "Wrong";
            }
            if (acolornumber6 == 0)
            {
                ac6 = "Wrong";
            }
            if (acolornumber7 == 0)
            {
                ac7 = "Wrong";
            }
            if (acolornumber8 == 0)
            {
                ac8 = "Wrong";
            }
            if (acolornumber9 == 0)
            {
                ac9 = "Wrong";
            }
            if (acolornumber10 == 0)
            {
                ac10 = "Wrong";
            }

            //numbers====




            if (ncolornumber1 == 1)
            {
                nc1 = "Correct";
            }
            if (ncolornumber2 == 1)
            {
                nc2 = "Correct";
            }
            if (ncolornumber3 == 1)
            {
                nc3 = "Correct";
            }
            if (ncolornumber4 == 1)
            {
                nc4 = "Correct";
            }
            if (ncolornumber5 == 1)
            {
                nc5 = "Correct";
            }
            if (ncolornumber6 == 1)
            {
                nc6 = "Correct";
            }
            if (ncolornumber7 == 1)
            {
                nc7 = "Correct";
            }
            if (ncolornumber8 == 1)
            {
                nc8 = "Correct";
            }
            if (ncolornumber9 == 1)
            {
                nc9 = "Correct";
            }
            if (ncolornumber10 == 1)
            {
                nc10 = "Correct";
            }

            //=====Wrongcolors
            if (ncolornumber1 == 0)
            {
                nc1 = "Wrong";
            }
            if (ncolornumber2 == 0)
            {
                nc2 = "Wrong";
            }
            if (ncolornumber3 == 0)
            {
                nc3 = "Wrong";
            }
            if (ncolornumber4 == 0)
            {
                nc4 = "Wrong";
            }
            if (ncolornumber5 == 0)
            {
                nc5 = "Wrong";
            }
            if (ncolornumber6 == 0)
            {
                nc6 = "Wrong";
            }
            if (ncolornumber7 == 0)
            {
                nc7 = "Wrong";
            }
            if (ncolornumber8 == 0)
            {
                nc8 = "Wrong";
            }
            if (ncolornumber9 == 0)
            {
                nc9 = "Wrong";
            }
            if (ncolornumber10 == 0)
            {
                nc10 = "Wrong";
            }

            dataGridView1.Rows.Clear();
            dataGridView1.Rows.Add("1.", c1.ToString(), colornumber1.ToString());
            dataGridView1.Rows.Add("2.", c2.ToString(), colornumber2.ToString());
            dataGridView1.Rows.Add("3.", c3.ToString(), colornumber3.ToString());
            dataGridView1.Rows.Add("4.", c4.ToString(), colornumber4.ToString());
            dataGridView1.Rows.Add("5.", c5.ToString(), colornumber5.ToString());
            dataGridView1.Rows.Add("6.", c6.ToString(), colornumber6.ToString());
            dataGridView1.Rows.Add("7.", c7.ToString(), colornumber7.ToString());
            dataGridView1.Rows.Add("8.", c8.ToString(), colornumber8.ToString());
            dataGridView1.Rows.Add("9.", c9.ToString(), colornumber9.ToString());
            dataGridView1.Rows.Add("10.", c10.ToString(), colornumber10.ToString());


            dataGridView2.Rows.Clear();
            dataGridView2.Rows.Add("1.", ac1.ToString(), acolornumber1.ToString());
            dataGridView2.Rows.Add("2.", ac2.ToString(), acolornumber2.ToString());
            dataGridView2.Rows.Add("3.", ac3.ToString(), acolornumber3.ToString());
            dataGridView2.Rows.Add("4.", ac4.ToString(), acolornumber4.ToString());
            dataGridView2.Rows.Add("5.", ac5.ToString(), acolornumber5.ToString());
            dataGridView2.Rows.Add("6.", ac6.ToString(), acolornumber6.ToString());
            dataGridView2.Rows.Add("7.", ac7.ToString(), acolornumber7.ToString());
            dataGridView2.Rows.Add("8.", ac8.ToString(), acolornumber8.ToString());
            dataGridView2.Rows.Add("9.", ac9.ToString(), acolornumber9.ToString());
            dataGridView2.Rows.Add("10.", ac10.ToString(), acolornumber10.ToString());

            dataGridView3.Rows.Clear();
            dataGridView3.Rows.Add("1.", nc1.ToString(), ncolornumber1.ToString());
            dataGridView3.Rows.Add("2.", nc2.ToString(), ncolornumber2.ToString());
            dataGridView3.Rows.Add("3.", nc3.ToString(), ncolornumber3.ToString());
            dataGridView3.Rows.Add("4.", nc4.ToString(), ncolornumber4.ToString());
            dataGridView3.Rows.Add("5.", nc5.ToString(), ncolornumber5.ToString());
            dataGridView3.Rows.Add("6.", nc6.ToString(), ncolornumber6.ToString());
            dataGridView3.Rows.Add("7.", nc7.ToString(), ncolornumber7.ToString());
            dataGridView3.Rows.Add("8.", nc8.ToString(), ncolornumber8.ToString());
            dataGridView3.Rows.Add("9.", nc9.ToString(), ncolornumber9.ToString());
            dataGridView3.Rows.Add("10.", nc10.ToString(), ncolornumber10.ToString());
        }

        private void button14_Click(object sender, EventArgs e)
        {
            dataGridView5.Rows.Add();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView5.Rows.Remove(dataGridView5.CurrentRow); 
            }
            catch (Exception)
            {
                MessageBox.Show("No Rows Left");
            }
          
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            del.AddStudents(dataGridView5);


            try
            {
                conn = Connection.ConnectToServer();
                if (conn.State == ConnectionState.Open)
                {
                    SqlDataReader dr = del.AllStudents(conn);
                    if (dr.HasRows)
                    {
                        comboBox1.Items.Clear();
                        del.STUDI.Clear();
                        while (dr.Read())
                        {
                            comboBox1.Items.Add(dr[1].ToString() + ", " + dr[2].ToString() + " " + dr[3].ToString() + ".");
                            del.STUDI.Add(dr[0]);
                        }
                    }
                    else
                    {
                        comboBox1.Items.Clear();
                        del.STUDI.Clear();
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally { conn.Close(); }

            try
            {
                conn = Connection.ConnectToServer();
                if (conn.State == ConnectionState.Open)
                {
                    SqlDataReader dr = del.AllStudents1(conn);
                    if (dr.HasRows)
                    {
                        dataGridView4.Rows.Clear();
                        while (dr.Read())
                        {
                            dataGridView4.Rows.Add(dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString());
                            del.STUDI.Add(dr[0]);
                        }
                    }
                    else
                    {
                        dataGridView4.Rows.Clear();
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally { conn.Close(); }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            dataGridView5.Rows.Clear(); 
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            //del.ST = Convert.ToInt32(del.STUDIz[comboBox4.SelectedIndex]);
            //MessageBox.Show(
            try
            {
                del.STz = Convert.ToInt32(del.STUDIz[comboBox4.SelectedIndex]);
                del.TRz = Convert.ToInt32(del.TRIALIDz[comboBox3.SelectedIndex]);
                conn = Connection.ConnectToServer();
                if (conn.State == ConnectionState.Open)
                {
                    SqlDataReader dr = del.RealQuerryHard(conn);
                    if (dr.HasRows)
                    {
                        dataGridView8.Rows.Clear();
                        while (dr.Read())
                        {
                            dataGridView8.Rows.Add(dr[3].ToString(), dr[4].ToString());
                        }
                    }
                    else
                    {
                        dataGridView8.Rows.Clear();
                    }
                }
            }
            catch (Exception)
            {
                string x= "v";
            }

            try
            {
                del.STz = Convert.ToInt32(del.STUDIz[comboBox4.SelectedIndex]);
                del.TRz = Convert.ToInt32(del.TRIALIDz[comboBox3.SelectedIndex]);
                conn = Connection.ConnectToServer();
                if (conn.State == ConnectionState.Open)
                {
                    SqlDataReader dr = del.RealQuerryHard2(conn);
                    if (dr.HasRows)
                    {
                        dataGridView7.Rows.Clear();
                        while (dr.Read())
                        {
                            dataGridView7.Rows.Add(dr[3].ToString(), dr[4].ToString());
                        }
                    }
                    else
                    {
                        dataGridView7.Rows.Clear();
                    }
                }
            }
            catch (Exception)
            {
                string x = "v";
            }

            try
            {
                del.STz = Convert.ToInt32(del.STUDIz[comboBox4.SelectedIndex]);
                del.TRz = Convert.ToInt32(del.TRIALIDz[comboBox3.SelectedIndex]);
                conn = Connection.ConnectToServer();
                if (conn.State == ConnectionState.Open)
                {
                    SqlDataReader dr = del.RealQuerryHard3(conn);
                    if (dr.HasRows)
                    {
                        dataGridView6.Rows.Clear();
                        while (dr.Read())
                        {
                            dataGridView6.Rows.Add(dr[3].ToString(), dr[4].ToString());
                        }
                    }
                    else
                    {
                        dataGridView6.Rows.Clear();
                    }
                }
            }
            catch (Exception)
            {
                string x = "v";
            }


            try
            {
                del.STz = Convert.ToInt32(del.STUDIz[comboBox4.SelectedIndex]);
                del.TRz = Convert.ToInt32(del.TRIALIDz[comboBox3.SelectedIndex]);
                conn = Connection.ConnectToServer();
                if (conn.State == ConnectionState.Open)
                {
                    SqlDataReader dr = del.TotalCategory(conn);
                    if (dr.HasRows)
                    {
                        dataGridView9.Rows.Clear();
                        while (dr.Read())
                        {
                            dataGridView9.Rows.Add(dr[1].ToString(), dr[2].ToString(),dr[3].ToString());
                        }
                    }
                    else
                    {
                        dataGridView9.Rows.Clear();
                    }
                }
            }
            catch (Exception)
            {
                string x = "v";
            }

            try
            {
                del.STz = Convert.ToInt32(del.STUDIz[comboBox4.SelectedIndex]);
                del.TRz = Convert.ToInt32(del.TRIALIDz[comboBox3.SelectedIndex]);
                conn = Connection.ConnectToServer();
                if (conn.State == ConnectionState.Open)
                {
                    SqlDataReader dr = del.TotalCategoryALL(conn);
                    if (dr.HasRows)
                    {
                        dataGridView10.Rows.Clear();
                        while (dr.Read())
                        {
                            dataGridView10.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString());
                        }
                    }
                    else
                    {
                        dataGridView10.Rows.Clear();
                    }
                }
            }
            catch (Exception)
            {
                string x = "v";
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            //del.TR = Convert.ToInt32(del.TRIALIDz[comboBox3.SelectedIndex]);
            try
            {
                del.STz = Convert.ToInt32(del.STUDIz[comboBox4.SelectedIndex]);
                del.TRz = Convert.ToInt32(del.TRIALIDz[comboBox3.SelectedIndex]);
                conn = Connection.ConnectToServer();
                if (conn.State == ConnectionState.Open)
                {
                    SqlDataReader dr = del.RealQuerryHard(conn);
                    if (dr.HasRows)
                    {
                        dataGridView8.Rows.Clear();
                        while (dr.Read())
                        {
                            dataGridView8.Rows.Add(dr[3].ToString(), dr[4].ToString());
                        }
                    }
                    else
                    {
                        dataGridView8.Rows.Clear();
                    }
                }
            }
            catch (Exception)
            {
                string x = "v";
            }

            try
            {
                del.STz = Convert.ToInt32(del.STUDIz[comboBox4.SelectedIndex]);
                del.TRz = Convert.ToInt32(del.TRIALIDz[comboBox3.SelectedIndex]);
                conn = Connection.ConnectToServer();
                if (conn.State == ConnectionState.Open)
                {
                    SqlDataReader dr = del.RealQuerryHard2(conn);
                    if (dr.HasRows)
                    {
                        dataGridView7.Rows.Clear();
                        while (dr.Read())
                        {
                            dataGridView7.Rows.Add(dr[3].ToString(), dr[4].ToString());
                        }
                    }
                    else
                    {
                        dataGridView7.Rows.Clear();
                    }
                }
            }
            catch (Exception)
            {
                string x = "v";
            }

            try
            {
                del.STz = Convert.ToInt32(del.STUDIz[comboBox4.SelectedIndex]);
                del.TRz = Convert.ToInt32(del.TRIALIDz[comboBox3.SelectedIndex]);
                conn = Connection.ConnectToServer();
                if (conn.State == ConnectionState.Open)
                {
                    SqlDataReader dr = del.RealQuerryHard3(conn);
                    if (dr.HasRows)
                    {
                        dataGridView6.Rows.Clear();
                        while (dr.Read())
                        {
                            dataGridView6.Rows.Add(dr[3].ToString(), dr[4].ToString());
                        }
                    }
                    else
                    {
                        dataGridView6.Rows.Clear();
                    }
                }
            }
            catch (Exception)
            {
                string x = "v";
            }

            try
            {
                del.STz = Convert.ToInt32(del.STUDIz[comboBox4.SelectedIndex]);
                del.TRz = Convert.ToInt32(del.TRIALIDz[comboBox3.SelectedIndex]);
                conn = Connection.ConnectToServer();
                if (conn.State == ConnectionState.Open)
                {
                    SqlDataReader dr = del.TotalCategory(conn);
                    if (dr.HasRows)
                    {
                        dataGridView9.Rows.Clear();
                        while (dr.Read())
                        {
                            dataGridView9.Rows.Add(dr[1].ToString(), dr[2].ToString(), dr[3].ToString());
                        }
                    }
                    else
                    {
                        dataGridView9.Rows.Clear();
                    }
                }
            }
            catch (Exception)
            {
                string x = "v";
            }

            try
            {
                del.STz = Convert.ToInt32(del.STUDIz[comboBox4.SelectedIndex]);
                del.TRz = Convert.ToInt32(del.TRIALIDz[comboBox3.SelectedIndex]);
                conn = Connection.ConnectToServer();
                if (conn.State == ConnectionState.Open)
                {
                    SqlDataReader dr = del.TotalCategoryALL(conn);
                    if (dr.HasRows)
                    {
                        dataGridView10.Rows.Clear();
                        while (dr.Read())
                        {
                            dataGridView10.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString());
                        }
                    }
                    else
                    {
                        dataGridView10.Rows.Clear();
                    }
                }
            }
            catch (Exception)
            {
                string x = "v";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox149_Click(object sender, EventArgs e)
        {
            acolornumber1 = 0;
            pictureBox70.Visible = false;
            pictureBox69.Visible = false;
            pictureBox143.Visible = false;
            pictureBox144.Visible = true; 

        }

        private void pictureBox148_Click(object sender, EventArgs e)
        {
            acolornumber1 = 0;
            pictureBox69.Visible = false;
            pictureBox70.Visible = false;
            pictureBox143.Visible = true;
            pictureBox144.Visible = false; 
        }

        private void pictureBox155_Click(object sender, EventArgs e)
        {
            acolornumber2 = 0;
            pictureBox68.Visible = false;
            pictureBox67.Visible = false;
            pictureBox142.Visible = true;
            pictureBox141.Visible = false; 
        }

        private void pictureBox154_Click(object sender, EventArgs e)
        {
            acolornumber2 = 0;
            pictureBox68.Visible = false;
            pictureBox67.Visible = false;
            pictureBox142.Visible = false;
            pictureBox141.Visible = true; 
        }

        private void pictureBox153_Click(object sender, EventArgs e)
        {
            acolornumber3 = 0;
            pictureBox61.Visible = false;
            pictureBox62.Visible = false;
            pictureBox140.Visible = true;
            pictureBox139.Visible = false;
        }

        private void pictureBox152_Click(object sender, EventArgs e)
        {
            acolornumber3 = 0;
            pictureBox61.Visible = false;
            pictureBox62.Visible = false;
            pictureBox140.Visible = false;
            pictureBox139.Visible = true;
        }

        private void pictureBox151_Click(object sender, EventArgs e)
        {
            acolornumber4 = 0;
            pictureBox60.Visible = false;
            pictureBox59.Visible = false;
            pictureBox138.Visible = true;
            pictureBox137.Visible = false;
        }

        private void pictureBox150_Click(object sender, EventArgs e)
        {
            acolornumber4 = 0;
            pictureBox60.Visible = false;
            pictureBox59.Visible = false;
            pictureBox138.Visible = false;
            pictureBox137.Visible = true;
        }

        private void pictureBox166_Click(object sender, EventArgs e)
        {
            acolornumber5 = 0;
            pictureBox93.Visible = false;
            pictureBox92.Visible = false;
            pictureBox164.Visible = true;
            pictureBox163.Visible = false;
        }

        private void pictureBox165_Click(object sender, EventArgs e)
        {
            acolornumber5 = 0;
            pictureBox93.Visible = false;
            pictureBox92.Visible = false;
            pictureBox164.Visible = false;
            pictureBox163.Visible = true;
        }

        private void pictureBox172_Click(object sender, EventArgs e)
        {
            pictureBox91.Visible = false;
            pictureBox90.Visible = false;
            pictureBox162.Visible = true;
            pictureBox161.Visible = false;
            acolornumber6 = 0;
        }

        private void pictureBox171_Click(object sender, EventArgs e)
        {
            pictureBox162.Visible = false;
            pictureBox161.Visible = true;
            pictureBox91.Visible = false;
            pictureBox90.Visible = false;
            acolornumber6 = 0;
        }

        private void pictureBox170_Click(object sender, EventArgs e)
        {
            acolornumber7 = 0;
            pictureBox89.Visible = false;
            pictureBox88.Visible = false;
            pictureBox160.Visible = true;
            pictureBox159.Visible = false;
        }

        private void pictureBox169_Click(object sender, EventArgs e)
        {
            acolornumber7 = 0;
            pictureBox89.Visible = false;
            pictureBox88.Visible = false;
            pictureBox160.Visible = false;
            pictureBox159.Visible = true;
        }

        private void pictureBox168_Click(object sender, EventArgs e)
        {
            acolornumber8 = 0;
            pictureBox87.Visible = false;
            pictureBox86.Visible = false;
            pictureBox158.Visible = true;
            pictureBox157.Visible = false;
        }

        private void pictureBox167_Click(object sender, EventArgs e)
        {
            acolornumber8 = 0;
            pictureBox87.Visible = false;
            pictureBox86.Visible = false;
            pictureBox158.Visible = false;
            pictureBox157.Visible = true;
        }

        private void pictureBox178_Click(object sender, EventArgs e)
        {
            acolornumber9 = 0;
            pictureBox112.Visible = false;
            pictureBox111.Visible = false;
            pictureBox176.Visible = true;
            pictureBox175.Visible = false;
        }

        private void pictureBox177_Click(object sender, EventArgs e)
        {
            acolornumber9 = 0;
            pictureBox112.Visible = false;
            pictureBox111.Visible = false;
            pictureBox176.Visible = false;
            pictureBox175.Visible = true;
        }

        private void pictureBox180_Click(object sender, EventArgs e)
        {
            acolornumber10 = 0;
            pictureBox110.Visible = false;
            pictureBox109.Visible = false;
            pictureBox174.Visible = true;
            pictureBox173.Visible = false;
        }

        private void pictureBox179_Click(object sender, EventArgs e)
        {
            acolornumber10 = 0;
            pictureBox110.Visible = false;
            pictureBox109.Visible = false;
            pictureBox174.Visible = false;
            pictureBox173.Visible = true;
        }

        private void pictureBox66_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox190_Click(object sender, EventArgs e)
        {
            colornumber1 = 0;
            pictureBox43.Visible = false;
            pictureBox44.Visible = false;
            pictureBox188.Visible = true;
            pictureBox187.Visible = false;
        }

        private void pictureBox189_Click(object sender, EventArgs e)
        {
            colornumber1 = 0;
            pictureBox43.Visible = false;
            pictureBox44.Visible = false;
            pictureBox188.Visible = false;
            pictureBox187.Visible = true;
        }

        private void pictureBox196_Click(object sender, EventArgs e)
        {
            colornumber2 = 0;
            pictureBox45.Visible = false;
            pictureBox46.Visible = false;
            pictureBox186.Visible = true;
            pictureBox185.Visible = false;
        }

        private void pictureBox195_Click(object sender, EventArgs e)
        {
            colornumber2 = 0;
            pictureBox45.Visible = false;
            pictureBox46.Visible = false;
            pictureBox186.Visible = false;
            pictureBox185.Visible = true;
        }

        private void pictureBox194_Click(object sender, EventArgs e)
        {
            colornumber3 = 0;
            pictureBox47.Visible = false;
            pictureBox48.Visible = false;
            pictureBox184.Visible = true;
            pictureBox183.Visible = false;
        }

        private void pictureBox193_Click(object sender, EventArgs e)
        {
            colornumber3 = 0;
            pictureBox47.Visible = false;
            pictureBox48.Visible = false;
            pictureBox184.Visible = false;
            pictureBox183.Visible = true;
        }

        private void pictureBox192_Click(object sender, EventArgs e)
        {
            colornumber4 = 0;
            pictureBox49.Visible = false;
            pictureBox50.Visible = false;
            pictureBox182.Visible = true;
            pictureBox181.Visible = false;
        }

        private void pictureBox191_Click(object sender, EventArgs e)
        {
            colornumber4 = 0;
            pictureBox49.Visible = false;
            pictureBox50.Visible = false;
            pictureBox182.Visible = false;
            pictureBox181.Visible = true;
        }

        private void pictureBox206_Click(object sender, EventArgs e)
        {
            colornumber5 = 0;
            pictureBox57.Visible = false;
            pictureBox58.Visible = false;
            pictureBox204.Visible = true;
            pictureBox203.Visible = false;
        }

        private void pictureBox205_Click(object sender, EventArgs e)
        {
            colornumber5 = 0;
            pictureBox57.Visible = false;
            pictureBox58.Visible = false;
            pictureBox204.Visible = false;
            pictureBox203.Visible = true;
        }

        private void pictureBox212_Click(object sender, EventArgs e)
        {
            colornumber6 = 0;
            pictureBox55.Visible = false;
            pictureBox56.Visible = false;
            pictureBox202.Visible = true;
            pictureBox201.Visible = false;
        }

        private void pictureBox211_Click(object sender, EventArgs e)
        {
            colornumber6 = 0;
            pictureBox55.Visible = false;
            pictureBox56.Visible = false;
            pictureBox202.Visible = false;
            pictureBox201.Visible = true;
        }

        private void pictureBox210_Click(object sender, EventArgs e)
        {
            colornumber7 = 0;
            pictureBox53.Visible = false;
            pictureBox54.Visible = false;
            pictureBox200.Visible = true;
            pictureBox199.Visible = false;
        }

        private void pictureBox209_Click(object sender, EventArgs e)
        {
            colornumber7 = 0;
            pictureBox53.Visible = false;
            pictureBox54.Visible = false;
            pictureBox200.Visible = false;
            pictureBox199.Visible = true;
        }

        private void pictureBox208_Click(object sender, EventArgs e)
        {
            colornumber8 = 0;
            pictureBox51.Visible = false;
            pictureBox52.Visible = false;
            pictureBox198.Visible = true;
            pictureBox197.Visible = false;
        }

        private void pictureBox207_Click(object sender, EventArgs e)
        {
            colornumber8 = 0;
            pictureBox51.Visible = false;
            pictureBox52.Visible = false;
            pictureBox198.Visible = false;
            pictureBox197.Visible = true;
        }

        private void pictureBox218_Click(object sender, EventArgs e)
        {
            colornumber9 = 0;
            pictureBox65.Visible = false;
            pictureBox66.Visible = false;
            pictureBox216.Visible = true;
            pictureBox215.Visible = false;
        }

        private void pictureBox217_Click(object sender, EventArgs e)
        {
            colornumber9 = 0;
            pictureBox65.Visible = false;
            pictureBox66.Visible = false;
            pictureBox216.Visible = false;
            pictureBox215.Visible = true;
        }

        private void pictureBox220_Click(object sender, EventArgs e)
        {
            colornumber10 = 0;
            pictureBox63.Visible = false;
            pictureBox64.Visible = false;
            pictureBox214.Visible = true;
            pictureBox213.Visible = false;
        }

        private void pictureBox219_Click(object sender, EventArgs e)
        {
            colornumber10 = 0;
            pictureBox63.Visible = false;
            pictureBox64.Visible = false;
            pictureBox214.Visible = false;
            pictureBox213.Visible = true;
        }

        private void label138_Click(object sender, EventArgs e)
        {
            ncolornumber1 = 0;
            pictureBox108.Visible = false;
            pictureBox107.Visible = false;
            pictureBox228.Visible = true;
            pictureBox227.Visible = false;
        }

        private void label133_Click(object sender, EventArgs e)
        {
            ncolornumber1 = 0;
            pictureBox108.Visible = false;
            pictureBox107.Visible = false;
            pictureBox228.Visible = false;
            pictureBox227.Visible = true;
        }

        private void label136_Click(object sender, EventArgs e)
        {
            ncolornumber2 = 0;
            pictureBox106.Visible = false;
            pictureBox105.Visible = false;
            pictureBox226.Visible = true;
            pictureBox225.Visible = false;
        }

        private void label131_Click(object sender, EventArgs e)
        {
            ncolornumber2 = 0;
            pictureBox106.Visible = false;
            pictureBox105.Visible = false;
            pictureBox226.Visible = false;
            pictureBox225.Visible = true;
        }

        private void label135_Click(object sender, EventArgs e)
        {
            ncolornumber3 = 0;
            pictureBox85.Visible = false;
            pictureBox84.Visible = false;
            pictureBox224.Visible = true;
            pictureBox223.Visible = false;
        }

        private void label130_Click(object sender, EventArgs e)
        {
            ncolornumber3 = 0;
            pictureBox85.Visible = false;
            pictureBox84.Visible = false;
            pictureBox224.Visible = false;
            pictureBox223.Visible = true;
        }

        private void label134_Click(object sender, EventArgs e)
        {
            ncolornumber4 = 0;
            pictureBox83.Visible = false;
            pictureBox82.Visible = false;
            pictureBox222.Visible = true;
            pictureBox221.Visible = false;
        }

        private void label129_Click(object sender, EventArgs e)
        {
            ncolornumber4 = 0;
            pictureBox83.Visible = false;
            pictureBox82.Visible = false;
            pictureBox222.Visible = false;
            pictureBox221.Visible = true;
        }

        private void label165_Click(object sender, EventArgs e)
        {
            ncolornumber5 = 0;
            pictureBox125.Visible = false;
            pictureBox124.Visible = false;
            pictureBox236.Visible = true;
            pictureBox235.Visible = false; 
        }

        private void label161_Click(object sender, EventArgs e)
        {
            ncolornumber5 = 0;
            pictureBox125.Visible = false;
            pictureBox124.Visible = false;
            pictureBox236.Visible = false;
            pictureBox235.Visible = true; 
        }

        private void label164_Click(object sender, EventArgs e)
        {
            ncolornumber6 = 0;
            pictureBox123.Visible = false;
            pictureBox122.Visible = false;
            pictureBox234.Visible = true;
            pictureBox233.Visible = false;
        }

        private void label160_Click(object sender, EventArgs e)
        {
            ncolornumber6 = 0;
            pictureBox123.Visible = false;
            pictureBox122.Visible = false;
            pictureBox234.Visible = false;
            pictureBox233.Visible = true;
        }

        private void label163_Click(object sender, EventArgs e)
        {
            ncolornumber7 = 0;
            pictureBox121.Visible = false;
            pictureBox120.Visible = false;
            pictureBox232.Visible = true;
            pictureBox231.Visible = false;
        }

        private void label159_Click(object sender, EventArgs e)
        {
            ncolornumber7 = 0;
            pictureBox121.Visible = false;
            pictureBox120.Visible = false;
            pictureBox232.Visible = false;
            pictureBox231.Visible = true;
        }

        private void label162_Click(object sender, EventArgs e)
        {
            ncolornumber8 = 0;
            pictureBox119.Visible = false;
            pictureBox118.Visible = false;
            pictureBox230.Visible = true;
            pictureBox229.Visible = false; 
        }

        private void label158_Click(object sender, EventArgs e)
        {
            ncolornumber8 = 0;
            pictureBox119.Visible = false;
            pictureBox118.Visible = false;
            pictureBox230.Visible = false;
            pictureBox229.Visible = true;
        }

        private void label183_Click(object sender, EventArgs e)
        {
            pictureBox136.Visible = false;
            pictureBox135.Visible = false;
            pictureBox238.Visible = true;
            pictureBox240.Visible = false;
            ncolornumber9 = 0;
        }

        private void label185_Click(object sender, EventArgs e)
        {
            ncolornumber9 = 0;
            pictureBox136.Visible = false;
            pictureBox135.Visible = false;
            pictureBox238.Visible = false;
            pictureBox240.Visible = true;
        }

        private void label182_Click(object sender, EventArgs e)
        {
            ncolornumber10 = 0;
            pictureBox134.Visible = false;
            pictureBox133.Visible = false;
            pictureBox237.Visible = true;
            pictureBox239.Visible = false; 
        }

        private void label184_Click(object sender, EventArgs e)
        {
            ncolornumber10 = 0;
            pictureBox134.Visible = false;
            pictureBox133.Visible = false;
            pictureBox237.Visible = false;
            pictureBox239.Visible = true; 
        }

        private void pictureBox236_Click(object sender, EventArgs e)
        {

        }
    }
}
