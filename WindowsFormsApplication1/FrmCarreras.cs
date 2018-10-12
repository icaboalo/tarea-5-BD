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
    public partial class FrmCarreras : Form
    {
        DataSet dsCiudades = new DataSet(), dsCarreras = new DataSet(), dsCarrera = new DataSet(), dsServicios = new DataSet(), dsInstituciones;
        GestorBD.GestorBD gestorBD;

        public FrmCarreras()
        {
            InitializeComponent();
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {

        }

        private void FrmCarreras_Load(object sender, EventArgs e)
        {
            gestorBD = new GestorBD.GestorBD("MSDAORA", "bd07", "fercab", "oracle");

            gestorBD.consBD("select distinct ciudad from campus", dsCiudades, "Ciudades");
            gestorBD.consBD("select Nomcarr from carr", dsCarreras, "Carreras");
            Varios.Comunes.cargaCombo(cbCarrera, dsCarreras, "Carreras", "Nomcarr");
            Varios.Comunes.cargaCombo(cbCiudad, dsCiudades, "Ciudades", "ciudad");
        }
    }
}
