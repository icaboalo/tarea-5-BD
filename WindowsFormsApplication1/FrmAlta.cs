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
        DataSet dsCamp = new DataSet();

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
            DialogResult boton2;
            int idCamp;
            int idInst;
            
            //Recuperamos el id siguiente para campus
            cadSql = "Select max(IdCamp) as ma from Campus";
            GestorBD.consBD(cadSql, dsCamp, "Id");
            idCamp = Convert.ToInt16(dsCamp.Tables["Id"].Rows[0]["ma"])+1;
            

            //Recuperamos el id de la institucion
            cadSql = "Select idInst as idIn from Institucion where NomIns='"+ cbInst.Text+"'";
            GestorBD.consBD(cadSql, dsCamp, "Id");
            idInst = Convert.ToInt16(dsCamp.Tables["Id"].Rows[0]["idIn"]);
            

            cadSql = "insert into campus values ("+ idCamp +",'"+ tbC1.Text+ "','" + tbC2.Text + "'," + tbC3.Text + ", 0 , '" + tbC4.Text + "','" + tbC5.Text + "',"+idInst+")";
            GestorBD.altaBD(cadSql);
            
            
            //Se dehabilitan los botones para   que el usuario ya no pueda editarlos.
            tbC1.Enabled = false;
            tbC2.Enabled = false;
            tbC3.Enabled = false;
            tbC4.Enabled = false;
            tbC5.Enabled = false;
            cbInst.Enabled = false;



            //Boton para preguntarle al ususario si quiere dar de alta carreras en el nuevo campus

            boton = MessageBox.Show("Quiere dar de alta carreras en el campus: " + tbC1.Text + " de la intitución: " + cbInst.Text,
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

            else {
                boton2 = MessageBox.Show("Quiere dar de alta servicios en el campus: = " + tbC1.Text + " de la intitución: " + cbInst.Text,
              "Alta Servicios", MessageBoxButtons.YesNo);

                //Si se selecciona el botón Yes, del MessageBox.
                if (boton2 == DialogResult.Yes) {
                    lbS.Visible = true;
                    ls2.Visible = true;
                    ls3.Visible = true;
                    tBs1.Visible = true;
                    comboBox1.Visible = true;
                    comboBox2.Visible = true;
                    bS.Visible = true;
                }
                else {
                    lbS.Visible = false;
                    ls2.Visible = false;
                    ls3.Visible = false;
                    tBs1.Visible = false;
                    comboBox1.Visible = false;
                    comboBox2.Visible = false;
                    bS.Visible = false;

                    //Regresa todos los ajustes a default para poder dar otra alta
                    lbC1.Visible = false;
                    tbC1.Visible = false;
                    tbC2.Visible = false;
                    tbC3.Visible = false;
                    tbC4.Visible = false;
                    tbC5.Visible = false;
                    cb1.Visible = false;
                    cbInst.Enabled = true;
                    tbC1.Enabled = true;
                    tbC2.Enabled = true;
                    tbC3.Enabled = true;
                    tbC4.Enabled = true;
                    tbC5.Enabled = true;
                    cbInst.Enabled = true;
                    tbC1.Text = "Nombre";
                    tbC2.Text = "Domicilio";
                    tbC3.Text = "Teléfono";
                    tbC4.Text = "Ciudad";
                    tbC5.Text = "Estado";
                }
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

        private void btAlta_Click(object sender, EventArgs e) {
            DialogResult boton2;
            DialogResult boton3;


            ////Boton para preguntarle al ususario si quiere dar de alta servicios en el nuevo campus
            boton2 = MessageBox.Show("Alta exitosa ¿Quiere dar de alta otra carrera? ",
              "Alta Carrera", MessageBoxButtons.YesNo);

            //Si se selecciona el botón Yes, del MessageBox.
            if (boton2 == DialogResult.No) {
                //Quita los canmpos para dar de alta una carrera
                label2.Visible = false;
                cbCarr.Visible = false;
                btAlta.Visible = false;
                boton3 = MessageBox.Show("Quiere dar de alta servicios en el campus: = " + tbC1.Text + " de la intitución: " + cbInst.Text,
              "Alta Servicios", MessageBoxButtons.YesNo);

                //Si se selecciona el botón Yes, del MessageBox.
                if (boton3 == DialogResult.Yes) {
                    lbS.Visible = true;
                    ls2.Visible = true;
                    ls3.Visible = true;
                    tBs1.Visible = true;
                    comboBox1.Visible = true;
                    comboBox2.Visible = true;
                    bS.Visible = true;
                }
            
            }
         }

        private void bS_Click(object sender, EventArgs e) {
            DialogResult boton;


            //Boton para preguntarle al ususario si quiere dar de alta carreras en el nuevo campus

            boton = MessageBox.Show("Quiere dar de alta otro servicio",
              "Alta Servicios", MessageBoxButtons.YesNo);

            //Si se selecciona el botón Yes, del MessageBox.
            if (boton == DialogResult.Yes) {
                tBs1.Text = "Nombre";

            }
            else {
                lbS.Visible = false;
                ls2.Visible = false;
                ls3.Visible = false;
                tBs1.Visible = false;
                comboBox1.Visible = false;
                comboBox2.Visible = false;
                bS.Visible = false;

                //Regresa todos los ajustes a default para poder dar otra alta
                lbC1.Visible = false;
                tbC1.Visible = false;
                tbC2.Visible = false;
                tbC3.Visible = false;
                tbC4.Visible = false;
                tbC5.Visible = false;
                cb1.Visible = false;
                cbInst.Enabled = true;
                tbC1.Enabled = true;
                tbC2.Enabled = true;
                tbC3.Enabled = true;
                tbC4.Enabled = true;
                tbC5.Enabled = true;
                cbInst.Enabled = true;
                tbC1.Text = "Nombre";
                tbC2.Text = "Domicilio";
                tbC3.Text = "Teléfono";
                tbC4.Text = "Ciudad";
                tbC5.Text = "Estado";


            }

        }
    }
}
