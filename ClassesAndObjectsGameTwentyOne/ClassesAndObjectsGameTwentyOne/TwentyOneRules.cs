using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjectsGameTwentyOne
{
    public class TwentyOneRules
    {
        private static Dictionary<Face, int> _cardValues = new Dictionary<Face, int>()
        {
            [Face.Two] = 2,
            [Face.Three] = 3,
            [Face.Four] = 4,
            [Face.Five] = 5,
            [Face.Six] = 6,
            [Face.Seven] = 7,
            [Face.Eight] = 8,
            [Face.Nine] = 9,
            [Face.Ten] = 10,
            [Face.Jack] = 10,
            [Face.Queen] = 10,
            [Face.King] = 10,
            [Face.Ace] = 1
        };

        private static int[] getAllPossibleHandValues (List<Card> Hand)
        {
            int aceCount = Hand.Count(x => x.Face == Face.Ace); // is the cards face equivalent to an ace (lambda).
            int[] result = new int[aceCount + 1];
            int value = Hand.Sum(x => _cardValues[x.Face]); // This takes each item, looks it up in card values dictionary table and then sums it.
            result[0] = value;
            if (result.Length == 1)
            {
                return result;
            }
            for (int i = 1; i < result.Length; i++)
            {
                value = value + (i * 10); // or also can use value += (i *10);
                result[i] = value;
            }
            return result;
        }

        public static bool CheckForBlackJack(List<Card> Hand)
        {
            int[] possibleValues = getAllPossibleHandValues(Hand);
            int value = possibleValues.Max(); // Getting MAX possible value.
            if (value == 21) return true; // IF max value is equaled to 21 return true.
            else return false;
        }

        public static bool isBusted(List<Card> Hand)
        {
            int value = getAllPossibleHandValues(Hand).Min();
            if (value > 21) return true;
            else return false;
        }  

        //This method checks - Does the dealer have any possible hand values between 16 and 22, if he does return true (that the dealer should stay).
        public static bool shouldDealerStay(List<Card> Hand)
        {
            int[] possibleHandValues = getAllPossibleHandValues(Hand);
            foreach (int value in possibleHandValues)
            {
                if (value > 16 && value < 22)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool? CompareHands(List<Card> PlayerHand, List<Card> DealerHand)
        {
            int[] playerResults = getAllPossibleHandValues(PlayerHand);
            int[] dealerResults = getAllPossibleHandValues(DealerHand);

            // This says - Give me a list of playerResults where the int is less than 22, and also get the largest value.
            int playerScore = playerResults.Where(x => x < 22).Max();
            int dealerScore = dealerResults.Where(x => x < 22).Max();

            // Notice this is a bool method with THREE options (true, false, null).
            if (playerScore > dealerScore) return true;
            else if (playerScore < dealerScore) return false;
            else return null;
        }
    }
}
