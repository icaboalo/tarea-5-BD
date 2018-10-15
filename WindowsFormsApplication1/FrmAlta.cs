using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestorBD;

namespace WindowsFormsApplication1
{
    public partial class FrmAlta : Form
    {
        public FrmAlta()
        {
            InitializeComponent();
        }

        GestorBD.GestorBD GestorBD;
        DataSet dsInst = new DataSet();
        DataSet dsCarr = new DataSet();
        string cadSql;

        private void FrmAlta_Load(object sender, EventArgs e)
        {
            //1- Acceso a la BD.
            GestorBD = new GestorBD.GestorBD("MSDAORA", "bd07", "fercab", "oracle");

            //2- Llenar CB de instituciones
            cadSql = "select distinct NomIns from Institucion";
            GestorBD.consBD(cadSql, dsInst, "Ins");
            Varios.Comunes.cargaCombo(cbInst, dsInst, "Ins", "NomIns");
        }

        private void cbInst_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbC1.Visible = true;
            tbC1.Visible = true;
            tbC2.Visible = true;
            tbC3.Visible = true;
            tbC4.Visible = true;
            tbC5.Visible = true;
            cb1.Visible = true;


        }

        private void cb1_Click(object sender, EventArgs e)
        {
            DialogResult boton;



            tbC1.Enabled = false;
            tbC2.Enabled = false;
            tbC3.Enabled = false;
            tbC4.Enabled = false;
            tbC5.Enabled = false;



            //Boton para preguntarle al ususario si quiere dar de alta carreras en el nuevo campus

            boton = MessageBox.Show("Quiere dar de alta carreras en el campus: = " + tbC1.Text + " de la intitución: " + cbInst.Text,
              "Alta Carreras", MessageBoxButtons.YesNo);

            //Si se selecciona el botón Yes, del MessageBox.
            if (boton == DialogResult.Yes)
            {
                //Muestra los canmpos para dar de alta una carrera
                label2.Visible = true;
                cbCarr.Visible = true;
                btAlta.Visible = true;

                //Se llena el cb de carrera con las carreras existentes, si la carrera no está, eso corresponde a otro problema 
                //y debería haber otro alta de carreras pero el problema no pide eso.
                cadSql = "select distinct NomCarr from Carr";
                GestorBD.consBD(cadSql, dsCarr, "NomCarr");
                Varios.Comunes.cargaCombo(cbCarr, dsCarr, "NomCarr", "NomCarr");

            }

            ////Boton para preguntarle al ususario si quiere dar de alta servicios en el nuevo campus
            //botón2 = MessageBox.Show("Quiere dar de alta Servicios en el campus: " + tbC1.Text.ToString() + " de la intitución: " + cbInst.Text,
            //  "Alta Servicios", MessageBoxButtons.YesNo);

            ////Si se selecciona el botón Yes, del MessageBox.
            //if (botón == DialogResult.Yes)
            //{
            //    //Muestra los canmpos para dar de alta un servicio

            //}
        }

        private void btAlta_Click(object sender, EventArgs e)
        {
            DialogResult boton2;

            ////Boton para preguntarle al ususario si quiere dar de alta servicios en el nuevo campus
            boton2 = MessageBox.Show("Alta exitosa ¿Quiere dar de alta otra carrera? ",
              "Alta Carrera", MessageBoxButtons.YesNo);

            //Si se selecciona el botón Yes, del MessageBox.
            if (boton2 == DialogResult.No)
            {
                //Muestra los canmpos para dar de alta un servicio
                label2.Visible = false;
                cbCarr.Visible = false;
                btAlta.Visible = false;
            }
         }
        
    }
}
