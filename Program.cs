using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuzzleSimple
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cardsList = new string[] {
                "4111111111111111",
                "4111111111111",
                "4012888888881881",
                "378282246310005",
                "6011111111111117",
                "5105105105105100",
                "5105 1051 0510 5106",
                "9111111111111111"
            };

            foreach(string cardNumber in cardsList)
            {
                var cardNumberFormatted = cardNumber.Replace(" ", "");
                var cardType = CheckingCreditCards.VerifyCardType(cardNumberFormatted);
                var cardValid = CheckingCreditCards.VerifyCardLength(cardNumberFormatted, cardType) && CheckingCreditCards.VerifyCard(cardNumberFormatted);
                
                Console.WriteLine(cardType + ": " + cardNumberFormatted + (cardValid ? " (valid)" : " (invalid)"));

            }

            Console.ReadKey();
        }
    }
}
