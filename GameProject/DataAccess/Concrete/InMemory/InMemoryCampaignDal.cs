using GameProject.DataAccess.Abstract;
using GameProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameProject.DataAccess.Concrete.InMemory
{
    class InMemoryCampaignDal : ICampaignDal
    {
        List<Campaign> _campaigns;
        public InMemoryCampaignDal()
        {
            _campaigns = new List<Campaign>
            {
                new Campaign{Id = 1, Name = "Black Friday", DiscountRate = 50},
                new Campaign{Id = 2, Name = "New Year", DiscountRate = 40},
                new Campaign{Id = 3, Name = "Game Days", DiscountRate = 30 }
            };
        }
        public void Add(Campaign campaign)
        {
            _campaigns.Add(campaign);
        }

        public void Delete(Campaign campaign)
        {
            Campaign deleteToCampaign = _campaigns.SingleOrDefault(c => c.Id == campaign.Id);
            _campaigns.Remove(deleteToCampaign);
        }

        public List<Campaign> GetAll()
        {
            return _campaigns;
        }

        public void Update(Campaign campaign)
        {
            Campaign updateToCampaign = _campaigns.SingleOrDefault(c => c.Id == campaign.Id);
            updateToCampaign.Id = campaign.Id;
            updateToCampaign.Name = campaign.Name;
            updateToCampaign.DiscountRate = campaign.DiscountRate;
        }
    }
}
