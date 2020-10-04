using System;
using Calculator;
using NUnit.Framework;

namespace CalculatorTests
{
  
    public class Tests
    {
       

        [Test]
        public void AddTest()
        {
            CalculatorApp calculator = new CalculatorApp();

            Assert.AreEqual(4, calculator.Add(2, 2));
        }

        //add more test code here//
       
    }

  
 }