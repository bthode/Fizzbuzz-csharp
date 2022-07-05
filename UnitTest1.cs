using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FizzBuzz_csharp
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("Fizz", FizzBuzzer.FizzBuzz(3));
            Assert.AreEqual("Fizz", FizzBuzzer.FizzBuzz(6));
            Assert.AreEqual("Fizz", FizzBuzzer.FizzBuzz(9));
            Assert.AreEqual("Fizz", FizzBuzzer.FizzBuzz(18));

            Assert.AreEqual("Buzz", FizzBuzzer.FizzBuzz(5));
            Assert.AreEqual("Buzz", FizzBuzzer.FizzBuzz(10));
            Assert.AreEqual("Buzz", FizzBuzzer.FizzBuzz(50));

            Assert.AreEqual("FizzBuzz", FizzBuzzer.FizzBuzz(15));
            Assert.AreEqual("FizzBuzz", FizzBuzzer.FizzBuzz(30));
            Assert.AreEqual("FizzBuzz", FizzBuzzer.FizzBuzz(75));


            Assert.AreEqual("2", FizzBuzzer.FizzBuzz(2));
            Assert.AreEqual("4", FizzBuzzer.FizzBuzz(4));
            Assert.AreEqual("88", FizzBuzzer.FizzBuzz(88));
        }




    }
}
