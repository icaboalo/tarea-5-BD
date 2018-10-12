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
    public partial class FrmServicios : Form
    {
        public FrmServicios()
        {
            InitializeComponent();
        }

        private void FrmServicios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsServicios.SERVICIOS' Puede moverla o quitarla según sea necesario.
            this.sERVICIOSTableAdapter.Fill(this.dsServicios.SERVICIOS);

        }

        private void btnActualiza_Click(object sender, EventArgs e)
        {
            this.sERVICIOSTableAdapter.Update(this.dsServicios.SERVICIOS);
        }
    }
}
