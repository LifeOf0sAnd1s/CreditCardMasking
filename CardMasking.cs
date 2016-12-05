using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

　
namespace CardMaskingCode
{
    class Program
    {
        static void Main(string[] args)
        {
            var cardNumber = "1111222233334444";

            if(cardNumber.Length >= 12)
            {
               //Define First set of digits in the card number
               //Then define last digits
               //Define the mask character and the range of characters to mask (should be chars 7-12).
               //Then concat the First digits, masked digits and last digits. 
               //Define optional
               var FirstDigits = cardNumber.Substring(0, 7);
               var LastDigits = cardNumber.Substring(cardNumber.Length - 3,3);
               var requiredMask = new String('*', cardNumber.Length - FirstDigits.Length - LastDigits.Length);
               var maskedString = string.Concat(FirstDigits, requiredMask, LastDigits);
               var maskedCardNumberWithSpaced = Regex.Replace(maskedString, ".{4}", "$0");

                Console.WriteLine(maskedCardNumberWithSpaced);
                //Console.WriteLine(
                //  string.Concat(
                //    "".PadLeft(7,16, '*'),
                //  cardNumber.Substring(cardNumber.Length - 6)
                //)
                //);
               
            }
            
          else {
                Console.WriteLine(cardNumber);
            }
            Console.ReadLine();
        }

        }
    }
