using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VisualProject
{
    public partial class Add_Session : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=VisualProject_DB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        public Add_Session()
        {
            InitializeComponent();
        }

        CinemaTableAdapters.SessionInfoTableAdapter Filmseansi = new CinemaTableAdapters.SessionInfoTableAdapter();

        private void Add_Session_Load(object sender, EventArgs e)
        {
            filmvesalonGoster(comboBoxfilm_tb,"select *from Movie_Info", "MovieName");
            filmvesalonGoster(ComboRoom_tb,"select *from Room_Table", "RoomName");


        }

       


        private void Tarihi_Karsilastir()
                {
                    con.Open();
            SqlCommand komut = new SqlCommand("select *from SessionInfo where RoomName = '" + ComboRoom_tb.Text + "' and Date = '" + dateTimePicker2_tb.Text + "' ", con);
                    SqlDataReader read = komut.ExecuteReader();
                    while (read.Read() == true)
                    {
                        foreach (Control item2 in groupBox1.Controls)
                        {
                            if (read["Session"].ToString() == item2.Text)
                            {
                                item2.Enabled = false;
                            }

                        }
                    }
                    con.Close();
                }
                
         
        string seans = "";

        private void Radionbuttonseciliyse ()
        {
            if (radioButton1.Checked == true) seans = radioButton1.Text;
            else if (radioButton2.Checked == true) seans = radioButton2.Text;
            else if (radioButton3.Checked == true) seans = radioButton3.Text;
            else if (radioButton4.Checked == true) seans = radioButton4.Text;
            else if (radioButton5.Checked == true) seans = radioButton5.Text;
            else if (radioButton6.Checked == true) seans = radioButton6.Text;
            else if (radioButton7.Checked == true) seans = radioButton7.Text;
            else if (radioButton8.Checked == true) seans = radioButton8.Text;
            else if (radioButton9.Checked == true) seans = radioButton9.Text;
            else if (radioButton10.Checked == true) seans = radioButton10.Text;
            else if (radioButton11.Checked == true) seans = radioButton11.Text;
            else if (radioButton12.Checked == true) seans = radioButton12.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Radionbuttonseciliyse();
            if (seans != "")
            {
                
                Filmseansi.SeansEkleme(comboBoxfilm_tb.Text, ComboRoom_tb.Text, dateTimePicker2_tb.Text, seans); 
                MessageBox.Show("Session Added", "Register");

            } 
            else if (seans =="")
            {
                MessageBox.Show("You must choose a session", "Attention");
            }
            ComboRoom_tb.Text="";
            comboBoxfilm_tb.Text = "";
            dateTimePicker2_tb.Text = DateTime.Now.ToString();

        }
        //lConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=VisualProject_DB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            private void filmvesalonGoster(ComboBox combo, string sql, string sql2)
            {
                con.Open();
                SqlCommand komut = new SqlCommand(sql, con);
                SqlDataReader read = komut.ExecuteReader();
                while (read.Read()==true)
                {
                combo.Items.Add(read[sql2].ToString());
                }
                con.Close();
        }
        private void dateTimePicker2_tb_ValueChanged(object sender, EventArgs e)
        {
            foreach (Control item3 in groupBox1.Controls)
            {
                item3.Enabled = true;
            }

            DateTime bugun = DateTime.Parse(DateTime.Now.ToShortDateString());
            DateTime yeni = DateTime.Parse(dateTimePicker2_tb.Text);
            if (yeni == bugun)
            {
                foreach (Control item in groupBox1.Controls)
                {
                    if (DateTime.Parse(DateTime.Now.ToShortTimeString()) > DateTime.Parse(item.Text))
                    {
                        item.Enabled = false;
                    }
                }

                Tarihi_Karsilastir();
            }
            else if (yeni > bugun)
            {
                Tarihi_Karsilastir();
            }
            else if (yeni < bugun)
            {
                MessageBox.Show("You can not go back ", "Attention");
                dateTimePicker2_tb.Text = DateTime.Now.ToShortDateString();
            }
        }

        private void Add_Session_FormClosing(object sender, FormClosingEventArgs e)
        {
            Movie_Operations mainform = new Movie_Operations();
            mainform.ShowDialog();
            this.Hide();
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ComboRoom_tb_SelectedIndexChanged(object sender, EventArgs e)
        {
            dateTimePicker2_tb.Text = DateTime.Now.ToShortDateString();


        }

        private void comboBoxfilm_tb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Movie_Operations m = new Movie_Operations(); 
            m.Show(); 
            Hide();
        }
    }
}
