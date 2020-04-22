using System;
using Xunit;

namespace GradeBook.Tests
{
    public class TypeTests
    {

        [Fact]
        public void ValueTypesAlsoPassByValue()
        {
            int x = GetInt();
            SetInt(ref x);

            Assert.Equal(42, x);
        }

        private void SetInt(ref int x)
        {
            x = 42;
        }

        private int GetInt()
        {
            return 3;
        }

        [Fact]
        public void CSharpIsPassByValue()
        {
            // tripe A or AAA (arrange, act, assert)

            // arrange (data, arrangements)
            var book1 = GetBook("Book 1"); //book1 stores pointer value to new book, Book 1
            GetBookSetName(book1, "New Name"); //book1 = pointer to Book 1
                                               //act (perform action)

            // assert
            Assert.Equal("Book 1", book1.Name);
        }

        private void GetBookSetName(Book book, string name)
        {
            book = new Book(name); //changes pointer  to a new Book object. book1 reference stays the same
        }

        [Fact]
        public void CSharpCanPassByReference()
        {
            // tripe A or AAA (arrange, act, assert)

            // arrange (data, arrangements)
            var book1 = GetBook("Book 1"); //book1 stores pointer value to new book, Book 1
            GetBookSetName(ref book1, "New Name"); //book1 = pointer to Book 1
                                                   //act (perform action)

            // assert
            Assert.Equal("New Name", book1.Name);
        }

        private void GetBookSetName(ref Book book, string name)
        {
            book = new Book(name); //changes pointer  to a new Book object. book1 reference stays the same
        }

        [Fact]
        public void CanSetNameFromReference()
        {
            // tripe A or AAA (arrange, act, assert)

            // arrange (data, arrangements)
            var book1 = GetBook("Book 1");
            SetName(book1, "New Name");
            //act (perform action)

            // assert
            Assert.Equal("New Name", book1.Name);
        }

        private void SetName(Book book, string name)
        {
            book.Name = name;
        }

        [Fact]
        public void StringsBehaveLikeValueTypes()
        {
            string name = "Scott";
            string upper = MakeUpperCase(name);

            Assert.Equal(name, "Scott");
            Assert.Equal(upper, "SCOTT");
        }

        private string MakeUpperCase(string parameter)
        {
            return parameter.ToUpper();
        }

        [Fact]
        public void GetBookReturnsDifferentObjects()
        {
            // tripe A or AAA (arrange, act, assert)

            // arrange (data, arrangements)
            var book1 = GetBook("Book 1");
            var book2 = GetBook("Book 2");

            //act (perform action)

            // assert
            Assert.Equal("Book 1", book1.Name);
            Assert.Equal("Book 2", book2.Name);
            Assert.NotSame(book1, book2);
        }

        [Fact]
        public void TwoVariablesCanReferenceSameObject()
        {
            // tripe A or AAA (arrange, act, assert)

            // arrange (data, arrangements)
            var book1 = GetBook("Book 1");
            var book2 = book1;

            //act (perform action)

            // assert
            Assert.Same(book1, book2); // == Asset.True(Object.ReferenceEquals(book1, book2));
        }

        private Book GetBook(string name)
        {
            return new Book(name);
        }
    }
}
