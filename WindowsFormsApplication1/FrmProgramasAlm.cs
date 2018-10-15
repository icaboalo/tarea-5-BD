using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
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
        OleDbConnection cnOracle;

        String cadSql;

        private void button1_Click(object sender, EventArgs e)
        {
            String nomInst, nomC;
            int cant;
            OleDbCommand proc;
            OleDbParameter par;


            //1- Abrir la conexión a la BD.
            cnOracle = new OleDbConnection("Provider=MSDAORA; Data Source=oracle;" +
              "User ID=bd07;Password=fercab");
            cnOracle.Open();
            proc = new OleDbCommand();
            proc.Connection = cnOracle;

            //2- Especificar el llamado al procedimiento  (en general: al subprograma).
            proc.CommandText = "cantServicios";
            proc.CommandType = CommandType.StoredProcedure;

            //3- Especificar los parámetros:
            // a) Nota: primero hay que definir el tipo de valor que regresará la función.

            par = new OleDbParameter("RETURN_VALUE", OleDbType.Integer,
              4, ParameterDirection.ReturnValue, false, 4, 0, "res", DataRowVersion.Current, 0);
            proc.Parameters.Add(par);

            // b) luego hay que definir los parámetros de entrada (dos en este caso).

            nomInst = cbInst.Text;
            par = new OleDbParameter("nomIns", nomInst);
            proc.Parameters.Add(par);

            nomC = cbCampus.Text;
            par = new OleDbParameter("nomC", nomC);
            proc.Parameters.Add(par);

            //4- Ejecutar el procedimiento (en general: el subprograma).
            try
            {
                proc.ExecuteNonQuery();

                //5- Recuperar el valor regresado por la función.
                cant = Convert.ToInt16(proc.Parameters["RETURN_VALUE"].Value);
                MessageBox.Show("Cantidad de servicios adicionales ofrecidos:  " + cant);

            }
            catch (OleDbException err)
            {
                MessageBox.Show(err.Message);
            }

            //6- Cerrar la conexión a la BD.
            cnOracle.Close();
        }

        private void FrmProgramasAlm_Load_1(object sender, EventArgs e)
        {
            //1- Acceso a la BD.
            GestorBD = new GestorBD.GestorBD("MSDAORA", "bd07", "fercab", "oracle");

            //2- Llenar CB de instituciones
            cadSql = "select distinct Siglas from Institucion";
            GestorBD.consBD(cadSql, dsInst, "Ins");
            Varios.Comunes.cargaCombo(cbInst, dsInst, "Ins", "Siglas");
            Varios.Comunes.cargaCombo(cbinst1, dsInst, "Ins", "Siglas");
        }

        private void cbInst_SelectedIndexChanged(object sender, EventArgs e)
        {
            //CB campus
            cadSql = "select distinct nomCamp from Campus c, Institucion i where i.Siglas ='" + cbInst.Text + "' and i.idInst = c.idInst";
            GestorBD.consBD(cadSql, dsCampus, "Campus");
            Varios.Comunes.cargaCombo(cbCampus, dsCampus, "Campus", "nomCamp");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String nomI, nomC1, nomC2, grad, res;
            OleDbCommand proc;
            OleDbParameter par;

            //1- Abrir la conexión a la BD.
            cnOracle = new OleDbConnection("Provider=MSDAORA; Data Source=oracle;" +
              "User ID=bdalumno;Password=estudia");
            cnOracle.Open();
            proc = new OleDbCommand();
            proc.Connection = cnOracle;

            //2- Especificar el llamado al procedimiento  (en general: al subprograma).
            proc.CommandText = "mayorTipo";
            proc.CommandType = CommandType.StoredProcedure;

            //3- Especificar los parámetros:
            //a) primero todos los de entrada:
            nomI = cbinst1.Text;
            par = new OleDbParameter("nomIns", nomI);
            proc.Parameters.Add(par);

            nomC1 = cbCampus1.Text;
            par = new OleDbParameter("nomCamp1", nomC1);
            proc.Parameters.Add(par);

            nomC2 = cbCampus2.Text;
            par = new OleDbParameter("nomCamp2", nomC2);
            proc.Parameters.Add(par);

            //b) luego todos los de salida (uno en este caso):
            par = new OleDbParameter("res", OleDbType.Integer, 4,
              ParameterDirection.Output, false, 4, 0, "res", DataRowVersion.Current, 0);
            proc.Parameters.Add(par);

            //4- Ejecutar el procedimiento (en general: el subprograma).
            try
            {
                proc.ExecuteNonQuery();

                //5- Recuperar el (los) valor(es) regresado(s) por medio del (de los)
                //   parámetro(s) de salida.
                res = proc.Parameters["res"].Value.ToString();
                MessageBox.Show("Campus con más profesores de "+ cbGrado.Text+" : " + res);
            }
            catch (OleDbException err)
            {
                MessageBox.Show(err.Message);
            }

            //6- Cerrar la conexión a la BD.
            cnOracle.Close();
        }

        private void cbinst1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //CB campus
            cadSql = "select distinct nomCamp from Campus c, Institucion i where i.Siglas ='" + cbinst1.Text + "' and i.idInst = c.idInst";
            GestorBD.consBD(cadSql, dsCampus, "Campus");
            Varios.Comunes.cargaCombo(cbCampus1, dsCampus, "Campus", "nomCamp");
            Varios.Comunes.cargaCombo(cbCampus2, dsCampus, "Campus", "nomCamp");
        }
    }
}