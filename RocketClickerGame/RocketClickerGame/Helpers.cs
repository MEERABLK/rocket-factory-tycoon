using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RocketClickerGame
{
    internal class Helpers
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int PointsPerSecond { get; set; }
        public Image Image { get; set; }

        //Track how many bought
        public int Quantity { get; set; } = 0;
    }
}
