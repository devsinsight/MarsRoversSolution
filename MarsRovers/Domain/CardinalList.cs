using System.Collections.Generic;

namespace MarsRovers
{
    class CardinalList : List<Cardinal>
    {

        public CardinalList()
        {
            this.Add(new Cardinal('N', 'W', 'E', 1));
            this.Add(new Cardinal('E', 'N', 'S', 1));
            this.Add(new Cardinal('S', 'E', 'W', -1));
            this.Add(new Cardinal('W', 'S', 'N', -1));
        }
    }

}
