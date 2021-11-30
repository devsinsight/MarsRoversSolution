using NUnit.Framework;


namespace MarsRovers.Test.Domain
{
    [TestFixture]
    class RoverCurrentPositionTest
    {
        private Rover _rover;

        [SetUp]
        public void SetUp()
        {
            _rover = new Rover();
        }

        [Test]
        public void CurrentPositionValid()
        {
            var result = _rover.IsCurrentPositionValid("11N");

            Assert.IsTrue(result, "11N should be a valid position");
        }

        [Test]
        public void CurrentPositionIsEmpty()
        {
            var result = _rover.IsCurrentPositionValid("");

            Assert.IsFalse(result, "Empty should return false");
        }

        [Test]
        public void WrongCurrentPosition()
        {
            var result = _rover.IsCurrentPositionValid("LOREM");

            Assert.IsFalse(result, "Invalid position should return false");
        }

        [Test]
        public void WrongCurrentPositionWithValidCharacters()
        {
            var result = _rover.IsCurrentPositionValid("11N11W");

            Assert.IsFalse(result, "Invalid position should return false");
        }
    }
}
