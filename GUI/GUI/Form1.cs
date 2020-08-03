using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_bmi(object sender, EventArgs e)
        {
            int weight;
            double height;
            double BMI;

            weight = int.Parse(textBox1.Text);
            height = double.Parse(textBox2.Text);

            height = height / 100;

            BMI = (double)(weight) / (height * height);
            Double BMI2 = Math.Round((Double)BMI, 2);

            label4.Visible = true;

            if (BMI < 18.5)
            {
                label4.Text = BMI2 + "\nUnderweight ";
            }
            if (BMI > 18.5 && BMI < 24.9)
            {
                label4.Text = BMI2 + "\nHealthy weight ";
            }
            if (BMI > 25 && BMI < 29.9)
            {
                label4.Text = BMI2 + "\nOverweight ";
            }
            else if (BMI > 30)
            {
                label4.Text = BMI2 + "\nObese ";
            }


        }
    }
}
