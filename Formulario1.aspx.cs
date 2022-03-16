using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Arreglos
{
    public partial class Formulario1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnMostrar_Click(object sender, EventArgs e)
        {
            string[] nombres = new string[5];

            nombres[0] = "Andres";
            nombres[1] = "Diana";
            nombres[2] = "Julian";
            nombres[3] = "Lina";
            nombres[4] = "Sofia";

            //txtMostrar.Text = nombres[0] + "," + nombres[1] + "," + nombres[2] + "," + nombres[3] + "," + nombres[4];
            for (int i = 0; i < nombres.Length; i++)
            {
                if (i == 4)
                {
                    txtMostrar.Text += System.Convert.ToString(nombres[i]);
                } else
                {
                    txtMostrar.Text += System.Convert.ToString(nombres[i] + ",");
                }
                

            }
        }

        protected void btnMostrar1_Click(object sender, EventArgs e)
        {
            int[] numeros = new int[5];

            numeros[0] = 12;
            numeros[1] = 8;
            numeros[2] = 25;
            numeros[3] = 4;
            numeros[4] = 45;

            lblNumResult.Text = System.Convert.ToString((numeros[0] + "," + numeros[1] + "," + numeros[2] + "," + numeros[3] + "," + numeros[4]));
        }
    }
}