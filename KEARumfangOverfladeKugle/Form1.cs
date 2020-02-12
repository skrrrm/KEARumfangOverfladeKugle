using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KEARumfangOverfladeKugle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Variabler
        double r, volume, area;
        private void buttonCalc_Click(object sender, EventArgs e)
        {
            try // Error text if wrong input - i.e. digits#
            {
                r = Convert.ToDouble(textBoxRadius.Text); // Converts input in textbox to number
            }
            catch
            {
                labelError.Text = "Only use numbers."; // error
            }

            volume = 4 / 3 * Math.PI * Math.Pow(r, 3); // supposed formula for volume of a ball
            area = 4 * Math.PI * Math.Pow(r, 2); // supposed formula for area of a ball

            textBoxVolume.Text = Convert.ToString(Math.Round(volume, 2)); // round down to 2 decimals and converts to string and inputs to textbox
            textBoxArea.Text = Convert.ToString(Math.Round(area, 2)); // ------ || -----
        }
    }
}
