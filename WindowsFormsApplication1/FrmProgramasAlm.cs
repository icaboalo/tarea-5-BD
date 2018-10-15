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
    public partial class FrmProgramasAlm : Form
    {
        GestorBD.GestorBD GestorBD;
        DataSet dsInst = new DataSet(), dsCampus = new DataSet();
        DataSet dsFolio = new DataSet();
        DataRow fila;
        String cadSql;
        Varios.Comunes comunes = new Varios.Comunes();

        const int OK = 1;
        public FrmProgramasAlm()
        {
            InitializeComponent();
        }

        private void FrmProgramasAlm_Load(object sender, EventArgs e)
        {
            //1- Acceso a la BD.
            GestorBD = new GestorBD.GestorBD("MSDAORA", "bd07", "fercab", "oracle");

            //2- Llenar CB de instituciones
            cadSql = "select distinct nomIns from Institucion";
            GestorBD.consBD(cadSql, dsInst, "Institucion");
            Varios.Comunes.cargaCombo(cbInst, dsInst, "Institucion", "nomIns");
            //CB campus
            cadSql = "select distinct nomCamp from Campus c, Institucion i where i.nomIns ='" + cbInst.Text + "' and i.idInst = c.idInst";
            GestorBD.consBD(cadSql, dsCampus, "Campus");
            Varios.Comunes.cargaCombo(cbCampus, dsCampus, "Campus", "nomCamp");

        }
    }
}