using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace RocketClickerGame
{
    internal class PointConversion
    {
        private string currentLanguage;

        // Methods to display numbers differently
        public String ToScientificNotation(float num)
        {
            int exponent = 0;
            while (num >= 10)
            {
                num /= 10;
                exponent++;
            }
            if (exponent == 0) {
                
                return String.Format("{0:0}", num);
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
                return String.Format("{0:0}", num);
            }
            return String.Format("{0:0.00}", num) + "e" + exponent;
        }

        public String ToSpokenNotation(float num)
        {
            currentLanguage = ConfigurationManager.AppSettings["language"];

            int denomination = 0;
            while (num >= 1000)
            {
                num /= 1000;
                denomination += 1;
            }

            if (denomination == 0)
            {
                return String.Format("{0:0}", num);
            }

            switch (denomination)
            {
                case 1:
                    switch (currentLanguage)
                    {
                        case "en": 
                            return String.Format("{0:0.00}", num) + " Thousand";
                        case "fr-CA": 
                            return String.Format("{0:0.00}", num) + " Mille";
                        case "es":
                            return String.Format("{0:0.00}", num) + " Mil";
                    }
                    break;
                case 2:
                    switch (currentLanguage)
                    {
                        case "en":
                            return String.Format("{0:0.00}", num) + " Million";
                        case "fr-CA": 
                            return String.Format("{0:0.00}", num) + " Million";
                        case "es":
                            return String.Format("{0:0.00}", num) + " Millón";
                    }
                    break;
                case 3:
                    switch (currentLanguage)
                    {
                        case "en": 
                            return String.Format("{0:0.00}", num) + " Billion";
                        case "fr-CA":
                            return String.Format("{0:0.00}", num) + " Milliard";
                        case "es": 
                            return String.Format("{0:0.00}", num) + " Mil millones";
                    }
                    break;
                case 4:
                    switch (currentLanguage)
                    {
                        case "en":
                            return String.Format("{0:0.00}", num) + " Trillion";
                        case "fr-CA":
                            return String.Format("{0:0.00}", num) + " Billion";
                        case "es":
                            return String.Format("{0:0.00}", num) + " Billón";
                    }
                    break;
                case 5:
                    switch (currentLanguage)
                    {
                        case "en": 
                            return String.Format("{0:0.00}", num) + " Quadrillion";
                        case "fr-CA":
                            return String.Format("{0:0.00}", num) + " Billiard";
                        case "es": 
                            return String.Format("{0:0.00}", num) + " Mil billones";
                    }
                    break;
                case 6:
                    switch (currentLanguage)
                    {
                        case "en": 
                            return String.Format("{0:0.00}", num) + " Quintillion";
                        case "fr-CA":
                            return String.Format("{0:0.00}", num) + " Trillion";
                        case "es":
                            return String.Format("{0:0.00}", num) + " Trillón";
                    }
                    break;
                case 7:
                    switch (currentLanguage)
                    {
                        case "en":
                            return String.Format("{0:0.00}", num) + " Sextillion";
                        case "fr-CA":
                            return String.Format("{0:0.00}", num) + " Trilliard";
                        case "es": 
                            return String.Format("{0:0.00}", num) + " Mil trillones";
                    }
                    break;
                case 8:
                    switch (currentLanguage)
                    {
                        case "en": 
                            return String.Format("{0:0.00}", num) + " Septillion";
                        case "fr-CA":
                            return String.Format("{0:0.00}", num) + " Quadrillion";
                        case "es":
                            return String.Format("{0:0.00}", num) + " Cuatrillón";
                    }

                    break;
                case 9:
                    switch (currentLanguage)
                    {
                        case "en":
                            return String.Format("{0:0.00}", num) + " Octillion";
                        case "fr-CA": 
                            return String.Format("{0:0.00}", num) + " Quadrilliard";
                        case "es": 
                            return String.Format("{0:0.00}", num) + " Mil cuatrillones";
                    }
                    break;
                case 10:
                    switch (currentLanguage)
                    {
                        case "en": 
                            return String.Format("{0:0.00}", num) + " Nonillion";
                        case "fr-CA":
                            return String.Format("{0:0.00}", num) + " Quintillion";
                        case "es":
                            return String.Format("{0:0.00}", num) + " Quintillion";
                    }
                    break;
                case 11:
                    switch (currentLanguage)
                    {
                        case "en":
                            return String.Format("{0:0.00}", num) + " Decillion";
                        case "fr-CA":
                            return String.Format("{0:0.00}", num) + " Quintilliard";
                        case "es": 
                            return String.Format("{0:0.00}", num) + " Mil quintillones";
                    }
                    break;
                case 12:
                    switch (currentLanguage)
                    {
                        case "en": 
                            return String.Format("{0:0.00}", num) + " Undecillion";
                        case "fr-CA": 
                            return String.Format("{0:0.00}", num) + " Sextillion";
                        case "es": 
                            return String.Format("{0:0.00}", num) + " Sextillón";
                    }
                    break;
                case 13:
                    switch (currentLanguage)
                    {
                        case "en":
                            return String.Format("{0:0.00}", num) + " Duodecillion";
                        case "fr-CA":
                            return String.Format("{0:0.00}", num) + " Sextilliard";
                        case "es":
                            return String.Format("{0:0.00}", num) + " Mil sextillones";
                    }
                    break;
            }

            // Fallback if something unexpected happens
            return String.Format("{0:0.00}", num);
        }

    }
}
