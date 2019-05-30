using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BCA_MUSCUTIME
{
    public partial class FrmPrincipal : Form
    {
        Form FrmCreation = new FrmCreation();
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.FrmCreation.Owner = this;
            this.Hide();
            FrmCreation.ShowDialog();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            DonnéesPubliques.Insert = false;
        }
    }
}
