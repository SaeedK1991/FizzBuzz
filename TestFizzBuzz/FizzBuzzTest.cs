using FizzBuzzGame;
using FluentAssertions;
using System;
using Xunit;

namespace TestFizzBuzz
{
    public class FizzBuzzTest
    {
        private readonly FizzBuzz _sut;
        public FizzBuzzTest()
        {
            _sut = new FizzBuzz();
        }


        [Fact]
        public void Divided_Should_Be_Zero_When_Is_Three()
        {
            var number = 9;
            var expect = _sut.CheckedDivisibilityOnThree(number);
            expect.Should().Be(0);
        }

    }
}
