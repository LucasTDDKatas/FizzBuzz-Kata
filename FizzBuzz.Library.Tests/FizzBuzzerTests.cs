using NUnit.Framework;
using System;

namespace FizzBuzz.Library.Tests
{
    [TestFixture]
    public class FizzBuzzerTests
    {
        [Test]
        public void Test_Div3_ReturnsFizz(
            [Values(3, 6, 9, 12, 18)] int input)
        {
            string output = FizzBuzzer.GetValue(input);
            Assert.AreEqual("Fizz", output);
        }

        [Test]
        public void Test_Div5_ReturnsBuzz(
            [Values(5, 10, 20)] int input)
        {
            string output = FizzBuzzer.GetValue(input);
            Assert.AreEqual("Buzz", output);
        }

        [Test]
        public void Test_WhenDiv3And5_ReturnsFizzBuzz(
            [Values(15)] int input)
        {
            string output = FizzBuzzer.GetValue(input);
            Assert.AreEqual("FizzBuzz", output);
        }
    }
}
