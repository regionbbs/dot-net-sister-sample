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
            isMale = (genderIdent == "y");

            double bmi = weight / Math.Pow(height, 2);

            Console.WriteLine("BMI: {0}", bmi);
            Console.WriteLine("BMI Formatted: {0:0.00}", bmi);

            if (isMale)
            {
                if (bmi < 20)
                    Console.WriteLine("太瘦");
                else if (bmi > 25)
                    Console.WriteLine("太胖");
                else
                    Console.WriteLine("剛好");
            }
            else
            {
                if (bmi < 18)
                    Console.WriteLine("太瘦");
                else if (bmi > 22)
                    Console.WriteLine("太胖");
                else
                    Console.WriteLine("剛好");
            }

            Console.ReadLine();
        }
    }
}
