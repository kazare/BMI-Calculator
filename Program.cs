using System;
using System.Windows.Forms;

namespace BMI_Calculator
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new IntroForm());

        }

        //BELOW IS BASE CODE TO PROVIDE FUNCTIONALITY
        //Different classes called if user chooses imperial or metric
        public static double imperial(double height, double weight)
        {
            //instantiate new class
            Imperial imp = new Imperial(height, weight);

            //round number to one decimal place
            double bmi = Math.Round(imp.Calc(), 1);

            return bmi;
        }

        public static double metric(double height, double weight)
        {
            //instantiate new class
            Metric imp = new Metric(height, weight);

            //round number to one decimal place
            double bmi = Math.Round(imp.Calc(), 1);

            return bmi;
        }

        //function to categorize BMI
        public static string BmiCategory(double BMI)
        {
            string status;

            if (BMI < 18.5)
            {
                status = "Underweight";
                return status;

            }
            else if (BMI > 18.4 && BMI < 25.0)
            {
                status = "Healthy Weight";
                return status;
            }
            else if (BMI > 24.9 && BMI < 30.0)
            {
                status = "Overweight";
                return status;
            }
            else if (BMI > 29.9)
            {
                status = "Obese";
                return status;
            }
            else
            {
                status = "Error: Unable to categorize";
                return status;
            }
        }

    }
}
