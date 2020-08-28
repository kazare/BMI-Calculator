using System;
using System.Windows.Forms;

namespace BMI_Calculator
{
    public partial class IntroForm : Form
    {
        public IntroForm()
        {
            InitializeComponent();
        }

        //Create variables to store info

        //Imperial
        public static decimal imperialH;
        public static decimal imperialW;
        public static double imperialbmi;
        public static string imperialcategory;

        //Metric
        public static decimal metricH;
        public static decimal metricW;
        public static double metricbmi;
        public static string metriccategory;


        //If the Imperial radio button is checked the Imperial group is available
        public void imperialRadio_CheckedChanged(object sender, EventArgs e)
        {
            imperialGroup.Enabled = imperialRadio.Checked;
        }

        //If the Metric radio button is checked the Metric group is available
        public void metricRadio_CheckedChanged(object sender, EventArgs e)
        {
            metricGroup.Enabled = metricRadio.Checked;
        }

        //On submit open new window
        private void submitButton_Click(object sender, EventArgs e)
        {
            //store values to be used for calculation and the next window

            //Imperial
            imperialH = heightIn.Value; //store value of height into variable
            imperialW = weightLbs.Value;//store value of weight in to variable
            imperialbmi = Program.imperial((double)heightIn.Value, (double)weightLbs.Value);//Call fucntion in Program
            imperialcategory = Program.BmiCategory(imperialbmi);//Call function in Program

            //Metric
            metricH = heightCm.Value;
            metricW = weightKg.Value;
            metricbmi = Program.metric((double)heightCm.Value, (double)weightKg.Value); ;
            metriccategory = Program.BmiCategory(metricbmi);

            //Open BMI chart
            BMITable openBMITable = new BMITable(); //this is the change, code for redirect  
            openBMITable.Show();

            //Opens a different window depending if metric or imperial is chosen
            if (imperialRadio.Checked == true)
            {
                ImperialResultForm openImperialResultForm = new ImperialResultForm(); //this is the change, code for redirect  
                openImperialResultForm.Show();
            }
            else if (metricRadio.Checked == true)
            {
                MetricResultForm openMetricResultForm = new MetricResultForm(); //this is the change, code for redirect  
                openMetricResultForm.Show();
            }

        }


    }
}
