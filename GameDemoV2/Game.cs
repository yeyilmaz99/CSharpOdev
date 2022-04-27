using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemoV2
{
    internal class Game:IEntity
    {
        public int GameID { get; set; }
        public string GameName { get; set; }
        public int UnitPrice { get; set; }
    }
}
