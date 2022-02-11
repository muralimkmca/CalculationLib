using CalculationLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace unittestsample
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void Test_Calculate_Divide()
        {
            //Arrange
            int n1 = 5;
            int n2 = 2;
            int quores = 2;

            //Act
            Calculator ca = new Calculator();
            int actres = ca.dividingOperation(n1, n2);

            //Assert
            Assert.IsNotNull(actres);
            Assert.AreEqual(quores, actres);
        }

        [TestMethod]
        public void Test_Calculate_Divide_With_Negative_values()
        {
            //Arrange
            int n1 = -6;
            int n2 = -2;
            int quores = 3;

            //Act
            Calculator ca = new Calculator();
            int actres = ca.dividingOperation(n1, n2);

            //Assert
            Assert.IsNotNull(actres);
            Assert.AreEqual(quores, actres);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void Test_Calculate_Divide_Method_Exception_DivideByZero()
        {
            //Arrange
            int n1 = 1;
            int n2 = 0;            

            //Act
            Calculator ca = new Calculator();
            int actres = ca.dividingOperation(n1, n2);

            //Assert           
            
        }
    }
}
