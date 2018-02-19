using appIncidentes.Clases;
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

namespace appIncidentes
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }
        static List<Incidentes> lista = new List<Incidentes>();
        private void Form1_Load(object sender, EventArgs e)
        {
            comboTipo.Items.Add("Telefono");
            comboTipo.Items.Add("Internet");
            comboTipo.Items.Add("Television");

            for (int i =1; i <=5; i++)
            {
                comboPrioridad.Items.Add(i);
            }
            


        }

        private void butRegistrar_Click(object sender, EventArgs e)
        {
           
        
            frmIncidentes frm = new frmIncidentes();
            frm.Show();

        }

        public Incidentes Rgistro()
        {
            Incidentes inc = null;

            if(comboTipo.SelectedIndex == 0)
            {
                inc = new Telefono();

                inc.Descripcion = textDescripcion.Text;
                inc.Duracion = Convert.ToInt32(numericUpDown1.Value);

                if (radioBajo.Checked)
                {
                    inc.Gravedad = Gravedad.Baja;
                }

                if (radioMedio.Checked)
                {
                    inc.Gravedad = Gravedad.Media;
                }
                if (radioAlto.Checked)
                {
                    inc.Gravedad = Gravedad.Alta;
                }

                inc.Prioridad = Convert.ToInt32( comboPrioridad.SelectedIndex);

                inc.Tiquete = Convert.ToInt32(textTiquetes.Text);           

            }

            if (comboTipo.SelectedIndex == 1)
            {
                inc = new Internet();

                inc.Descripcion = textDescripcion.Text;
                inc.Duracion = Convert.ToInt32(numericUpDown1.Value);

                if (radioBajo.Checked)
                {
                    inc.Gravedad = Gravedad.Baja;
                }

                if (radioMedio.Checked)
                {
                    inc.Gravedad = Gravedad.Media;
                }
                if (radioAlto.Checked)
                {
                    inc.Gravedad = Gravedad.Alta;
                }

                inc.Prioridad = Convert.ToInt32(comboPrioridad.SelectedIndex);

                inc.Tiquete = Convert.ToInt32(textTiquetes.Text);

            }

            if (comboTipo.SelectedIndex == 2)
            {
                inc = new Television();

                inc.Descripcion = textDescripcion.Text;
                inc.Duracion = Convert.ToInt32(numericUpDown1.Value);

                if (radioBajo.Checked)
                {
                    inc.Gravedad = Gravedad.Baja;
                }

                if (radioMedio.Checked)
                {
                    inc.Gravedad = Gravedad.Media;
                }
                if (radioAlto.Checked)
                {
                    inc.Gravedad = Gravedad.Alta;
                }

                inc.Prioridad = Convert.ToInt32(comboPrioridad.SelectedIndex);

                inc.Tiquete = Convert.ToInt32(textTiquetes.Text);

            }


            return inc;

        }
   

        public void Notificar()
        {
            throw new NotImplementedException();
        
        }

       
    }
}
