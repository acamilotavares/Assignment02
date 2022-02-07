using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02
{
    public class Program
    {

        private double value;
        String convertion = "";
        double result;


        static void Main(string[] args)
        {
            Program program = new Program();

            program.Go();

            Console.ReadKey();
        }

        public void Go()
        {

            Console.WriteLine("Please choose one of options:\r\n ");

            /* 1.Convert Celsius to Fahrenheit

             2.Convert Celsius to Kelvin

             3.Convert Fahrenheit to Celsius

             4.Convert Fahrenheit to Kelvin

             5.Convert Kelvin to Celsius

             6.Convert Kelvin to Fahrenheit

             7.Exit*/

            bool contin = true;


            while (contin)
            {

                Console.WriteLine(" 1-Convert Celsius to Fahrenheit \n" +
        " 2-Convert Celsius to Kelvin \r\n" +
        " 3-Convert Fahrenheit to Celsius\r\n" +
        " 4-Convert Fahrenheit to Kelvin\r\n" +
        " 5-Convert Kelvin to Celsius\r\n" +
        " 6-Convert Kelvin to Fahrenheit\r\n" +
        " 7-Exit\r\n");

                string choice = Console.ReadLine();

                int option = int.Parse(choice);
                Conversion conve;

                switch (option)
                {

                    case 1:
                        contin = false;
                        convertion = "1-Convert Celsius to Fahrenheit";
                        consoleRead();
                        conve = new Conversion(value);
                        result = conve.ConvertCelciusToFahrenheit();
                        Console.WriteLine(result);
                        break;

                    case 2:
                        contin = false;
                        convertion = "2-Convert Celsius to Kelvin";
                        consoleRead();
                        conve = new Conversion(value);
                        result = conve.ConvertCelciusToKelvin();
                        Console.WriteLine(result);
                        break;

                    case 3:
                        contin = false;
                        convertion = " 3-Convert Fahrenheit to Celsius";
                        consoleRead();
                        conve = new Conversion(value);
                        result = conve.ConvertFahrenheitToCelsius();
                        Console.WriteLine(result);
                        break;
                    case 4:
                        convertion = "4-Convert Fahrenheit to Kelvin";
                        consoleRead();
                        conve = new Conversion(value);
                        result = conve.ConvertFahrenheitToKelvin();
                        Console.WriteLine(result);
                        break;

                    case 5:
                        contin = false;
                        convertion = "5-Convert Kelvin to Celsius";
                        consoleRead();
                        conve = new Conversion(value);
                        result = conve.ConvertKelvinToCelsius();
                        Console.WriteLine(result);
                        break;
                    case 6:
                        contin = false;
                        convertion = "6-Convert Kelvin to Fahrenheit";
                        consoleRead();
                        conve = new Conversion(value);
                        result = conve.ConvertKelvinToFahrenheit();
                        Console.WriteLine(result);
                        break;
                    case 7:
                        Environment.Exit(0);
                        break;

                    default:
                        contin = true;
                        Console.WriteLine("Informe valor correto:");
                        break;
                }



            }

        }
        private void consoleRead()
        {
            Console.WriteLine(convertion);
            Console.WriteLine("Informe valor:");
            string stvalue = Console.ReadLine();
            value = double.Parse(stvalue);

        }

    }
}
