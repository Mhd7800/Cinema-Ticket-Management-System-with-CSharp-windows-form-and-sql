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
    public partial class Add_Room : Form
    {
        public Add_Room()
        {
            InitializeComponent();
        }

        private void Add_Room_Load(object sender, EventArgs e)
        {
             
        }
        CinemaTableAdapters.Room_TableTableAdapter room = new CinemaTableAdapters.Room_TableTableAdapter();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                room.AddingRoom(Room_Name.Text);
                MessageBox.Show("Room added", "Register");
            }
            catch (Exception)
            {
                
                MessageBox.Show("You added the same Room before !", "Attention");

                
            }
            Room_Name.Text = "";

        }

        private void Add_Room_FormClosing(object sender, FormClosingEventArgs e)
        {
            Movie_Operations mainform = new Movie_Operations();
            mainform.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void Room_Name_TextChanged(object sender, EventArgs e)
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
