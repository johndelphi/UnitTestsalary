using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Calculator;

namespace UnitTestsalary
{
    [TestClass]
    public class UnitTest1
    {
        //to get hourly, divide anual salary by 2080
        //100,006.40/ 2080=48.08 hr
        //to get annual pay 48.08hr*2080=100,006.40
        [TestMethod]
        public void AnnualSalaryTest()
        {
            //arrange
            SalaryCalculator ts = new SalaryCalculator();
            //act
            decimal annualSalary = ts.GetAnnualSalary(50);
            //assert
            Assert.AreEqual(104000, annualSalary);
        }
    }
}
