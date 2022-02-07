using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Assignment02;

namespace Assignment02_QA
{
    [TestClass]
    public class ConversionTest
    {
        [TestMethod]
        public void CelciusToFahrenheit_DefaultConstrutor()
        {
            // Arrange 
            Conversion conversion = new Conversion();
            

            // Act
            double v = conversion.ConvertCelciusToFahrenheit();

            // Assert 
            Assert.AreEqual(33.8 , v);
           
        }
        [TestMethod]
        public void CelciusToFahrenheit_CustonConstrutor()
        {
            // Arrange 
            Conversion conversion = new Conversion(2);
     

            // Act
            double v = conversion.ConvertCelciusToFahrenheit();

            // Assert 
            Assert.AreEqual(35.6, v);

        }

        [TestMethod]
        public void CelciusToFahrenheit_NegativeValue()
        {
            // Arrange 
            Conversion conversion = new Conversion(-2);
           

            // Act
            double v = conversion.ConvertCelciusToFahrenheit();

            // Assert 
            Assert.AreEqual(28.4, v);

        }
        //-------------------------------------


        [TestMethod]
        public void CelciusToKelvin_DefaultConstrutor()
        {
            // Arrange 
            Conversion conversion = new Conversion();


            // Act
            double v = conversion.ConvertCelciusToKelvin();

            // Assert 
            Assert.AreEqual(274.15, v);

        }
        [TestMethod]
        public void CelciusToKelvin_CustonConstrutor()
        {
            // Arrange 
            Conversion conversion = new Conversion(2);


            // Act
            double v = conversion.ConvertCelciusToKelvin();

            // Assert 
            Assert.AreEqual(275.15, v);

        }

        [TestMethod]
        public void CelciusToKelvin_NegativeValue()
        {
            // Arrange 
            Conversion conversion = new Conversion(-2);


            // Act
            double v = conversion.ConvertCelciusToKelvin();

            // Assert 
            Assert.AreEqual(271.15, v);

        }
        //-------------------------------------
          [TestMethod]
           public void ConvertFahrenheitToCelsius_DefaultConstrutor()
           {
               // Arrange 
               Conversion conversion = new Conversion();


               // Act
               double v = conversion.ConvertFahrenheitToCelsius();
               v = Math.Round(v, 2);

            // Assert 
            Assert.AreEqual(-17.22, v);

           }
           [TestMethod]
           public void ConvertFahrenheitToCelsius_CustonConstrutor()
           {
               // Arrange 
               Conversion conversion = new Conversion(2);


               // Act
               double v = conversion.ConvertFahrenheitToCelsius();
               v = Math.Round(v, 2);
           
              // Assert 
             Assert.AreEqual(-16.67, v);

           }

           [TestMethod]
           public void ConvertFahrenheitToCelsius_NegativeValue()
           {
               // Arrange 
               Conversion conversion = new Conversion(-2);


               // Act
               double v = conversion.ConvertFahrenheitToCelsius();
              v = Math.Round(v, 2);
            // Assert 
            Assert.AreEqual(-18.89, v);

           }
           //-------------------------------------*/

         [TestMethod]
         public void FahrenheitToKelvin_DefaultConstrutor()
         {
             // Arrange 
             Conversion conversion = new Conversion();


             // Act
             double v = conversion.ConvertFahrenheitToKelvin();
             v = Math.Round(v, 2);

            // Assert 
            Assert.AreEqual(255.93 , v);

         }
         [TestMethod]
         public void FahrenheitToKelvin_CustonConstrutor()
         {
             // Arrange 
             Conversion conversion = new Conversion(2);


             // Act
             double v = conversion.ConvertFahrenheitToKelvin();
             v = Math.Round(v, 2);
            // Assert 
            Assert.AreEqual(256.48, v);
           
        }

         [TestMethod]
         public void FahrenheitToKelvin_NegativeValue()
         {
             // Arrange 
             Conversion conversion = new Conversion(-2);


             // Act
             double v = conversion.ConvertFahrenheitToKelvin();
              v = Math.Round(v, 2);
            // Assert 
            Assert.AreEqual(254.26, v);

         }
         //-------------------------------------ok

        
        [TestMethod]
        public void KelvinToCelsius_DefaultConstrutor()
        {
            // Arrange 
            Conversion conversion = new Conversion();


            // Act
            double v = conversion.ConvertKelvinToCelsius();

            // Assert 
            Assert.AreEqual(-272.15, v);

        }
        [TestMethod]
        public void KelvinToCelsius_CustonConstrutor()
        {
            // Arrange 
            Conversion conversion = new Conversion(2);


            // Act
            double v = conversion.ConvertKelvinToCelsius();

            // Assert 
            Assert.AreEqual(-271.15, v);

        }

        [TestMethod]
        public void KelvinToCelsius_NegativeValue()
        {
            // Arrange 
            Conversion conversion = new Conversion(-2);


            // Act
            double v = conversion.ConvertKelvinToCelsius();

            // Assert 
            Assert.AreEqual(-275.15, v);

        }
        //------------------------------------- ok
        [TestMethod]
        public void CKelvinToFahrenheit_DefaultConstrutor()
        {
            // Arrange 
            Conversion conversion = new Conversion();


            // Act
            double v = conversion.ConvertKelvinToFahrenheit();

            // Assert 
            Assert.AreEqual(-457.87, v);

        }
        [TestMethod]
        public void KelvinToFahrenheit_CustonConstrutor()
        {
            // Arrange 
            Conversion conversion = new Conversion(2);


            // Act
            double v = conversion.ConvertKelvinToFahrenheit();

            // Assert 
            Assert.AreEqual(-456.07, v);

        }

        [TestMethod]
        public void KelvinToFahrenheit_NegativeValue()
        {
            // Arrange 
            Conversion conversion = new Conversion(-2);


            // Act
            double v = conversion.ConvertKelvinToFahrenheit();

            // Assert 
            Assert.AreEqual(-463.27, v);

        }
        //-------------------------------------
    }
}
