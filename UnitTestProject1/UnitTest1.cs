using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Xunit;

namespace UnitTestProject1
{
    
    public class UnitTest1
    {
            [Theory]
            [InlineData("ana", true)]
            [InlineData("bob", true)]
            [InlineData("ara", true)]
            [InlineData("pop", true)]

            public void IsAPalindrome(string names, bool expected)

            {
                var wordSmith = new WordSmith();                 //Arrange
                var actually = wordSmith.IsAPalindrome(names);   //Act
                Assert.Equals(expected, actually);                //Assert

            }
    }   
}
