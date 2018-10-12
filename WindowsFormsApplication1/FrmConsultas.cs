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
        DataSet dsAlum = new DataSet(), dsMater = new DataSet(), dsCalifs = new DataSet();
        DataSet dsFolio = new DataSet();
        DataRow fila;

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        String cadSql;

        private void FrmConsultas_Load(object sender, EventArgs e)
        {
            GestorBD = new GestorBD.GestorBD("MSDAORA", "bdalumno", "estudia", "oracle");
            
        }


        
        
    }
}
