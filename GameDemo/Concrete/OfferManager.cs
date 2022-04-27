using GameDemo.Abstract;
using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Concrete
{
    internal class OfferManager : IOfferService
    {
        public void DeleteOffer(Offer offer)
        {
            Console.WriteLine(offer.OfferName + " is deleted");
        }

        public void AddNewOffer(Offer offer)
        {
            Console.WriteLine(offer.OfferName + " is created");
        }

        public void UpdateOffer(Offer offer)
        {
            Console.WriteLine(offer.OfferName + " is updated");
        }
    }
}
