using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_GameProject.Entity
{
    class Game
    {
        public int Id { get; set; }
        public string GameName { get; set; }

        public string GameCategory { get; set; }
        public double GamePrice { get; set; }
    }
}
