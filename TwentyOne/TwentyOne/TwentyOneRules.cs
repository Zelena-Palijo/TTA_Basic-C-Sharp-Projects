using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
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
            [Face.Ace] = 1 //can be worth 1 or 11 depending on player
        };

        private static int[] GetAllPossibleHandValues(List<Card> Hand)
        {
            int aceCount = Hand.Count(x => x.Face == Face.Ace);
            int[] result = new int[aceCount + 1];
            int value = Hand.Sum(x => _cardValues[x.Face]); //checks for lowest/first value, where Ace = 1
            result[0] = value; 
            if (result.Length == 1) return result;
            for (int i = 1; i < result.Length; i++) //start i=1 because 0 above is lowest value
            {
                value += (i * 10); // next value is value + 1, times 10 
                result[i] = value;
            } //assigned all possible integer values to integer array "result"
            return result;
        }

        public static bool CheckForBlackJack(List<Card> Hand)
        {
            int[] possibleValues = GetAllPossibleHandValues(Hand);
            int value = possibleValues.Max(); //getting maximum possible value
            if (value == 21) return true; // yes blackjack
            else return false;
        }

        public static bool IsBusted(List<Card> Hand)
        {
            int value = GetAllPossibleHandValues(Hand).Min();
            if (value > 21) return true;
            else return false;
        }

        public static bool ShouldDealerStay(List<Card> Hand)
        {
            int[] possibleHandValues = GetAllPossibleHandValues(Hand);
            foreach (int value in possibleHandValues)
            {
                if (value > 16 && value < 22)
                {
                    return true; //dealer should stay
                }
            }
            return false; //dealer should not stay
        }

        //return a nullable boolean
        public static bool? CompareHands(List<Card> PlayerHand, List<Card> DealerHand)
        {
            int[] playerResults = GetAllPossibleHandValues(PlayerHand);
            int[] dealerResults = GetAllPossibleHandValues(DealerHand);

            int playerScore = playerResults.Where(x => x < 22).Max();
            int dealerScore = dealerResults.Where(x => x < 22).Max();

            if (playerScore > dealerScore) return true;
            else if (playerScore > dealerScore) return false;
            else return null;

        }
    }
}
