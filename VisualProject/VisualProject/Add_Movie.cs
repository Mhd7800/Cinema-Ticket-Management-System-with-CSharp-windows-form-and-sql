using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VisualProject
{
    public partial class Add_Movie : Form
    {
        public Add_Movie()
        {
            InitializeComponent();
        }
        


        private void Add_Movie_FormClosing(object sender, FormClosingEventArgs e)
        {
            Movie_Operations mainform = new Movie_Operations();
            mainform.ShowDialog();
            this.Hide();
        }

        private void choose_btn_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;

        }
        //  CinemaTableAdapters.Movie_InfoTableAdapter movie = new CinemaTableAdapters.Movie_InfoTableAdapter();
        CinemaTableAdapters.Movie_InfoTableAdapter movie = new CinemaTableAdapters.Movie_InfoTableAdapter();

       
        private void button1_Click(object sender, EventArgs e)
        {
            try
           {

                movie.FilEkleme(MovieName_tb.Text, Manager_tb.Text, FilmType_tb.Text, Time_tb.Text, DateTimePicker_tb.Text, ReleaseYear_tb.Text, pictureBox1.ImageLocation);
                MessageBox.Show("Movie Info added", "Add Movie");
           }
            catch (Exception)
            {

                
                MessageBox.Show("You added the same Movie before", "Attention");


           }
            
           foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            FilmType_tb.Text = "";
        }

        private void Add_Movie_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
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
