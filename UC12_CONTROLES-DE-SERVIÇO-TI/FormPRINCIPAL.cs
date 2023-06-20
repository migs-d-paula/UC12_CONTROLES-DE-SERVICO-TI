using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UC12_CONTROLES_DE_SERVIÇO_TI
{
    public partial class FormPRINCIPAL : Form
    {
        public FormPRINCIPAL()
        {
            InitializeComponent();
        }

        private void orçamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form telaPRINCIPAL = new FormPRINCIPAL();
            telaPRINCIPAL.MdiParent = this;
            telaPRINCIPAL.WindowState = FormWindowState.Maximized;
            telaPRINCIPAL.Show();
        }
    }
}
