using System;
using BestBuy;
using Xunit;


namespace BestBuyTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("noon", true)]
        [InlineData("dog", false)]
        public void IsThisAPalindrome(string word, bool expected)
        {
            //Arrange - Create an instance of the class that contains the method we want to test
            var palindrome3 = new Palindrome();

            //Act - call the method that we are testing
            var actual = palindrome3.IsThisAPalindrome(word);

            //Assert- see of
            Assert.Equal(expected, actual);


        }
        [Theory]
        [InlineData(1, 1, 2)]
        [InlineData(3,2, 5)]
        [InlineData(4,5, 9)]

        public void SumOfTwoNumbers(int num1, int num2, int expected)
        {
            var cash1 = new CashRegister();

            var actual = cash1.SumofTwoNumbers(num1, num2);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1,1,true)]
        [InlineData(2,2,true)]
        [InlineData(3,2,false)]

        public void AreTheseNumbersTheSame(int num1, int num2, bool expected)
        {
            var profit = new CashOut();

            var actual = profit.AreTheseNumbersTheSame(num1, num2);

            Assert.Equal(expected, actual);
        }
    }
}
