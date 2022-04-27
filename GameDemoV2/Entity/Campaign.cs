using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemoV2
{
    internal class Campaign : IEntity
    {
        public int CampaingId { get; set; }
        public string CampaignName { get; set; }

    }
}
