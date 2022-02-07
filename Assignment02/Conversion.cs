using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02
{
    public class Conversion
    {

        private double valueConverter;

        public Conversion()
        {

            this.valueConverter = 1;
        }
        public Conversion(double valueConverter)
        {
            this.valueConverter = valueConverter;

        }

        public double ConvertCelciusToFahrenheit()
        {
            //(1 °C × 9/5) + 32 = 33,8 °F
            return (valueConverter * 9 / 5) + 32;

        }

        public double ConvertCelciusToKelvin()
        {
            //1 °C + 273,15 = 274,15 K
            return valueConverter + 273.15;
        }

        public double ConvertKelvinToFahrenheit()
        {
            // (1 K − 273,15) × 9 / 5 + 32 = -457,9 °F
            return (valueConverter - 273.15) * 9 / 5 + 32;
        }

        public double ConvertKelvinToCelsius()
        {
            // 1 K − 273,15 = -272,1 °C
            return valueConverter - 273.15;
        }

        public double ConvertFahrenheitToKelvin()
        {
            //(32 °F − 32) × 5/9 + 273,15 = 273,15 K
            return (valueConverter - 32) * 5 / 9 + 273.15;
        }

        public double ConvertFahrenheitToCelsius()
        {
            //(32 °F − 32) × 5/9 = 0 °C
            return (valueConverter - 32) * 5 / 9;
        }

    }
}
