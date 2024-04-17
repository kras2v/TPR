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
    public class BookOrderTests
    {
        [TestMethod()]
        public void ProcessTest()
        {
            // Arrange
            var writer = new StringWriter();
            Console.SetOut(writer);
            var bookOrder = new BookOrder();

            // Act
            bookOrder.Process();
            string result = writer.ToString();

            // Assert
            Assert.AreEqual("Processing book order...", result.Trim());
        }
    }
}