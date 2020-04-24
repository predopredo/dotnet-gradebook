using Xunit;

namespace GradeBook.Tests
{
    public class BookTests
    {
        [Fact]
        public void BookCalculatesGradeStatistics()
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
            Assert.Equal("B", stats.Letter);
        }

        [Fact]
        public void AverageNinetyFiveOrMoreGivesAPlus()
        {
            //arrange
            var book2 = new Book("");
            book2.AddGrade(95);
            book2.AddGrade(95);
            book2.AddGrade(95);

            var book3 = new Book("");
            book2.AddGrade(100);
            book2.AddGrade(95);
            book2.AddGrade(98);

            //act
            Statistics stats2 = book2.GetStatistics();
            Statistics stats3 = book2.GetStatistics();

            //assert
            Assert.Equal("A+", stats2.Letter);
            Assert.Equal("A+", stats3.Letter);
        }
    }
}
