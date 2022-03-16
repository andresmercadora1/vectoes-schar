using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Arreglos
{
    public partial class Formulario2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnMostrar_Click(object sender, EventArgs e)
        {
            int tamanio, cont = 0;
            float promedio = 0, suma = 0;
            float valores = 0;
            string numGran = "", datos = "";

            tamanio = Convert.ToInt32(txtTamanio.Text);

            float[] vector = new Single[tamanio];

            for (int i = 0; i < vector.Length; i++)
            {
                valores = Convert.ToSingle(Microsoft.VisualBasic.Interaction.InputBox("Ingrese el valor de la posicion " + i + " del vector"));
                vector[i] = valores;

                if(i == 0)
                {
                    datos += vector[i];
                } else
                {
                    datos += ", " + vector[i];
                }
            }
            lblValores.Text = datos;
            for (int i = 0; i < vector.Length; i++)
            {
                suma += vector[i];
                cont++;
            }

            promedio = suma / vector.Length;

            for (int i = 0; i < vector.Length; i++)
            {
                if (vector[i] > promedio)
                {
                    numGran += ", " + vector[i];
                }
            }

            lblCantidad.Text = System.Convert.ToString(cont);
            lblMayoresProm.Text = System.Convert.ToString(numGran);
        }
    }
}