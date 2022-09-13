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
    public partial class Seans_List : Form
    {
        public Seans_List()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=VisualProject_DB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        DataTable table = new DataTable();
        private void seansList(string sql)
        {
            con.Open();
            SqlDataAdapter adtr = new SqlDataAdapter(sql,con);
            adtr.Fill(table);
            Seans_dataGridView1.DataSource = table;
            con.Close();


        }
        private void Seans_List_Load(object sender, EventArgs e)
        {
            table.Clear();
            seansList("select *from SessionInfo where Date like '" + Seans_dateTimePicker1.Text + "'");
        }

        private void Seans_dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            table.Clear();
            seansList("select *from SessionInfo where Date like '" + Seans_dateTimePicker1.Text + "'");

        }

        private void Seans_Add_btn_Click(object sender, EventArgs e)
        {
            table.Clear();
            seansList("select *from SessionInfo ");

        }

        private void Seans_List_FormClosing(object sender, FormClosingEventArgs e)
        {
            Movie_Operations mainform = new Movie_Operations();
            mainform.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Movie_Operations m = new Movie_Operations();
            m.Show(); 
            Hide();
        }
    }
}
