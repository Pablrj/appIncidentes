using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace appIncidentes.Clases
{
    public abstract class  Incidentes
    {
        public string Descripcion { get; set; }

        public int Duracion { get; set; }

        public Gravedad Gravedad { get; set; }

        public abstract string Nombre { get; }

        public int Prioridad { get; set; }

        public int Tiquete { get; set; }

        public abstract double costo();

        public  void ExportarXML()
        {
            try
            {
                // validar si existe el directorio sino lo crea
                if (!Directory.Exists(@"c:\temp"))
                {
                    Directory.CreateDirectory(@"c:\temp");
                }

                StreamWriter xml = new StreamWriter(@"c:\temp\facil.xml");

                XmlDocument documento = new XmlDocument();           
                XmlElement raiz = documento.CreateElement("Incidentes");
                documento.AppendChild(raiz);

    
                XmlElement incidentex = documento.CreateElement("Incidente");
                raiz.AppendChild(incidentex);

                XmlElement nombrex = documento.CreateElement("Nombre");
                nombrex.AppendChild(documento.CreateTextNode(Nombre));
                incidentex.AppendChild(nombrex);

                XmlElement descripcionx = documento.CreateElement("Descripcion");
                descripcionx.AppendChild(documento.CreateTextNode(Descripcion));
                incidentex.AppendChild(descripcionx);

                XmlElement prioridadx = documento.CreateElement("Prioridad");
                prioridadx.AppendChild(documento.CreateTextNode(Prioridad.ToString()));
                incidentex.AppendChild(prioridadx);

                XmlElement duracionx = documento.CreateElement("Duracion");
                duracionx.AppendChild(documento.CreateTextNode(Duracion.ToString()));
                incidentex.AppendChild(duracionx);

                XmlElement gravedadx = documento.CreateElement("Gravedad");
                gravedadx.AppendChild(documento.CreateTextNode(Gravedad.ToString()));
                incidentex.AppendChild(gravedadx);

                XmlElement totalx = documento.CreateElement("total");
                totalx.AppendChild(documento.CreateTextNode(costo().ToString()));
                incidentex.AppendChild(totalx);

 
                // Salvar el archivo
                xml.Write(documento.OuterXml);
                xml.Close();

                Process.Start(@"c:\temp\facil.xml");
            }
            catch (Exception er)
            {

                MessageBox.Show("Error :" + er.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public override string ToString()
        {
            return "Descripcion "+Descripcion + " Duracion "+Duracion+ " Gravedad "+Gravedad.ToString()+
                "Nombre "+Nombre + " Prioridad "+Prioridad + " Tiquete "+Tiquete + " Costo "+costo();
        }
    }
}
