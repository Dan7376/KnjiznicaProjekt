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

namespace KnjiznicaProjekt
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = Properties.Settings.Default.KnjiznicaProjektConnectionString;
            connection.Open();
            String txtUser = textBox1.Text;
            String txtPass = textBox2.Text;
            string query = "SELECT * FROM Login WHERE Username=@user AND Password=@pass";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.Add(new SqlParameter("@user", txtUser));
            cmd.Parameters.Add(new SqlParameter("@pass", txtPass));
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows == true)
            {
                MessageBox.Show("Welcome");
                Form frm = new Form1();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Pogrešna korisničko ime i lozinka");
                button2.Show();
            }
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form form=new frmPodaci();
            form.ShowDialog();
            textBox1.Text = "";
            textBox2.Text = "";
        }
    }
}
