using System;

namespace BMI_Calculator
{
    //inherit abstract class. 
    //Imperial class used for imperial formula
    public class Imperial : Calculator, ICalculator
    {
        //implement interface
        public double height { get; }
        public double weight { get; }

        //constructor to reuse variables inside of class.
        public Imperial(double height, double weight)
        {
            this.height = height;
            this.weight = weight;
        }

        public override double Calc()
        {
            double bmi = 703 * (weight / Math.Pow(height, 2));

            return bmi;
        }
    }
}
