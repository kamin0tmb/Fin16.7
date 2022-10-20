using NUnit.Framework;
using System;
using Fin16.Prog;



namespace Fin16.Test
{
    
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void AdditionalMustReturnCorrectValue()
        {
            var calculator = new Calculator1();

            Assert.AreEqual(6, calculator.Additional(2, 4));
        }

        [Test]
        public void SubtractionMustReturnCorrectValue()
        {
            var calculator = new Calculator1();

            Assert.That(calculator.Subtraction(7, 2) == 5);
        }

        [Test]
        public void MiltiplicationMustReturnCorrectValue()
        {
            var calculator = new Calculator1();

            Assert.AreEqual(6, calculator.Miltiplication(2, 3));
        }

        [Test]
        public void DivisionByZero()
        {
            var calculator = new Calculator1();

            Assert.Throws<DivideByZeroException>(() => calculator.Division(8, 0));
        }
        [Test]
        public void DivisionMustReturnCorrectValue()
        {
            var calculator = new Calculator1();

            Assert.AreEqual(4, calculator.Division(8, 2));
        }
    }
}