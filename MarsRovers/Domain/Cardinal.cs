namespace MarsRovers
{
    class Cardinal
    {

        public Cardinal(char symbol, char left, char right, int value)
        {
            Symbol = symbol;
            Left = left;
            Right = right;
            Value = value;
        }

        public char Symbol { get; set; }
        public char Left { get; set; }
        public char Right { get; set; }
        public int Value { get; set; }

        public int index => Symbol == 'N' || Symbol == 'S' ? 1 : 0;

    }
}
