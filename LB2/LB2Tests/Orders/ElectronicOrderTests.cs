using Microsoft.VisualStudio.TestTools.UnitTesting;
using LB2.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB2.Orders.Tests
{
    [TestClass()]
    public class ElectronicOrderTests
    {
        [TestMethod()]
        public void ValidateTest()
        {
            // Arrange
            var writer = new StringWriter();
            Console.SetOut(writer);
            var electronicOrder = new ElectronicOrder();

            // Act
            electronicOrder.Validate();
            string result = writer.ToString();

            // Assert
            Assert.AreEqual("Electronic order validated.", result.Trim());
        }
    }
}