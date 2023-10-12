using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double weight = 0;
            double height = 0;
            double bmi = 0;
            string errorList = "";
            try 
            {
                weight = double.Parse(textBox1.Text) * 0.45359237;
            } 
            catch 
            {
                if (textBox1.Text.Equals(""))
                {
                    errorList = "Weight has no value \n";
                }
                else
                {
                    errorList = "Weight has wrong value \n";
                }
            }
            try
            {
                height = double.Parse(textBox2.Text) * 2.54;
            }
            catch
            {
                if (textBox2.Text.Equals(""))
                {
                    errorList = "Height has no value \n";
                }
                else
                {
                    errorList = "Height has wrong value \n";
                }
            }
            if (errorList.Equals(""))
            {
                bmi = weight/Math.Pow(height*0.01, 2);
                if (bmi < 18.5)
                {
                    label3.Text = "BMI: " + bmi + "\n" + "Status: underweight";
                }
                else if (bmi > 25)
                {
                    label3.Text = "BMI: " + bmi + "\n" + "Status: overrweight";
                }
                else 
                {
                    label3.Text = "BMI: " + bmi + "\n" + "Status: ok";
                }
                
            }
            else
            {
                MessageBox.Show(errorList);
            }
        }
    }
}
