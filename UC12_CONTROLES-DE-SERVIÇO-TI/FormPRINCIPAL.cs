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
            Form telaORCAMENTO = new FormORCAMENTO();
            telaORCAMENTO.MdiParent = this;
            telaORCAMENTO.WindowState = FormWindowState.Maximized;
            telaORCAMENTO.Show();
        }

        private void históricoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form telaHISTORICO = new FormHISTORICO();
            telaHISTORICO.MdiParent = this;
            telaHISTORICO.WindowState = FormWindowState.Maximized;
            telaHISTORICO.Show();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form telaCADASTRO = new FormCADASTRO();
            telaCADASTRO.MdiParent = this;
            telaCADASTRO.WindowState = FormWindowState.Maximized;
            telaCADASTRO.Show();
        }
    }
}
