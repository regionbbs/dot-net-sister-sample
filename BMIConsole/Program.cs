using BMIService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMIConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入身高 (公尺)：");
            string heightInput = Console.ReadLine();
            Console.WriteLine("請輸入體重 (公斤)：");
            string weightInput = Console.ReadLine();
            Console.WriteLine("你是公的嗎? (請輸入y/n)：");
            string genderIdent = Console.ReadLine();
            
            double height = 0.0d;

            if (!double.TryParse(heightInput, out height))
            {
                Console.WriteLine("你輸入的不是數字。");
                Console.ReadLine();
                return;
            }

            double weight = 0.0d;
            
            if (!double.TryParse(weightInput, out weight))
            {
                Console.WriteLine("你輸入的不是數字。");
                Console.ReadLine();
                return;
            }

            bool isMale = true;
            double bmi = 0.0d;
            isMale = (genderIdent == "y");

            IBodyMeasureIndex bmiService = null;
            bmiService = new WomenBodyMeasureIndex();

            if (isMale)
                bmiService = new MenBodyMeasureIndex();
            else
                bmiService = new WomenBodyMeasureIndex();

            MeasureResult result = bmiService.Calculate(height, weight, out bmi);

            Console.WriteLine("BMI: {0}", bmi);
            Console.WriteLine("BMI Formatted: {0:0.00}", bmi);

            switch (result)
            {
                case MeasureResult.Less: 
                    Console.WriteLine("太瘦");
                    break;
                case MeasureResult.More: 
                    Console.WriteLine("太胖");
                    break;
                case MeasureResult.Normal: 
                    Console.WriteLine("剛好");
                    break;
            }

            Console.ReadLine();
        }
    }
}
