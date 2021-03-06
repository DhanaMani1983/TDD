﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
namespace FizzBuzzer.Library.Test
{
    [TestFixture]
    public class FizzzBuzzTest
    {
        //[Test]
        //public void SampleTest()
        //{
        //    Assert.Pass();
        //}

        //[Test]
        //public void Buzzer_When1_Returns1()
        //{
        //    //Arrange
        //    int input = 1;

        //    //Act
        //    string output = FizzBuzzer.GetValue(input);

        //    //Assert
        //    Assert.AreEqual("1", output);
        //}

        //[Test]
        //public void Buzzer_When2_Returns2()
        //{
        //    int input = 2;
        //    string output = FizzBuzzer.GetValue(input);
        //    Assert.AreEqual("2", output);
        //}

        //[Test]
        //public void Buzzer_When2_Returns2(
        //  [Values(2)]  int input
        //    )
        //{
        //    //int input = 2;
        //    string output = FizzBuzzer.GetValue(input);
        //    Assert.AreEqual("2", output);
        //}

        [Test]
        public void Buzzer_WhenDefault_ReturnsInput(
         [Values(1,2,4,7,8,11,13,14,16,17,19)]  int input
           )
        {
            //int input = 2;
            string output = FizzBuzz.Library.FizzBuzzer.GetValue(input);
            Assert.AreEqual(input.ToString(), output);
        }

        //[Test]
        //public void Buzzer_When3_ReturnsFizz()
        //{
        //    int input = 3;
        //    string output = FizzBuzzer.GetValue(input);
        //    Assert.AreEqual("Fizz", output);
        //}

        [Test]
        public void Buzzer_WhenDiv3_ReturnsFizz(
            [Values(3,6,9,12,18)] int input
            )
        {
            //int input = 3;
            string output = FizzBuzz.Library.FizzBuzzer.GetValue(input);
            Assert.AreEqual("Fizz", output);
        }

        //[Test]
        //public void Buzzer_When5_ReturnsBuzz()
        //{
        //    int input = 5;
        //    string output = FizzBuzzer.GetValue(input);
        //    Assert.AreEqual("Buzz", output);
        //}

        [Test]
        public void Buzzer_WhenDiv5_ReturnsBuzz(
            [Values(5,10,20)] int input
            )
        {
            //int input = 5;
            string output = FizzBuzz.Library.FizzBuzzer.GetValue(input);
            Assert.AreEqual("Buzz", output);
        }

        [Test]
        public void Buzzer_WhenDiv3andDiv5_ReturnsFizzBuzzer(
            [Values(15)] int input
            )
        {
            //int input = 5;
            string output = FizzBuzz.Library.FizzBuzzer.GetValue(input);
            Assert.AreEqual("FizzBuzz", output);
        }
    }
}
