using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RocketClickerGame
{
    internal class SpecialEffects
    {
        // Auto-implemented properties 

        public string Name { get; set; }
        public int Price { get; set; }
        public Image MeteorImage { get; set; } 
        public PictureBox MeteorBox { get; set; }
        public Timer FallTimer { get; set; }
        public int FallingSpeed { get; set; }

    }
}
