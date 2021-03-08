using GameProject.Adapter;
using GameProject.Business.Concrete;
using GameProject.Entities.Concrete;
using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new MernisServiceAdapter());
            gamerManager.Add(new Gamer
            {
                Id = 1,
                IdentityNumber = 27497507845,
                Name = "FATİME",
                LastName = "YÜKKALDIRAN",
                BirthYear = 1994,

            });

            GameManager gameManager = new GameManager();
            gameManager.Add(new Game
            {
                Id = 1,
                Name = "Candy Crash",
                Price = 465.54
            });
            
            GameCampaingManager campaingManager = new GameCampaingManager();
            campaingManager.Add(new Campaign
            {
                Id = 1,
                Name = "2021 Summer Campaing",
                DiscountRate = 30
            });

            GameSalesManager salesManager = new GameSalesManager();
            salesManager.SellGame(new Game
            {
                Id = 1,
                Name = "PUBG",
                Price = 500
            },
              new Gamer
              {
                  Id = 2,
                  IdentityNumber = 154789,
                  Name = "Ece",
                  LastName = "Deniz",
                  BirthYear = 2000
              }
              );

            salesManager.CampaingSell(
                       new Game
                       {
                           Id = 2,
                           Name = "FIFA 2020",
                           Price = 2000
                       },

                new Gamer
                {
                    Id = 1,
                    IdentityNumber = 456789,
                    Name = "Serhat",
                    LastName = "Kaya",
                    BirthYear = 1993
                },
         
                new Campaign
                {
                    Id = 5,
                    Name = "Special for Winter",
                    DiscountRate = 40
                }

            );
        }
    }
}
