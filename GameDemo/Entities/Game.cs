using GameDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Entities
{
    internal class Game:IEntity
    {
        public int GameId { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
    }
}
