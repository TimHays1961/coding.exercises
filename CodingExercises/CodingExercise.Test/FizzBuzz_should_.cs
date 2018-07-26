using CodingExercises;
using System;
using Xunit;

namespace CodingExercise.Test
{
    public class FizzBuzz_should_
    {
        [Fact]
        public void return_fizz_when_input_is_divisible_by_3()
        {
            var fizzBuzz = new FizzBuzz();

            var output = fizzBuzz.ParseNumber(3);

            Assert.Equal("Fizz", output);
        }
        [Fact]
        public void return_buzz_when_input_is_divisible_by_5()
        {
            var fizzBuzz = new FizzBuzz();

            var output = fizzBuzz.ParseNumber(5);

            Assert.Equal("Buzz", output);
        }
        [Fact]
        public void return_fizzbuzz_when_input_is_divisible_by_3_and_5()
        {
            var fizzBuzz = new FizzBuzz();

            var output = fizzBuzz.ParseNumber(15);

            Assert.Equal("FizzBuzz", output);
        }
        [Fact]
        public void return_number_when_none_of_the_above_is_true()
        {
            var fizzBuzz = new FizzBuzz();
            const int numberThatIsNotDivisibleBy3or5 = 1376; 
            var output = fizzBuzz.ParseNumber(numberThatIsNotDivisibleBy3or5);

            Assert.Equal(numberThatIsNotDivisibleBy3or5.ToString(), output);
        }
    }
}
