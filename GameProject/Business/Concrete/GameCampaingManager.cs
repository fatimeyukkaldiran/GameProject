using GameProject.Business.Abstract;
using GameProject.DataAccess.Abstract;
using GameProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Business.Concrete
{
    public class GameCampaingManager : IGameCampaingService
    {
        ICampaignDal _campaignDal;

        public GameCampaingManager(ICampaignDal campaignDal)
        {
            _campaignDal = campaignDal;
        }

        public void Add(Campaign campaign)
        {
            _campaignDal.Add(campaign);
        }

        public void Delete(Campaign campaign)
        {
            _campaignDal.Delete(campaign);
        }

        public List<Campaign> GetAll()
        {
            return _campaignDal.GetAll();
        }

        public void Update(Campaign campaign)
        {
            _campaignDal.Update(campaign);
        }
    }
}
