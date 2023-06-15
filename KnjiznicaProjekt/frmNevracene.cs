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
    public partial class frmNevracene : Form
    {
        public frmNevracene()
        {
            InitializeComponent();
        }

        private void frmNevracene_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'knjiznicaProjektDataSet.Posuditelji' table. You can move, or remove it, as needed.
            this.posuditeljiTableAdapter.Fill(this.knjiznicaProjektDataSet.Posuditelji);
            // TODO: This line of code loads data into the 'knjiznicaProjektDataSet.NevraceneKnjige' table. You can move, or remove it, as needed.
            this.nevraceneKnjigeTableAdapter.Fill(this.knjiznicaProjektDataSet.NevraceneKnjige);

        }
    }
}
