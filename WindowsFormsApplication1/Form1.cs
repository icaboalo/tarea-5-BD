using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void institucionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Edicion.FrmInstituciones fi = new Edicion.FrmInstituciones();
            fi.Show();
        }

        private void serviciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Edicion.FrmServicios fs = new Edicion.FrmServicios();
            fs.Show();
        }

        private void consultasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultas fc = new FrmConsultas();
            fc.Show();
        }

        private void programasAlmacenadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProgramasAlm fp = new FrmProgramasAlm();
            fp.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void carrerasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmCarreras().Show();
        }
    }
}
