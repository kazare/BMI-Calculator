using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BMI_Calculator
{
    interface ICalculator
    {
        //create interface for metric and imperial classes to use
        double height { get; }
        double weight { get; }
    }
}
