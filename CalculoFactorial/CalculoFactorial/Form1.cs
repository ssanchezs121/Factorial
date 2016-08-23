using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculoFactorial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int Dato1;
            int result = 1;
      
            Dato1 = Convert.ToInt32(txtValordeIngreso.Text);

            for (int i = 1; i <= Dato1; i++)
            {
                result *= i;
            }

            lblResult.Text = result.ToString();


        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    
}
