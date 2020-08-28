using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI_Calculator
{
    public partial class MetricResultForm : Form
    {
        public MetricResultForm()
        {
            InitializeComponent();
        }

        //When new window loads show text
         

        private void MetricResultForm_Load(object sender, EventArgs e)
        {
            //Grab values from IntroForm
            decimal height = IntroForm.metricH;
            decimal weight = IntroForm.metricW;
            double bmi = IntroForm.metricbmi;
            string category = IntroForm.metriccategory;


            metHeightLabel.Text = String.Format("Height (cm): {0}", height.ToString("0"));
            metWeightLabel.Text = String.Format("Weight (kg): {0}", weight.ToString("0"));
            bmiNumLabel.Text = String.Format("BMI Score: {0}", bmi.ToString("0"));
            bmiCatLabel.Text = String.Format("Category: {0}", category);
        }
    }
}
