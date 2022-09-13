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
   
    public partial class Movie_Operations : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=VisualProject_DB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        public Movie_Operations()
        {
            InitializeComponent();
        }
        int counter;
        private void Bring_Movie_Salon(ComboBox combo , string sql1, string sql2)
        {
            con.Open();
            SqlCommand com = new SqlCommand(sql1,con);
            SqlDataReader read = com.ExecuteReader();
            while (read.Read())
            {
                combo.Items.Add(read[sql2].ToString());
            }
            con.Close();


        }

        private void Combo_Dolu_Koltuklar ()
        {
            comboBox_Seat.Items.Clear();
            comboBox_Seat.Text = "";
            foreach (Control item in panel2.Controls)
            {
                if (item is Button)
                {
                    if (item.BackColor== Color.Red)
                    {
                        comboBox_Seat.Items.Add(item.Text);
                    }
                }
            }
        }
        private void YenidenRenklerdir()
        {
            foreach(Control item in panel2.Controls)
            {
                if (item is Button)
                {
                    item.BackColor = Color.White;
                }
            }
        }
        private void Veritabani_Dolu_Koltuklar ()
        {

            con.Open();
            SqlCommand komut = new SqlCommand("select *from Sales_Info where MovieName = '"+Movie_name_comboBox1.SelectedItem+"' and RoomName= '"+ Salon_Name_comboBox2 .Text+ "' and Date = '"+Movie_date_comboBox3.Text+"' and Hour  = '"+ Movie_session_cb.SelectedItem + "' ", con);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                foreach (Control item in panel2.Controls)
                {
                    if(item is Button)
                    {
                        if (read["SeatNo"].ToString() == item.Text)
                        {
                            item.BackColor = Color.Red;
                        }
                        
                    }
                }

            }
            con.Close();
        }
        private void Movie_Operations_Load(object sender, EventArgs e)
        {
            Empty_Seat();
            Bring_Movie_Salon(Movie_name_comboBox1 ,"select * from Movie_Info","MovieName");
            Bring_Movie_Salon(Salon_Name_comboBox2, "select * from Room_Table", "RoomName");
            //Film_Seansi_Getir();
            //Film__Tarihi_Getir();
        }

        private void Empty_Seat()
        {
            counter = 1;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Button btn = new Button();
                    btn.Size = new Size(30, 30);
                    btn.BackColor = Color.White;
                    btn.Location = new Point(j * 30 + 20, i * 30 + 30);
                    btn.Name = counter.ToString();
                    btn.Text = counter.ToString();
                    if (j == 4)
                    {
                        continue;
                    }
                    counter++;
                    this.panel2.Controls.Add(btn);
                    btn.Click += Btn_Click;

                }
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.BackColor== Color.White)
            {
                Seat_number_textBox1.Text = b.Text;
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddRoom_btn_Click(object sender, EventArgs e)
        {
            Add_Room ekle = new Add_Room();
            ekle.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Add_Movie ekle = new Add_Movie();
            ekle.Show();
            this.Hide();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add_Session ekle = new Add_Session();
            ekle.Show();
            this.Hide();
        }

        private void Movie_Operations_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 formb = new Form1();
            formb.ShowDialog();
            this.Hide();
        }
       
        private void button4_Click(object sender, EventArgs e)
        {


            Seans_List form = new Seans_List();
            form.Show();
            this.Hide();
            //seance_list form = new seance_list();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Sales_list form = new Sales_list();
            form.Show();
            this.Hide();
        }
        private void Movie_Show()
        {
            con.Open();
            SqlCommand comm = new SqlCommand("select *from Movie_Info where MovieName = '"+ Movie_name_comboBox1.SelectedItem + "' ",con);
            SqlDataReader read = comm.ExecuteReader();
            while (read.Read())
            {
                pictureBox1.ImageLocation = read["Picture"].ToString();
            }
            con.Close();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Movie_name_comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Movie_session_cb.Items.Clear();
            Movie_date_comboBox3.Items.Clear();
            Movie_session_cb.Text = "";
            Movie_date_comboBox3.Text = "";

            Salon_Name_comboBox2.Text = "";
            foreach (Control item in groupBox1.Controls) if (item is TextBox) item.Text = "";

            Movie_Show();
           // Film__Tarihi_Getir();
            YenidenRenklerdir();
            Combo_Dolu_Koltuklar();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        CinemaTableAdapters.Sales_InfoTableAdapter satis = new CinemaTableAdapters.Sales_InfoTableAdapter();
        private void buy_btn_Click(object sender, EventArgs e)
        {
            if(Seat_number_textBox1.Text!="")
            {
                try
                {
                  
                satis.Satis_Yap(Seat_number_textBox1.Text, Salon_Name_comboBox2.Text, Movie_name_comboBox1.Text, Movie_date_comboBox3.Text, Movie_session_cb.Text, Name_tb.Text, Price_cb.Text, DateTime.Now.ToString());
                    foreach (Control item in groupBox1.Controls) if (item is TextBox) item.Text = "";
                    YenidenRenklerdir();
                    Veritabani_Dolu_Koltuklar();
                    Combo_Dolu_Koltuklar();
                }
                catch (Exception hata)
                {

                MessageBox.Show("Error"+hata.Message, "Attention");
                }
            }
            else
            {
                MessageBox.Show("You did not choose a Seat", "Attention");
            }
        }

        private void Film__Tarihi_Getir()
        {
           Movie_date_comboBox3.Text = "";
           Movie_session_cb.Text = "";
           Movie_date_comboBox3.Items.Clear(); 
            Movie_session_cb.Items.Clear();
            con.Open();
            SqlCommand komut = new SqlCommand("select *from SessionInfo where MovieName ='" + Movie_name_comboBox1.SelectedItem + "' and RoomName = '"+Salon_Name_comboBox2.SelectedItem+"' "  ,  con);
            SqlDataReader read = komut.ExecuteReader();

            while (read.Read())
            {
               if(DateTime.Parse(read["Date"].ToString()) >= DateTime.Parse(DateTime.Now.ToShortDateString()))
                   
                {
                    if (!Movie_date_comboBox3.Items.Contains(read["Date"].ToString()))
                        {
                        Movie_date_comboBox3.Items.Add(read["Date"].ToString());
                       }
               }
               

                //Movie_date_comboBox3.Items.Add(read["Date"].ToString());
            }

            con.Close();

        }

        private void Film_Seansi_Getir ()
        {
            Movie_session_cb.Text = "";
            Movie_session_cb.Items.Clear();
            con.Open();
            SqlCommand komut = new SqlCommand("select *from SessionInfo where MovieName ='" + Movie_name_comboBox1.SelectedItem + "' and RoomName = '" + Salon_Name_comboBox2.SelectedItem + "' and Date= '"+ Movie_date_comboBox3.SelectedItem + "'", con);
            SqlDataReader read = komut.ExecuteReader();

            while (read.Read())
            {
                if (DateTime.Parse(read["Date"].ToString()) == DateTime.Parse(DateTime.Now.ToShortDateString()))
                {
                        if (DateTime.Parse(read["Session"].ToString())>DateTime.Parse(DateTime.Now.ToShortTimeString()))
                   {
                        Movie_session_cb.Items.Add(read["Session"].ToString());

                    }
                    
                        
                    
                }
               else if (DateTime.Parse(read["Date"].ToString()) > DateTime.Parse(DateTime.Now.ToShortDateString()))
                {

                    Movie_session_cb.Items.Add(read["Session"].ToString());

                }

            }
            con.Close();
        }
        
        private void Salon_Name_comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Film__Tarihi_Getir();
        }

        private void Movie_session_comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Film_Seansi_Getir();
            YenidenRenklerdir();
            Veritabani_Dolu_Koltuklar();
            Combo_Dolu_Koltuklar();
        }

        private void Movie_date_comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            Film_Seansi_Getir();
            /*YenidenRenklerdir();
            Veritabani_Dolu_Koltuklar();
            Combo_Dolu_Koltuklar();*/
        }

        private void comboBox_Seat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Cancel_btn_Click(object sender, EventArgs e)
        {
            if(comboBox_Seat.Text!="")
            {
                try
                {
                    satis.Satis_Iptal(Movie_name_comboBox1.Text, Salon_Name_comboBox2.Text, Movie_date_comboBox3.Text, Movie_session_cb.Text, comboBox_Seat.Text);
                    YenidenRenklerdir();
                    Veritabani_Dolu_Koltuklar();
                    Combo_Dolu_Koltuklar();
                }
                catch (Exception hata)
                {

                    MessageBox.Show("An Error Occured"+hata.Message, "Attention");

                }

            }
            else
            {
                MessageBox.Show("You did not choose a seat", "Attention");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MainForm form = new MainForm();
            form.Show();
            this.Hide();
        }
    }
}
