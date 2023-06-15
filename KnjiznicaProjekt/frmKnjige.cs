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
    public partial class frmKnjige : Form
    {
        public frmKnjige()
        {
            InitializeComponent();
        }

        private void knjigeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.knjigeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.knjiznicaProjektDataSet);

        }

        private void frmKnjige_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'knjiznicaProjektDataSet.Knjige' table. You can move, or remove it, as needed.
            this.knjigeTableAdapter.Fill(this.knjiznicaProjektDataSet.Knjige);

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                textBox1.Show();
                button1.Show();
            }
            else
            {
                textBox1.Hide();    
                button1.Hide(); 
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                textBox2.Show();
                button2.Show();
            }
            else
            {
                textBox2.Hide();
                button2.Hide();
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                textBox3.Show();
                button3.Show();
            }
            else
            {
                textBox3.Hide();
                button3.Hide();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string Naslov = textBox1.Text;
            knjigeTableAdapter.FillByNaslov(knjiznicaProjektDataSet.Knjige, Naslov);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Autor = textBox2.Text;
            knjigeTableAdapter.FillByAutorf(knjiznicaProjektDataSet.Knjige, Autor);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string Zanr = textBox3.Text;
            knjigeTableAdapter.FillByZarnf(knjiznicaProjektDataSet.Knjige, Zanr);
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e){}
        private void fillByNaslovToolStripButton_Click(object sender, EventArgs e){}
        private void fillByAutorToolStripButton_Click(object sender, EventArgs e){}
        private void fillByAutorfToolStripButton_Click(object sender, EventArgs e){}
        private void fillByZarnfToolStripButton_Click(object sender, EventArgs e){}
    }
}
