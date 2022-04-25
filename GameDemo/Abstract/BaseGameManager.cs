using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Abstract
{
    internal class BaseGameManager : IGameService
    {
        public void Sell(Customer customer, Game game)
        {
            Console.WriteLine(customer.FirstName +" has bought the " +game.Name);
        }

    }
}
