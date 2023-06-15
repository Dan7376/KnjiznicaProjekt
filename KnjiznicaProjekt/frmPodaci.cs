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
    public partial class frmPodaci : Form
    {
        public frmPodaci()
        {
            InitializeComponent();
        }

        private void loginBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.loginBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.knjiznicaProjektDataSet);

        }

        private void frmPodaci_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'knjiznicaProjektDataSet.Login' table. You can move, or remove it, as needed.
            this.loginTableAdapter.Fill(this.knjiznicaProjektDataSet.Login);

        }
    }
}
