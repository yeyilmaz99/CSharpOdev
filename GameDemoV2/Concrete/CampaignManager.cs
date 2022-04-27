using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemoV2.Concrete
{
    internal class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " Campaign Added");
        }

        public void Remove(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " Campaign Removed");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " Campaign Updated");
        }
    }
}
