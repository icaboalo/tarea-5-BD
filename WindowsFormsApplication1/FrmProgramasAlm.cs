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

        public FrmProgramasAlm()
        {
            InitializeComponent();
        }

        GestorBD.GestorBD GestorBD;
        DataSet dsInst = new DataSet();
        DataSet dsCampus = new DataSet();
        DataSet dsFolio = new DataSet();

        String cadSql;

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void FrmProgramasAlm_Load_1(object sender, EventArgs e)
        {
            //1- Acceso a la BD.
            GestorBD = new GestorBD.GestorBD("MSDAORA", "bd07", "fercab", "oracle");

            //2- Llenar CB de instituciones
            cadSql = "select distinct Siglas from Institucion";
            GestorBD.consBD(cadSql, dsInst, "Ins");
            Varios.Comunes.cargaCombo(cbInst, dsInst, "Ins", "Siglas");
            //CB campus
            cadSql = "select distinct nomCamp from Campus c, Institucion i where i.Siglas ='" + cbInst.Text + "' and i.idInst = c.idInst";
            GestorBD.consBD(cadSql, dsCampus, "Campus");
            Varios.Comunes.cargaCombo(cbCampus, dsCampus, "Campus", "nomCamp");
        }

        private void cbInst_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}