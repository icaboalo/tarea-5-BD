using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Edicion
{
    public partial class FrmInstituciones : Form
    {
        public FrmInstituciones()
        {
            InitializeComponent();
        }

        private void FrmInstituciones_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsInstitucion.INSTITUCION' Puede moverla o quitarla según sea necesario.
            this.iNSTITUCIONTableAdapter.Fill(this.dsInstitucion.INSTITUCION);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.iNSTITUCIONTableAdapter.Update(this.dsInstitucion.INSTITUCION);
        }
    }
}
