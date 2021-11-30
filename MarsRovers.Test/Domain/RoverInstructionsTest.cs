using NUnit.Framework;


namespace MarsRovers.Test.Domain
{
    [TestFixture]
    class RoverInstructionsTest
    {

        private Rover _rover;

        [SetUp]
        public void SetUp()
        {
            _rover = new Rover();
        }

        [Test]
        public void InstructionsAreValid()
        {
            var result = _rover.IsInstructionsValid("RMMMLM");

            Assert.IsTrue(result, "RMMMLM should be a valid instruction");
        }

        [Test]
        public void EmptyInstructions()
        {
            var result = _rover.IsInstructionsValid("");

            Assert.IsFalse(result, "Empty instructions should return false");
        }

        [Test]
        public void RandomInstructions()
        {
            var result = _rover.IsInstructionsValid("XYZ");

            Assert.IsFalse(result, "Invalid instructions should return false");
        }

    }
}
