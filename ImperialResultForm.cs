using System;
using System.Windows.Forms;

namespace BMI_Calculator
{
    public partial class ImperialResultForm : Form
    {
        public ImperialResultForm()
        {
            InitializeComponent();
        }


        //When new window loads show text
        private void resultForm_Load(object sender, EventArgs e)
        {
            //Grab values from the first window
            decimal height = IntroForm.imperialH;
            decimal weight = IntroForm.imperialW;
            double bmi = IntroForm.imperialbmi;
            string category = IntroForm.imperialcategory;


            impHeightLabel.Text = String.Format("Height (in): {0}", height.ToString("0"));
            impWeightLabel.Text = String.Format("Weight (lbs): {0}", weight.ToString("0"));
            bmiNumLabel.Text = String.Format("BMI Score: {0}", bmi.ToString("0"));
            bmiCatLabel.Text = String.Format("Category: {0}", category);
        }
    }
}
