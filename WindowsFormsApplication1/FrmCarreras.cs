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
        DataSet dsCiudades = new DataSet(), dsCarreras = new DataSet(), dsCarrera = new DataSet(), dsInstituciones = new DataSet(), dsServicios = new DataSet();
        GestorBD.GestorBD gestorBD;

        public FrmCarreras()
        {
            InitializeComponent();
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            String cadSql = String.Format("select NOMINS, NOMCAMP, DOM, NOMSERV, NOMCARR, DURACION, CREDS from INSTITUCION i, CARR c, IMP im, OFRECE o, SERVICIOS s, CAMPUS ca where c.NOMCARR = '{0}' and ca.CIUDAD = '{1}' and i.IDINST = ca.IDINST and ca.IDCAMP = o.IDCAMP and o.IDSER = s.IDSER and ca.IDCAMP = im.IDCAMP and im.IDCARR = c.IDCARR", cbCarrera.Text, cbCiudad.Text);
            gestorBD.consBD(cadSql, dsInstituciones, "res");
            dgInstituciones.DataSource = dsInstituciones.Tables["res"];

            gestorBD.consBD("select count(*) as total from campus c where c.ciudad = '" + cbCiudad.Text + "'", dsServicios, "total");
            totalServicios.Text = "Total de Campus " + dsServicios.Tables["total"].Rows[0]["total"].ToString();
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
