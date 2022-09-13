using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace VisualProject
{
    public partial class Form1 : Form
    {
        MyConnection db = new MyConnection();

        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=VisualProject_DB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button_login_Click(object sender, EventArgs e)
        {
            //String Staff_Name, password;

            //Staff_Name = txt_username.Text;
           // password = txt_password.Text;
            try
            {
               using (db.con)
                {
                    SqlCommand cmd = new SqlCommand("sp_role_login", db.con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    db.con.Open();
                    cmd.Parameters.AddWithValue("@uname", txt_username.Text);
                    cmd.Parameters.AddWithValue("@upass", txt_password.Text);

                    SqlDataReader rd = cmd.ExecuteReader();
                  
                     if (rd.HasRows)
                        {
                            rd.Read();
                            if (rd[4].ToString() == "Manager")
                            {
                                MyConnection.type = "M";

                            }
                            else if (rd[4].ToString() == "Staff")
                            {
                                MyConnection.type = "S";
                            }
                            MainForm f = new MainForm();
                            f.Show();
                            this.Hide();

                        }
                        else
                        {
                            MessageBox.Show("Error Login");
                        }
                    
                   
                }

                
            }
            catch
            {
                MessageBox.Show("Error");
            }
            finally
            {
                con.Close();
            }

        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            txt_username.Clear();
            txt_password.Clear();
            //comboBox1.SelectedItem = "";
            txt_username.Focus();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Do you want to exit", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                this.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
