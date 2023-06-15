using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KnjiznicaProjekt
{
    public partial class frmPosuditelji : Form
    {
        public frmPosuditelji()
        {
            InitializeComponent();
        }

        private void posuditeljiBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.posuditeljiBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.knjiznicaProjektDataSet);

        }

        private void frmPosuditelji_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'knjiznicaProjektDataSet.Posuditelji' table. You can move, or remove it, as needed.
            this.posuditeljiTableAdapter.Fill(this.knjiznicaProjektDataSet.Posuditelji);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Email = textBox1.Text;
            posuditeljiTableAdapter.FillByEmail(knjiznicaProjektDataSet.Posuditelji, Email);
        }

        private void fillByIDToolStripButton_Click(object sender, EventArgs e){}
        private void fillByEmailToolStripButton_Click(object sender, EventArgs e) { }

        private void button2_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(numericUpDown1.Value);
            posuditeljiTableAdapter.FillByID(knjiznicaProjektDataSet.Posuditelji, ID);
        }
    }
}
