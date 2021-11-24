using System.Linq;

namespace MarsRovers
{
    class Rover
    {
        private readonly int[] CurrentPosition = new int[2];
        private readonly char Heading;
        private readonly string Instructions;
        private readonly CardinalList CardinalList = new();

        public Rover(string currPos, string instructions)
        {
            CurrentPosition[0] = currPos[0] - '0';
            CurrentPosition[1] = currPos[1] - '0';
            Heading = (char)currPos[2];
            Instructions = instructions;
        }

        public string calculateNewPosition()
        {

            var newPosition = CurrentPosition;
            var newHeading = CardinalList.First(x => x.Symbol == Heading);

            foreach (char letter in Instructions.ToCharArray())
            {
                switch (letter)
                {
                    case 'L':
                        newHeading = CardinalList.First(x => x.Symbol == newHeading.Left);
                        break;
                    case 'R':
                        newHeading = CardinalList.First(x => x.Symbol == newHeading.Right);
                        break;
                    case 'M':
                        newPosition[newHeading.index] = newPosition[newHeading.index] + newHeading.Value;
                        if (newPosition[newHeading.index] < 0) newPosition[newHeading.index] = 0;
                        break;
                    default:
                        break;
                }
            }


            return newPosition[0].ToString() + newPosition[1].ToString() + newHeading.Symbol;
        }
    }
}
