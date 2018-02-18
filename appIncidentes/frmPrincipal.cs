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
    public partial class frmPrincipal : Form, ISujeto
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

        public void Rgistro()
        {
            Incidentes inc;
        }

        //public void Registrar(IObservador ob)
        //{
        //    Incidentes incidentes;

        //    int tiquetes = Convert.ToInt32(textTiquetes.Text);
        //    string descripcion = textDescripcion.Text;
        //    int duracion = numericUpDown1.TabIndex;
        //    int prioridad = comboPrioridad.SelectedIndex;
        //    string tipo = "";

        //    if (comboTipo.SelectedItem.Equals("Telefono"))
        //    {
        //        incidentes = new Telefono();
        //        tipo = "Telefono";
        //    }
        //    else
        //    {
        //        if (comboTipo.SelectedItem.Equals("Internet"))
        //        {
        //            incidentes = new Internet();
        //            tipo = "Internet";
        //        }
        //        else
        //        {
        //            incidentes = new Television();
        //            tipo = "Television";
        //        }
        //    }
        //}

        
    }
}
