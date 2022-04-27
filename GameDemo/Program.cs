using GameDemo.Concrete;
using GameDemo.Entities;
using System;

namespace GameDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game game1 = new Game() {GameId =1,Name="Game1",Price=500 };
            Offer offer1 = new Offer() {OfferId=1,OfferName="Special Offer",Discount =150};
            Customer customer = new Customer() { FirstName = "Yunus Emre",LastName="Yılmaz",Id=1,DateOfBirth= new DateTime(1999,2,17), TCKimlikNo ="11111111111" };

            OfferManager offerManager = new OfferManager();
            CustomerManager customerManager = new CustomerManager(new CustomerCheckManager());
            GameManager gameManager = new GameManager();



            gameManager.SellWithOffer(customer, game1, offer1);
            gameManager.Sell(customer, game1);

            customerManager.AddNewCustomer(customer);
            customerManager.UpdateCustomer(customer);
            customerManager.RemoveCustomer(customer);

            offerManager.AddNewOffer(offer1);
            offerManager.UpdateOffer(offer1);
            offerManager.DeleteOffer(offer1);
        }
    }
}
