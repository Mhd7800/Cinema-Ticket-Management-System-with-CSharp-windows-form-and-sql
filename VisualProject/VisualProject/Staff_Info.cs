using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace VisualProject
{
    public partial class DataGridView_Staff : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=VisualProject_DB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        SqlDataAdapter sda;
        SqlCommandBuilder scb;
        DataTable dt;
        
        public DataGridView_Staff()
        {
            InitializeComponent();
        }

        private void Staff_Info_Load(object sender, EventArgs e)
        {
            Date.Text = DateTime.Now.ToShortTimeString();
            timer1.Start();
        }

        private void StaffEdit_button_Click(object sender, EventArgs e)
        {

            scb = new SqlCommandBuilder(sda);
            sda.Update(dt);
        }

        

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void Staff_Search_button_Click(object sender, EventArgs e)
        {
            con.Open();
            string Myqueery = "select * from Staff_Table where Staff_Name = '" + Staff_Search_tb.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(Myqueery, con);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }

        
        private void DataGridView_Staff_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 m = new Form1();
            m.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainForm m = new MainForm(); 
            m.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            sda = new SqlDataAdapter(@"SELECT Staff_Name, password, Staff_Id, Staff_Number, Staff_Gender,Staff_Adress FROM Staff_Table ",con);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Date_Click(object sender, EventArgs e)
        {
            Date.Text = DateTime.Now.ToShortTimeString();
            timer1.Start();
        }
    }
}
