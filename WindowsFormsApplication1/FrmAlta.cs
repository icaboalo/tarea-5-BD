﻿using System;
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
        DataSet dsImparte = new DataSet();
        DataSet dsServ = new DataSet();

        string cadSql;
        int idCamp;
        int idInst;
        

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
            cb1.Enabled = true;


        }

        private void cb1_Click(object sender, EventArgs e)
        {

            DialogResult boton;
            DialogResult boton2;

            cb1.Enabled = false;
            
            
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
                //Muestra los canmpos para dar de alta una carrera y carga el combobox
                label2.Visible = true;
                cbCarr.Visible = true;
                btAlta.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                comboBox3.Visible = true;
                comboBox4.Visible = true;


                //Se llena el cb de carrera con las carreras existentes, si la carrera no está, eso corresponde a otro problema 
                //y debería haber otro alta de carreras pero el problema no pide eso.
                cadSql = "select distinct NomCarr from Carr";
                GestorBD.consBD(cadSql, dsCarr, "NomCarr");
                Varios.Comunes.cargaCombo(cbCarr, dsCarr, "NomCarr", "NomCarr");

                

            }

            else {
                boton2 = MessageBox.Show("Quiere dar de alta servicios en el campus: " + tbC1.Text + " de la intitución: " + cbInst.Text,
              "Alta Servicios", MessageBoxButtons.YesNo);

                //Si se selecciona el botón Yes, del MessageBox.
                if (boton2 == DialogResult.Yes) {
                    lbS.Visible = true;
                    comboBox2.Visible = true;
                    bS.Visible = true;
                    //Se llena el cb de servicios disponibles
                    cadSql = "select distinct nomServ from Servicios";
                    GestorBD.consBD(cadSql, dsServ, "nomServ");
                    Varios.Comunes.cargaCombo(comboBox2, dsServ, "nomServ", "nomserv");
                }
                else {
                    lbS.Visible = false;
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

        private void btAlta_Click(object sender, EventArgs e) {
            DialogResult boton2;
            DialogResult boton3;
            int claveCarr;

            cadSql = "select idcarr from carr where nomCarr like'"+cbCarr.Text+"%'";
            GestorBD.consBD(cadSql, dsImparte, "idCa");
            claveCarr = Convert.ToInt32(dsImparte.Tables["idCa"].Rows[0]["idCarr"]);


            //Da de alta la carrera
            cadSql = "insert into imp values("+idCamp+ "," + claveCarr + "," + comboBox3.Text+ "," + comboBox4.Text + ")";
            GestorBD.altaBD(cadSql);


            ////Boton para preguntarle al ususario si quiere dar de alta servicios en el nuevo campus
            boton2 = MessageBox.Show("Alta exitosa ¿Quiere dar de alta otra carrera? ",
              "Alta Carrera", MessageBoxButtons.YesNo);

            //Si se selecciona el botón Yes, del MessageBox.
            if (boton2 == DialogResult.No) {
                //Quita los canmpos para dar de alta una carrera
                label2.Visible = false;
                cbCarr.Visible = false;
                btAlta.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                comboBox3.Visible = false;
                comboBox4.Visible = false;
                boton3 = MessageBox.Show("Quiere dar de alta servicios en el campus: " + tbC1.Text + " de la intitución: " + cbInst.Text,
              "Alta Servicios", MessageBoxButtons.YesNo);

                //Si se selecciona el botón Yes, del MessageBox.
                if (boton3 == DialogResult.Yes) {
                    lbS.Visible = true;
                    comboBox2.Visible = true;
                    bS.Visible = true;
                    //Se llena el cb de servicios disponibles
                    cadSql = "select distinct nomServ from Servicios";
                    GestorBD.consBD(cadSql, dsServ, "nomServ");
                    Varios.Comunes.cargaCombo(comboBox2, dsServ, "nomServ", "nomserv");
                }
                else
                {
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

        private void bS_Click(object sender, EventArgs e) {
            DialogResult boton;
            int idServ;

            //Recuperamos el id siguiente para campus
            cadSql = "select idSer as idS from Servicios where nomServ ='"+ comboBox2.Text+"'";
            GestorBD.consBD(cadSql, dsServ, "Id");
            idServ = Convert.ToInt32(dsServ.Tables["Id"].Rows[0]["idS"]);
            //insertar en ofrece
            cadSql = "insert into ofrece values (" + idServ +", "+ idCamp+")";
            GestorBD.altaBD(cadSql);


            boton = MessageBox.Show("Quiere dar de alta otro servicio",
              "Alta Servicios", MessageBoxButtons.YesNo);

            //Si se selecciona el botón Yes, del MessageBox.
            if (boton == DialogResult.Yes) {
                comboBox2.Visible = true;
            }
            else {
                lbS.Visible = false;
                //ls2.Visible = false;
                //ls3.Visible = false;
                //tBs1.Visible = false;
                //comboBox1.Visible = false;
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
