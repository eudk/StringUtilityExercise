using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringUtilityExercise;

namespace TestStringUtility
{
    [TestClass()]
    public class StringUtilityTests
    {
        [TestMethod]
        public void ShouldFindOneYInMysterious()
        {
            string stringToCheck = "mysterious";
            string stringToFind = "y";
            int expectedResult = 1;

            StringUtility classUnderTest = new StringUtility();
            int actualResult = classUnderTest.CountOccurences(stringToCheck, stringToFind);
            Assert.AreEqual(expectedResult, actualResult);
        }


        [TestMethod]
        public void ShouldFindTwoSInMysterious()
        {
            string stringToCheck = "mysterious";
            string stringToFind = "s";
            int expectedResult = 2;

            StringUtility classUnderTest = new StringUtility();
            int actualResult = classUnderTest.CountOccurences(stringToCheck, stringToFind);
            Assert.AreEqual(expectedResult, actualResult);
        }



        [TestMethod]
        public void SearchShouldBeCaseInsensitive()
        {
            string stringToCheck = "mySterious";
            string stringToFind = "s";
            int expectedResult = 2;

            StringUtility classUnderTest = new StringUtility();
            int actualResult = classUnderTest.CountOccurences(stringToCheck, stringToFind);
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}