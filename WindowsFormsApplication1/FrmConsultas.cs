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
    public partial class FrmConsultas : Form
    {
        public FrmConsultas()
        {
            InitializeComponent();
        }

        //Variables de la clase.
        GestorBD.GestorBD GestorBD;
        DataSet dsConsulta1 = new DataSet();
        DataSet dsConsulta2 = new DataSet();
        DataSet dsConsulta3 = new DataSet();
        DataSet dsConsulta4 = new DataSet();
        String cadSql;

        private void FrmConsultas_Load(object sender, EventArgs e)
        {
            GestorBD = new GestorBD.GestorBD("MSDAORA", "bd07", "fercab", "oracle");
            
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string op = comboBox1.Text;

            switch (op)
            {
                case "Instituciones por ciudad":
                    cadSql = "SELECT CIUDAD, NOMINS, NOMCAMP from INSTITUCION i, CAMPUS c where i.IDINST = c.IDINST order by ciudad";
                    GestorBD.consBD(cadSql, dsConsulta1, "Cons1");
                    dataGridView1.DataSource = dsConsulta1.Tables["Cons1"];
                    break;

                case "Instituciones con Ing. Compu/Telemática/Mate":
                    cadSql = "select distinct nomIns from institucion i, campus c, carr car, imp im where i.IdInst = c.IdInst "
                        +"and c.Idcamp = im.idcamp and im.idcarr = car.idcarr and(NomCarr = 'Ingeniería en Computación' or nomcarr = 'Ingeniería en Telemática' "
                        +"or nomcarr = 'Matemáticas Aplicadas')";
                    GestorBD.consBD(cadSql, dsConsulta2, "Cons2");
                    dataGridView1.DataSource = dsConsulta2.Tables["Cons2"];
                    break;

                case "Campus con más de dos servicios dentro":
                    cadSql = "select distinct nomCamp, nomIns from Campus c, Institucion i, Servicios s, Ofrece o where o.idSer = s.idSer "
                        + "and o.idCamp = c.idCamp and c.idInst = i.idInst and c.idCamp in (select c.idCamp from Campus c, Servicios s, Ofrece o "
                        + "where o.idSer = s.idSer and o.idCamp = c.idCamp group by c.idCamp having count(*) > 2)";
                    GestorBD.consBD(cadSql, dsConsulta3, "Cons3");
                    dataGridView1.DataSource = dsConsulta3.Tables["Cons3"];
                    break;

                case "Instituciones con todas las carreras":
                    cadSql = "select distinct nomIns from Institucion i, campus c, imp im, carr car where i.idInst = c.idInst and"
                        +" c.IdCamp = im.idCamp and im.idcarr = car.idcarr group by nomIns having count(distinct nomCarr) = (select count(nomcarr) from carr)";
                    GestorBD.consBD(cadSql, dsConsulta4, "Cons4");
                    dataGridView1.DataSource = dsConsulta4.Tables["Cons4"];
                    break;
            }
        }




    }
}
