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
    public partial class frmTransakcije : Form
    {
        public frmTransakcije()
        {
            InitializeComponent();
        }

        private void transakcijeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.transakcijeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.knjiznicaProjektDataSet);

        }

        private void frmTransakcije_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'knjiznicaProjektDataSet.Posuditelji' table. You can move, or remove it, as needed.
            this.posuditeljiTableAdapter.Fill(this.knjiznicaProjektDataSet.Posuditelji);
            // TODO: This line of code loads data into the 'knjiznicaProjektDataSet.Knjige' table. You can move, or remove it, as needed.
            this.knjigeTableAdapter.Fill(this.knjiznicaProjektDataSet.Knjige);
            // TODO: This line of code loads data into the 'knjiznicaProjektDataSet.Transakcije' table. You can move, or remove it, as needed.
            this.transakcijeTableAdapter.Fill(this.knjiznicaProjektDataSet.Transakcije);
            // TODO: This line of code loads data into the 'knjiznicaProjektDataSet.Posuditelji' table. You can move, or remove it, as needed.
            this.posuditeljiTableAdapter.Fill(this.knjiznicaProjektDataSet.Posuditelji);
            // TODO: This line of code loads data into the 'knjiznicaProjektDataSet.Transakcije' table. You can move, or remove it, as needed.
            this.transakcijeTableAdapter.Fill(this.knjiznicaProjektDataSet.Transakcije);

        }

        private void transakcijeBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.transakcijeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.knjiznicaProjektDataSet);

        }
    }
}
