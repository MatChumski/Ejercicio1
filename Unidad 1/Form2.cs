using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unidad_1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnTemperatura_Click(object sender, EventArgs e)
        {
            string temp = txtTemperatura.Text;

            if (temp != "")
            {
                float tempNum = 0;
                if(float.TryParse(temp, out tempNum))
                {
                    System.Console.WriteLine(tempNum);
                    float newTemp = (tempNum * 9 / 5) + 32;
                    txtTemperaturaResult.Text = newTemp.ToString() + " °F";
                }
            }
        }

        private void btnEspacios_Click(object sender, EventArgs e)
        {
            string texto = txtEspacios.Text;

            int espacios = texto.Split().Length - 1;

            txtEspaciosResult.Text = "El texto contiene " + espacios + " espacios";
        }

        private void btnEnter(Button btn)
        {
            btn.BackColor = Color.Orange;
        }

        private void btnLeave(Button btn)
        {
            btn.BackColor = Color.FromArgb(255, 128, 0);
        }

        private void btnTemperatura_MouseEnter(object sender, EventArgs e)
        {
            btnEnter(btnTemperatura);
        }

        private void btnTemperatura_MouseLeave(object sender, EventArgs e)
        {
            btnLeave(btnTemperatura);
        }

        private void btnEspacios_MouseEnter(object sender, EventArgs e)
        {
            btnEnter(btnEspacios);
        }

        private void btnEspacios_MouseLeave(object sender, EventArgs e)
        {
            btnLeave(btnEspacios);
        }
    }
}
