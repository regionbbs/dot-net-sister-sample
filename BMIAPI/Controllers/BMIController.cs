using BMIService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace BMIAPI.Controllers
{
    public class BMIController : ApiController
    {
        [HttpPost]
        public async Task<string> Women()
        {
            var forms = await Request.Content.ReadAsFormDataAsync();

            double height = Convert.ToDouble(forms["height"]);
            double weight = Convert.ToDouble(forms["weight"]);

            IBodyMeasureIndex bmiService = new WomenBodyMeasureIndex();
            double bmi = 0.0d;
            MeasureResult result = bmiService.Calculate(height, weight, out bmi);

            switch (result)
            {
                case MeasureResult.Less:
                    return "太瘦";
                case MeasureResult.More:
                    return "太胖";
                case MeasureResult.Normal:
                    return "剛好";
                default:
                    return "";
            }
        }

        [HttpPost]
        public async Task<string> Men()
        {
            var forms = await Request.Content.ReadAsFormDataAsync();

            double height = Convert.ToDouble(forms["height"]);
            double weight = Convert.ToDouble(forms["weight"]);

            IBodyMeasureIndex bmiService = new MenBodyMeasureIndex();
            double bmi = 0.0d;
            MeasureResult result = bmiService.Calculate(height, weight, out bmi);

            switch (result)
            {
                case MeasureResult.Less:
                    return "太瘦";
                case MeasureResult.More:
                    return "太胖";
                case MeasureResult.Normal:
                    return "剛好";
                default:
                    return "";
            }
        }
    }
}
