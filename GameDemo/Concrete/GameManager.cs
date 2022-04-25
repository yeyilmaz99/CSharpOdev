using GameDemo.Abstract;
using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Concrete
{
    internal class GameManager: BaseGameManager
    {
        public void SellWithOffer(Customer customer, Game game, Offer offer)
        {
            Console.WriteLine(customer.FirstName + " has bought the " + game.Name + " with " + offer.Discount + " discount");
        }
    }
}
