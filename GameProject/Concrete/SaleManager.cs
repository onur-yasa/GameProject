using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class SaleManager
    {
        public void Sale(Game game,Gamer gamer,Campaign campaign)
        {
            double priceWithCampaign;
            priceWithCampaign = game.Price - (game.Price * campaign.DiscountRate / 100);
            Console.WriteLine(gamer.FirstName + "'a " + game.Name + " oyunu" + " " + campaign.Name + " kampanyası ile " + game.Price + " TL yerine " + priceWithCampaign + " TL'ye satıldı");
        }
    }
}
