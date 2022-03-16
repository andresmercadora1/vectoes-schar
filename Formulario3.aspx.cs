using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Arreglos
{
    public partial class Formulario3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnVer_Click(object sender, EventArgs e)
        {
            int tamanio;
            tamanio = Convert.ToInt32(txtTamanio.Text);

            decimal valor = 0;
            decimal[] vector = new decimal[tamanio];
            string data = "[";

            for (int i = 0; i < vector.Length; i++)
            {
                valor = Convert.ToDecimal(Microsoft.VisualBasic.Interaction.InputBox("Digite el valor de la " + i + " del vector"));
                vector[i] = valor;
                if(i == 0)
                {
                    data += vector[i];
                } else
                {
                    data += ", " + vector[i];
                }
            }
            data += "]";
            lblResult.Text = data;

        }
    }
}