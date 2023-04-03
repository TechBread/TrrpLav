using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Front_end
{
    [Serializable]
    internal class GameData
    {
        public int moveCount { get; set; }
        public int lifeLeft { get; set; }
        public GameData(int moveCount, int lifeLeft)
        {
            this.moveCount = moveCount;
            this.lifeLeft = lifeLeft;
        }   
    }
}
