using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Abstract
{
    internal interface IOfferService
    {
        public void AddNewOffer(Offer offer);
        public void DeleteOffer(Offer offer);
        public void UpdateOffer(Offer offer);
    }
}
