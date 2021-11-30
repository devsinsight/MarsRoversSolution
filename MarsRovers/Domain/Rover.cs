using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace MarsRovers
{
    public class Rover
    {

        private int[] CurrentPosition = new int[2];
        private char Heading;
        private string Instructions;
        private readonly CardinalList CardinalList = new();

        public Rover() {}

        public void SetCurrPos(string currPos)
        {
            if (IsCurrentPositionValid(currPos)) {
                CurrentPosition[0] = currPos[0] - '0';
                CurrentPosition[1] = currPos[1] - '0';
                Heading = (char)currPos[2];
            }
        }

        public void SetInstructions(string instructions) {
            if (IsInstructionsValid(instructions))
            {
                Instructions = instructions;
            }
        }

        public string CalculateNewPosition()
        {
            if (string.IsNullOrEmpty(Instructions) || Heading == '\0') {

                return "**There is an error in the current position or instructions, please read the General Instructions above.**";
            }

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

        public bool IsCurrentPositionValid(string currPos) {
            return Regex.Match(currPos, "^[(0-9)][(0-9)][NSEW]$").Success;
        }

        public bool IsInstructionsValid(string instructions)
        {
            return Regex.Match(instructions, "^[RLM]+$").Success;
        }
    }
}
