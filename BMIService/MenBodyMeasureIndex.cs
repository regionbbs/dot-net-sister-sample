using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMIService
{
    public class MenBodyMeasureIndex : IBodyMeasureIndex
    {
        public MeasureResult Calculate(double Height, double Weight, out double BMI)
        {
            BMI = Weight / Math.Pow(Height, 2);

            if (BMI < 20)
                return MeasureResult.Less;
            else if (BMI > 25)
                return MeasureResult.More;
            else
                return MeasureResult.Normal;
        }
    }
}
