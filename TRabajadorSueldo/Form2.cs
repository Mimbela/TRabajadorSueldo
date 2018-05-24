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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public int CalcularSueldo() //función
        {
            int sueldo = Convert.ToInt32(txtPrecioHora.Text) * Convert.ToInt32(txtHoras.Text);
            return sueldo;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
