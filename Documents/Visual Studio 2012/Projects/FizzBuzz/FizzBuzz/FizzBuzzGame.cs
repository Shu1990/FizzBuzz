using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class FizzBuzzGame
    {
        private int _currentNumberPointer = 1;
        public const int MaxGameNumber = 100;
        private string[] _fizzBuzzCount;

        private readonly FizzBuzzTranslator _fizzBuzzTranslator;

        //constructor
        public FizzBuzzGame(FizzBuzzTranslator fizzBuzzTranslator)
        {
            _fizzBuzzTranslator = fizzBuzzTranslator;

            InitializeFizzBuzzCount();
        }

        //checks if given value is correct
        public bool CheckNextValue(string givenValue)
        {
            if (!AtEndOfGame() && CorrectFizzBuzzValue(givenValue))
            {
                _currentNumberPointer++;
                return true;
            }
            return false;
        }


        public bool AtEndOfGame()
        {
            return _currentNumberPointer == MaxGameNumber;
        }


        //implemented for readability
        private bool CorrectFizzBuzzValue(string givenValue)
        {
            return givenValue.ToUpper() == _fizzBuzzCount[_currentNumberPointer];
        }
        
        private string ConvertToFizzBuzzCount(int givenInteger)
        {
            return _fizzBuzzTranslator.DetermineReturnString(givenInteger);
        }
        
        private void InitializeFizzBuzzCount()
        {
            _fizzBuzzCount = new string[MaxGameNumber];
            for (int normalNumber = 1; normalNumber < MaxGameNumber; normalNumber++)
            {
                _fizzBuzzCount[normalNumber] = ConvertToFizzBuzzCount(normalNumber);
            }
        }
    }
}
