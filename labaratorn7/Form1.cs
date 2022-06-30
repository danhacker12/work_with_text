using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labaratorn7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
            this.textBox1.Text = "0";
            this.textBox2.Text = "0";
        }
        
        public const double PI = 3.1415926535897931;
        public const double T = 5;

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (textBox1.Visible == true)
            {
                textBox1.Visible = false;
            }
            else
            {
                textBox1.Visible = true;
            }
            
            

        }
        
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (textBox2.Visible == true)
            {
                textBox2.Visible = false;
            }
            else
            {
                textBox2.Visible = true;
            }

        }

        private void Form1_Load(object sender, EventArgs e)        {

        }
        public void MyMethod(double scrol_1, double scrol_2)
        {
            textBox1.Text = scrol_1.ToString();
            double one_1 = Convert.ToDouble(textBox2.Text);//b
            x_label_value.Text = Convert.ToString(PI * scrol_1  * Math.Cos(PI * one_1 * T));


            textBox2.Text = scrol_2.ToString();
            double two_2 = Convert.ToDouble(textBox1.Text);//a
            y_label_value.Text = Convert.ToString(PI * scrol_1 * Math.Sin(PI * one_1 * T));
        }
        
        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

            MyMethod(e.NewValue,Convert.ToDouble(textBox2.Text));
            
        }


        private void hScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            MyMethod(Convert.ToDouble(textBox1.Text),e.NewValue);
        }

        private void button3_Click(object sender, EventArgs e)
        {
          
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
     
       

        

        
    }
 
}
