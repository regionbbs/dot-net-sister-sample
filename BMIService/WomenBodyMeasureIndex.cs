using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMIService
{
    public class WomenBodyMeasureIndex : IBodyMeasureIndex
    {
        public MeasureResult Calculate(double Height, double Weight, out double BMI)
        {
            BMI = Weight / Math.Pow(Height, 2);

            if (BMI < 18)
                return MeasureResult.Less;
            else if (BMI > 22)
                return MeasureResult.More;
            else
                return MeasureResult.Normal;
        }
    }
}
