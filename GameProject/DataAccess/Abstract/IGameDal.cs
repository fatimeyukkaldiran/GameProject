using GameProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.DataAccess.Abstract
{
   public interface IGameDal
    {
        void Add(Game game);
        void Delete(Game game);
        void Update(Game game);
        List<Game> GetAll();
        List<Game> GetAllByCampaignId(int campaignId);
                 
    }
}
