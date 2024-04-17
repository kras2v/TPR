using LB1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace tpr_1.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        [DataRow(new int[] { 1, 5, 4, 3, 6 }, new int[] { 1, 3, 4, 5, 6 })]
        [DataRow(new int[] { 2, 4, 1, 2, 3 }, new int[] { 1, 2, 2, 3, 4 })]
        [DataRow(new int[] { 10, 11, 41, 23, 64 }, new int[] { 10, 11, 23, 41, 64 })]
        public async Task SortTest(int[] arrayToSort, int[] sortedArray)
        {
            //Act
            await Program.Sort(arrayToSort);

            //Assert
            CollectionAssert.AreEqual(sortedArray, arrayToSort);
        }

        [TestMethod()]
        [DataRow("1", 1)]
        [DataRow("11", 11)]
        [DataRow("4", 4)]
        public void ConverterTest(string input, int expected)
        {
            // Arrange
            var reader = new StringReader(input);
            Console.SetIn(reader);

            // Act
            var result = Program.Converter();

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        [DataRow("1\n2\n4\n5", new int[] { 1, 2, 4, 5 }, 4)]
        [DataRow("3\n2\n2\n1", new int[] { 3, 2, 2, 1 }, 4)]
        [DataRow("5\n1\n2\n5\n2\n4", new int[] { 5, 1, 2, 5, 2, 4 }, 6)]
        public void FillTest(string input, int[] expected, int size)
        {
            //Arrange
            var reader = new StringReader(input);
            Console.SetIn(reader);
            var actual = new int[size];

            //Act
            Program.Fill(ref actual);

            //Assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void PrintTest()
        {
            //Arrange
            var expected = "1 2 4 5 6";
            var output = new StringWriter();
            Console.SetOut(output);

            var arrayToPrint = new int[] { 1, 2, 4, 5, 6 };

            //Act
            Program.Print(arrayToPrint);
            var result = output.ToString().Trim();

            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}
