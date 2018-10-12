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
        DataSet dsGeneral = new DataSet();
        GestorBD.GestorBD gestorBD;

        public FrmCarreras()
        {
            InitializeComponent();
        }

        private void FrmCarreras_Load(object sender, EventArgs e)
        {
            gestorBD = new GestorBD.GestorBD("MSDAORA", "bd07", "fercab", "oracle");
            gestorBD.consBD("select NomCarr from carr", dsGeneral, "Carreras");
            gestorBD.consBD("select distinct ciudad from campus", dsGeneral, "Ciudades");
            Varios.Comunes.cargaCombo(cbCiudad, dsGeneral, "Carreras", "NomCarr");
            Varios.Comunes.cargaCombo(cbCarrera, dsGeneral, "Ciudades", "ciudad");
        }
    }
}
