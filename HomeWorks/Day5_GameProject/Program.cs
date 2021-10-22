using System;
using Day5_GameProject.Concrete;
using Day5_GameProject.Entity;

namespace Day5_GameProject
{
    class Program
    {
        static void Main()
        {
            var game1 = new Game
            {
                Id = 1,
                GameName = " GTA5",
                GameCategory = " Sanal Gerçeklik",
                GamePrice = 175,

            };
            var game2 = new Game
            {
                Id = 2,
                GameName = " Metin2 ",
                GameCategory = " PVP Online Savaş ",
                GamePrice = 65,

            };

            var campaign1 = new Campaign
            {
                Id = 1,
                CampaignName = " Hoşgeldin İndirimi ",
                CampaignDiscount = 18,


            };
            var campaign2 = new Campaign
            {
                Id = 2,
                CampaignName = " Yaz Ortası İndirimi ",
                CampaignDiscount = 12,


            };


            var gamer = new Gamer { GamerBirthDay = new DateTime(2000, 2, 26), GamerFirstName = "Emre", GamerLastName = "Bayrak", GamerIdentityId = 123123123123 };

            var gameManager = new GameManager();
            gameManager.Add(game1);
            gameManager.Add(game2);

            Console.WriteLine("----------------------------------------");

            var gamer1Manager = new GamerManager();
            gamer1Manager.Add(gamer);
            //gamer1Manager.Add(gamer2);
            //gamer1Manager.Update(gamer1);
            //Console.WriteLine("----------------------------------------");

            var campaignManager = new CampaignManager();
            campaignManager.Add(campaign1);
            campaignManager.Add(campaign2);
            campaignManager.Update(campaign1);

            var orderManager = new OrderManager();
            orderManager.Order(gamer, game1, campaign2);
            Console.WriteLine("----------------------------------------");
            orderManager.Order(gamer, game2, campaign1);

            Console.ReadLine();
        }
    }
}
