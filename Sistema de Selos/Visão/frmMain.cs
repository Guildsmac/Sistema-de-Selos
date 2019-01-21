using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Selos
{
    public partial class frmMain : Form
    {

        private Form actInstance = null;

        public bool checkInstance()
        {
            if (this.actInstance != null)
            {
                if (this.actInstance.IsDisposed)
                    return true;
            }
            if (this.actInstance != null)
                return false;
            return true;
        }

        public void openNewInstance(Form instance)
        {
            if (this.checkInstance())
            {
                this.actInstance = instance;
                this.actInstance.MdiParent = this;
                this.actInstance.Show();
            }
        }

        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void seloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.openNewInstance(new ConsultaSelo());
        }

        private void porProprietárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.openNewInstance(new ConsultaProprietario());

        }

        private void seloToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.openNewInstance(new CadastroSelo());
        }

        private void proprietárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.openNewInstance(new CadastroProprietario());
        }

        private void proprietárioToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void seloToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.openNewInstance(new ManutencaoSelo());

        }

        private void proprietárioToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            this.openNewInstance(new ManutencaoProprietario());
        }
    }
}
