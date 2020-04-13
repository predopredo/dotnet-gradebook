using System;
using Xunit;

namespace GradeBook.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {   
            // tripe A or AAA (arrange, act, assert)
            // arrange (data, arrangements)
            int x = 5;
            int y = 2;
            int expected = 7;

            //act (perform action)
            int actual = x + y;
            // assert
            Assert.Equal(expected, actual);
        }
    }
}
