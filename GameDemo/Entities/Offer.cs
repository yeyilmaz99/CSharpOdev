using GameDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Entities
{
    internal class Offer: IEntity
    {
        public int OfferId { get; set; }
        public double Discount { get; set; }
        public string OfferName { get; set; }
    }
}
