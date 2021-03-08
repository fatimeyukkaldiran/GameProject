using GameProject.Business.Abstract;
using GameProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Business.Concrete
{
    public class GameSalesManager : IGameSalesService
    {
        public void CampaingSell(Game game, Gamer gamer, Campaign campaign)
        {
            double TotalAmount = game.Price - (game.Price * campaign.DiscountRate)/100;
            Console.WriteLine(gamer.Name + " " + gamer.LastName + " " +
                game.Name + " oyununu yüzde" +""  + campaign.DiscountRate +
                "indirim ile" + " "+ TotalAmount +" " +" TL'ye sattı.");
        }

        public void SellGame(Game game, Gamer gamer)
        {
            Console.WriteLine(gamer.Name + " " + gamer.LastName +" " + game.Name + " oyununu sattı" );
        }
    }
}
