using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuzzleSimple
{
    public class CheckingCreditCards
    {
        public static string VerifyCardType(string cardNumber)
        {
            //AMEX
            if (cardNumber.Substring(0, 2) == "34" || cardNumber.Substring(0, 2) == "37")
                return "AMEX";
            //Discover
            else if (cardNumber.Substring(0, 4) == "6011")
                return "Discover";
            //MasterCard
            else if (Convert.ToInt32(cardNumber.Substring(0, 2)) >= 51 && Convert.ToInt32(cardNumber.Substring(0, 2)) <= 55)
                return "MasterCard";
            //Visa
            else if (cardNumber.Substring(0, 1) == "4")
                return "VISA";
            else
                return "Unknown";
        }

        public static bool VerifyCardLength(string cardNumber, string cardType)
        {
            //AMEX
            if (cardType == "AMEX")
                return cardNumber.Length == 15;
            //Discover
            else if(cardType == "Discover")
                return cardNumber.Length == 16;
            //MasterCard
            else if(cardType == "MasterCard")
                return cardNumber.Length == 16;
            //VISA
            else if(cardType == "VISA")
                return cardNumber.Length == 13 || cardNumber.Length == 16;
            else
                return false;
        }

        public static bool VerifyCard(string cardNumber)
        {
            int length = cardNumber.Length;             
            int total = 0;
            int x = length % 2;
            byte[] items = new ASCIIEncoding().GetBytes(cardNumber);

            for (int i = 0; i < length; i++)
            {
                items[i] -= 48;
                if (((i + x) % 2) == 0)
                    items[i] *= 2;

                total += (items[i] > 9) ? items[i] - 9 : items[i];
            }
            return ((total % 10) == 0);
        }
    }
}
