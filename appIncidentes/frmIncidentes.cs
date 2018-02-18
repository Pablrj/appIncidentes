using appIncidentes.Interfaz;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using appIncidentes.Clases;

namespace appIncidentes
{
    public partial class frmIncidentes : Form, IObservador
    {
        public frmIncidentes()
        {
            InitializeComponent();
        }

        public void Actualizar(Incidentes incidentes)
        {
            lsbIncid.Items.Add(incidentes);
        }

        private void frmIncidentes_Load(object sender, EventArgs e)
        {
            
        }
    }
}
