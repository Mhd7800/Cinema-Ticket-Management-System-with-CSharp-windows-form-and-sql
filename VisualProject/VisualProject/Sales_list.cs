using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VisualProject
{
    public partial class Sales_list : Form
    {
        public Sales_list()
        {
            InitializeComponent();
        }


        CinemaTableAdapters.Sales_InfoTableAdapter Sale_List = new CinemaTableAdapters.Sales_InfoTableAdapter();


        private void Sales_list_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Sale_List.List_With_Date2(dateTimePicker1.Text);
            Count_Total_sum();
        }

        private void Count_Total_sum()
        {
            int pricesum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                pricesum += Convert.ToInt32(dataGridView1.Rows[i].Cells["Price"].Value);

            }
            label1.Text = "Sum Sales =" + pricesum + "Tl";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Sale_List.SalesList2();
            Count_Total_sum();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Sale_List.List_With_Date2(dateTimePicker1.Text);
            Count_Total_sum();
        }

        private void Sales_list_FormClosing(object sender, FormClosingEventArgs e)
        {
            Movie_Operations form = new Movie_Operations();
            form.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Movie_Operations m = new Movie_Operations();
            m.Show(); 
            Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
