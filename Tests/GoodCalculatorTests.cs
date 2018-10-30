using System;
using System.Collections.Generic;
using DependencyExample;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Tests
{
    [TestClass]
    public class GoodCalculatorTests
    {
        [TestMethod]
        public void CalculateTest()
        {
            var mockedRepository = new Mock<IRepository>();
            mockedRepository.Setup(p => p.GetDrugs()).Returns(new List<Good>()
            {
                new Good(){Price = 112},
                new Good(){Price = 113},
            });
            var expected = 225;
            var result= new DrugCalculator(mockedRepository.Object).CalculateSum();

            Assert.AreEqual(expected,result);
        }
    }
}
