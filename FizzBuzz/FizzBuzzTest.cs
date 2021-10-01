using FizzBuzzKataNameSpace;
using System;
using Xunit;

namespace FizzBuzzTestNameSpace
{
    public class FizzBuzz
    {
        private FizzBuzzKata _sut;

        public FizzBuzz()
        {
            _sut = new FizzBuzzKata();
        }

        [Theory]
        [InlineData(new object[] { 1 }, 1)]
        public void get1WhenValueIs1Test(object[] arrayNumbers, int expected)
        {
            /// Act
            var result = _sut.getFizzBuzzKata(arrayNumbers);
            /// Assert 
            Assert.Equal(expected, result[0]);
        }

        [Theory]
        [InlineData(new object[] { 1,2,3  }, "Fizz")]
        public void getFizzWhenValueIs3Test(object[] arrayNumbers, string expected)
        {
            /// Act
            var result = _sut.getFizzBuzzKata(arrayNumbers);
            /// Assert 
            Assert.Equal(expected,result[2]);
        }

        [Theory]
        [InlineData(new object[] { 1, 2, 3,4,5 }, "Buzz")]
        public void getBuzzWhenValueIs5Test(object[] arrayNumbers, string expected)
        {
            /// Act
            var result = _sut.getFizzBuzzKata(arrayNumbers);
            /// Assert 
            Assert.Equal(expected, result[4]);
        }

        [Theory]
        [InlineData(new object[] { 1, 2, 3, 4, 5, 6 ,7 ,8 ,9 ,10, 11, 12 , 13 , 14 ,15, 16, 17 ,18 ,19 ,20}, new object[] { 1,2, "Fizz", 4, "Buzz", "Fizz", 7, 8, "Fizz", "Buzz", 11,
                                                                                                        "Fizz", 13, 14, "FizzBuzz",16,17,"Fizz",19,"Buzz" })]
        public void getFizzBuzzFor20Values(object[] arrayNumbers, object[] expected)
        {
            /// Act
            var result = _sut.getFizzBuzzKata(arrayNumbers);
            /// Assert 
            Assert.Equal(expected, result);
        }
    }
}
