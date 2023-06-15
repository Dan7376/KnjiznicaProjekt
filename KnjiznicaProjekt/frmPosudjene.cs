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
    public partial class frmPosudjene : Form
    {
        public frmPosudjene()
        {
            InitializeComponent();
        }

        private void frmPosudjene_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'knjiznicaProjektDataSet.PosudeneKnjige' table. You can move, or remove it, as needed.
            this.posudeneKnjigeTableAdapter.Fill(this.knjiznicaProjektDataSet.PosudeneKnjige);

        }

        private void fillByKnjigaToolStripButton_Click(object sender, EventArgs e){}

        private void button1_Click(object sender, EventArgs e)
        {
            string Knjiga = textBox1.Text;
            posudeneKnjigeTableAdapter.FillByKnjiga(knjiznicaProjektDataSet.PosudeneKnjige, Knjiga);
        }

        private void fillByKnjigaToolStripButton_Click_1(object sender, EventArgs e)
        {
            

        }
    }
}
