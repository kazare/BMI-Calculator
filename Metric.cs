using System;

namespace BMI_Calculator
{
    //inherit abstract class. 
    //Metric class used for metric formula
    class Metric : Calculator, ICalculator
    {
        //implement interface
        public double height { get; }
        public double weight { get; }

        //constructor to reuse variables inside of class.
        public Metric(double height, double weight)
        {
            this.height = height;
            this.weight = weight;
        }

        public override double Calc()
        {
            double bmi = weight / Math.Pow(height, 2) * 10000;

            return bmi;
        }
    }
}
