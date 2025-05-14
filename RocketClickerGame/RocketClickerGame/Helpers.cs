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

        // Methods to display numbers differently
        public String ToScientificNotation(float num)
        {
            int exponent = 1;
            while (num >= 10)
            {
                num /= 10;
                exponent++;
            }
            return String.Format("{0:0.00}", num) + "e" + exponent;
        }

        public String ToEngineeringNotation(float num)
        {
            int exponent = 0;
            while (num >= 1000)
            {
                num /= 1000;
                exponent += 3;
            }
            if (exponent == 0)
            {
                return String.Format("{0:0.00}", num);
            }
            return String.Format("{0:0.00}", num) + "e" + exponent;
        }

        public String ToStandardNotation(float num)
        {
            int denomination = 0;
            while (num >= 1000)
            {
                num /= 1000;
                denomination += 1;
            }
            if (denomination == 0)
            {
                return String.Format("{0:0.00}", num);
            }
            switch (denomination)
            {
                case 1:
                    return String.Format("{0:0.00}", num) + " Thousand";
                case 2:
                    return String.Format("{0:0.00}", num) + " Million";
                case 3:
                    return String.Format("{0:0.00}", num) + " Billion";
                case 4:
                    return String.Format("{0:0.00}", num) + " Trillion";
                case 5:
                    return String.Format("{0:0.00}", num) + " Quadrillion";
                case 6:
                    return String.Format("{0:0.00}", num) + " Quintillion";
                case 7:
                    return String.Format("{0:0.00}", num) + " Sextillion";
                case 8:
                    return String.Format("{0:0.00}", num) + " Septillion";
                case 9:
                    return String.Format("{0:0.00}", num) + " Octillion";
                case 10:
                    return String.Format("{0:0.00}", num) + " Nonillion";
                case 11:
                    return String.Format("{0:0.00}", num) + " Decillion";
                case 12:
                    return String.Format("{0:0.00}", num) + " Undecillion";
                case 13:
                    return String.Format("{0:0.00}", num) + " Duodecillion";
                default: return String.Empty;
            }
        }
    }
}
