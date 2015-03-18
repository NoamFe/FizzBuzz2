using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;

namespace FizzBuzz
{
    [TestFixture]
    class FizzBuzzTest
    {
        [Test]
        public void Should_Return_Succesfully_For_16_Numbers()
        {
            
           var fizzBuzz = new FizzBuzz();
           var result = fizzBuzz.Run(1, 16, new Dictionary<int, string> { { 3, "Fizz" }, { 5, "Buzz" } });

           var expectedResult = new ArrayList { "1","2","Fizz","4","Buzz","Fizz","7","8","Fizz","Buzz","11","Fizz","13","14","FizzBuzz","16"};
           CollectionAssert.AreEqual(expectedResult, result);
           
        }

        [Test]
        public void Should_Return_Succesfully_With_Out_Of_Order_Values_And_Multi_Values()
        {

            var fizzBuzz = new FizzBuzz();
            var result = fizzBuzz.Run(1, 16, new Dictionary<int, string> { { 3, "Fizz" }, { 5, "Buzz" }, { 2, "XX" } });

            var expectedResult = new ArrayList {"1","XX","Fizz","XX","Buzz","XXFizz","7","XX","Fizz","XXBuzz","11","XXFizz","13","XX","FizzBuzz","XX"};
            CollectionAssert.AreEqual(expectedResult, result);

        }

        [Test, ExpectedException(typeof(System.Exception), ExpectedMessage = "To Number Must Be Bigger Than From Number")]
        public void Should_Throw_Exception_On_Incorrect_Range()
        {
            var fizzBuzz = new FizzBuzz();
            fizzBuzz.Run(1, -6, new Dictionary<int, string> { { 3, "Fizz" }, { 5, "Buzz" } });
        }


        [Test, ExpectedException(typeof(System.Exception), ExpectedMessage = "Input Values Must Contain At Least One Value")]
        public void Should_Throw_Exception_On_Incorrect_Values()
        {

            var fizzBuzz = new FizzBuzz();
            fizzBuzz.Run(1, 100, new Dictionary<int, string>());

        }

        [Test]
        public void Should_Work_For_Negative_Numbers()
        {
            var fizzBuzz = new FizzBuzz();
            var result = fizzBuzz.Run(-2, 3, new Dictionary<int, string> { { 3, "Fizz" }, { 5, "Buzz" } });

            var expectedResult = new ArrayList { "-2", "-1", "FizzBuzz", "1", "2", "Fizz"};
            CollectionAssert.AreEqual(expectedResult, result);

        }

    }
}
