using System;
using Xunit;

namespace GradeBook.Tests
{
    public class BookTests
    {
        [Fact]
        public void Test1()
        {   
            // tripe A or AAA (arrange, act, assert)
            
            // arrange (data, arrangements)
            var book = new Book("");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.3);

            //act (perform action)
            Statistics stats = book.GetStatistics();

            // assert
            Assert.Equal(85.6, stats.Average, 1);
            Assert.Equal(90.5, stats.High, 1);
            Assert.Equal(77.3, stats.Low, 1);
        }
    }
}