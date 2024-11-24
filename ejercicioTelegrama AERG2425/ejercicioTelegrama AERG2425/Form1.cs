using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicioTelegrama_AERG2425
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
// AERG-2425.Código inicial del ejercicio Telegrama
        private void btnCalcularPrecio_Click(object sender, EventArgs e)
        {
            string textoTelegrama;
//AERG-2425.Recogemos el valor de la variable textoTelegrama,del texto introducido
            textoTelegrama = txtTelegrama.Text;

// AERG-2425.Añadimos el carácter 'o' a la variable tipoTelegrama como valor de origen.
            char tipoTelegrama = 'o';
            int numPalabras = 0;

//? AERG-2324.Inicializamos la variable coste con valor 0
            double coste = 0;
            //Leo el telegrama
            //textoTelegrama = txtTelegrama.Text;
            // telegrama urgente?
            if (chkUrgente.Checked)
            {
                tipoTelegrama = 'u';
            }
//AERG-2425.Calculamos el numero de palabras con la siguiente sentencia
            numPalabras = textoTelegrama.Split(' ', '.', ';', ':').Length; ;

            //Obtengo el número de palabras que forma el telegrama
           //numPalabras = textoTelegrama.Length;
            //Si el telegrama es ordinario
            if (tipoTelegrama == 'o')
            {
                if (numPalabras <= 10)
                {
                    coste = 2.5;
                }
                else
                {
//AERG-2425.Modificamos la formula para obtener el coste
                    coste = 2.5 + 0.50 * (numPalabras - 10);
                }
            }
            else
            //Si el telegrama es urgente
            {
                if (tipoTelegrama == 'u')
                {
                    if (numPalabras <= 10)
                    {
                        coste = 5;
                    }
                    else
                    {
                        coste = 5 + 0.75 * (numPalabras - 10);
                    }
                }
                else
                {
                    coste = 0;
                }
            }
            txtPrecio.Text = coste.ToString() + " euros";
        }

    }
}

