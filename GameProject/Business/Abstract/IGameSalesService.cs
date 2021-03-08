using GameProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Business.Abstract
{
   public interface IGameSalesService
    {
        void SellGame(Game game, Gamer gamer);
        void CampaingSell(Game game, Gamer gamer, Campaign campaign);
    }
}
