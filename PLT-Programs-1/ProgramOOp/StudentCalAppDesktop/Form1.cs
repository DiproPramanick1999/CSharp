using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XYZUniversity.ResuktCalculator;

namespace StudentCalAppDesktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Calculate the reuslt - call the backend

            String stName = textBox1.Text;
            int s1 = int.Parse(textBox2.Text);
            int s2 = int.Parse(textBox3.Text);
            int s3 = int.Parse(textBox4.Text);
            double avg = StudentResultCalculator.CalculateAverage(s1, s2, s3);
            string result = StudentResultCalculator.CalculateResult(avg);
            textBox5.Text = $"The result of {stName} is {result}";
        }
    }
}
