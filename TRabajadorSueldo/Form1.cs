using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRabajadorSueldo
{
    public partial class Form1 : Form
    {
        Form2 formulario2;
        public Form1()//constructor
        {
            InitializeComponent();

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            formulario2 = new Form2(); //instancio el formulario2
            formulario2.ShowDialog(); //necesito recoger info de esa segunda pantalla, lo enlaza.
            //el showdialog hace que ese formulario se quede modal, y hasta que el usuario no rellene , no pasa al siguiente formulario
            txtSueldo.Text = formulario2.CalcularSueldo().ToString();//paso la función

        }
    }
}


//Ejercicio Propuesto(Anexo 3): 
//Aplicación para el cálculo del sueldo de un trabajador.Dos formularios:
//En form1 ‘sueldo’ es de solo lectura.Se rellena con los datos introducidos en form2 que será llamado por ‘calcular’. 
