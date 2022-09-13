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
    public partial class ClientInfo : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=VisualProject_DB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        SqlDataAdapter sda;
        SqlCommandBuilder scb;
        DataTable dt;
       
        public ClientInfo()

        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
       
        private void ClientInfo_Load(object sender, EventArgs e)
        {
            Date.Text = DateTime.Now.ToShortTimeString();
            timer1.Start();
            //populate();
        }
        private void Date_Table_Click(object sender, EventArgs e)
        {
            Date.Text = DateTime.Now.ToShortTimeString();
            timer1.Start();
        }

       

    /*    private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }*/

        




        private void edit_button_Click(object sender, EventArgs e)
        {
            scb = new SqlCommandBuilder(sda);
            sda.Update(dt);
        }

        private void Search_button_Click(object sender, EventArgs e)
        {
            con.Open();
            string Myqueery = "select * from Client_Table where ClientName = '"+Search_tb.Text+"'";
            SqlDataAdapter da = new SqlDataAdapter(Myqueery, con);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            DataGridView.DataSource = ds.Tables[0];
            con.Close();
        }

        private void ClientInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
             MainForm m = new MainForm();
            m.ShowDialog();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainForm m = new MainForm(); 
            m.Show(); 
            Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void show_btn_Click(object sender, EventArgs e)
        {
            sda = new SqlDataAdapter(@"SELECT Name, MovieName,RoomName, Date, Hour, Price, Date2 FROM Sales_Info", con);
            dt = new DataTable();
            sda.Fill(dt);
            DataGridView.DataSource = dt;
           

        }

        private void DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
