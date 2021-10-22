using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Day5_GameProject.Entity;

namespace Day5_GameProject.Abstract
{
    internal interface IOrderService
    {
        public void Order(Gamer gamer, Game game, Campaign campaign);
    }
}
