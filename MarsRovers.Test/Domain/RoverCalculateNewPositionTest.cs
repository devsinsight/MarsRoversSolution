using NUnit.Framework;

namespace MarsRovers.Test.Domain
{

    [TestFixture]
    class RoverCalculateNewPositionTest
    {
        private Rover _rover;

        [SetUp]
        public void SetUp()
        {
            _rover = new Rover();
        }

        [Test]
        public void CalculateNewPosition()
        {

            _rover.SetCurrPos("12N");
            _rover.SetInstructions("LMLMLMLMM");

            var result = _rover.CalculateNewPosition();

            Assert.AreEqual(result, "13N");
        }

        [Test]
        public void CalculateNewPositionWrong()
        {

            _rover.SetCurrPos("12N");
            _rover.SetInstructions("LMLMLMLMM");

            var result = _rover.CalculateNewPosition();

            Assert.AreNotEqual(result, "77N");
        }

        [Test]
        public void BackToOriginIsAllwaysZero()
        {
            _rover.SetCurrPos("10N");
            _rover.SetInstructions("RRMMMRMR");

            var result = _rover.CalculateNewPosition();

            Assert.AreEqual(result, "00N");
        }
    }
}
