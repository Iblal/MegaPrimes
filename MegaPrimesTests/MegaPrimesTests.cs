using MegaPrimes;

namespace MegaPrimesTests
{

    [TestClass]
    public class MegaPrimesTests
    {
        [TestMethod]
        public void GetMegaPrimes_ReturnsExpectedList_WhenMaxIs10()
        {
            // Arrange
            int max = 10;
            List<int> expectedMegaPrimes = new List<int> { 2, 3, 5, 7 };

            // Act
            List<int> megaPrimes = MegaPrimesLogic.GetMegaPrimes(max);

            // Assert
            CollectionAssert.AreEqual(expectedMegaPrimes, megaPrimes);
        }

        [TestMethod]
        public void GetMegaPrimes_ReturnsExpectedList_WhenMaxIs37()
        {
            // Arrange
            int max = 37;
            List<int> expectedMegaPrimes = new List<int> { 2, 3, 5, 7, 23, 37 };

            // Act
            List<int> megaPrimes = MegaPrimesLogic.GetMegaPrimes(max);

            // Assert
            CollectionAssert.AreEqual(expectedMegaPrimes, megaPrimes);
        }

        [TestMethod]
        public void GetMegaPrimes_ReturnsEmptyList_WhenMaxIs1()
        {
            // Arrange
            int max = 1;

            // Act
            List<int> megaPrimes = MegaPrimesLogic.GetMegaPrimes(max);

            // Assert
            Assert.AreEqual(0, megaPrimes.Count);
        }
    }
}