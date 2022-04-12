using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("hannah", true)]
        [InlineData("levels", false)]
        [InlineData("ciVIc", true)]
        [InlineData("Nun", true)]
        [InlineData("", true)]
        [InlineData(null, false)]
        [InlineData("Test", false)]
        [InlineData("never odd or even", false)]
        [InlineData("was it a cat I saw", false)]
        public void PalindromeTester(string word, bool expected)
        {
            //Arrange
            var wordSmith = new WordSmith();
            //Act
            var actual = wordSmith.IsAPAlindrome(word);
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
