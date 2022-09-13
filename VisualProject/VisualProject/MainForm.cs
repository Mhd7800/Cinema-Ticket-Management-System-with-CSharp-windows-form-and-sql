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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        MyConnection db = new MyConnection();
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=VisualProject_DB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        private void MainForm_Load(object sender, EventArgs e)
        {

        
            if (MyConnection.type=="M")
            {
                
                pictureBox1.Visible = true;
                pictureBox2.Visible = true;
                pictureBox4.Visible = true;
            }
            else if (MyConnection.type == "S")
            {
                
                pictureBox1.Visible = false;
                label4.Visible = false;
                pictureBox2.Visible = true;
                pictureBox4.Visible = true;
            }

           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            ClientInfo ekle = new ClientInfo();
            ekle.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Movie_Operations ekle = new Movie_Operations();
            ekle.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DataGridView_Staff ekle = new DataGridView_Staff();
            ekle.Show();

            this.Hide();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            
            
        }
    }
}
