using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class FizzBuzzGame
    {

        private int _currentNumberPointer;
        private const int MaxGameNumber = 100;

        private readonly FizzBuzzTranslator _fizzBuzzTranslator;
        private readonly string[] _FizzBuzzCount;


        public FizzBuzzGame(FizzBuzzTranslator fizzBuzzTranslator)
        {
            _fizzBuzzTranslator = fizzBuzzTranslator;
            
            _FizzBuzzCount = new string[MaxGameNumber];
            for (int i = 0; i < MaxGameNumber; i++)
            {
                _FizzBuzzCount[i] = Convert(i);
            }
        }

        public bool GiveNextNumber(int givenInteger)
        {
            if (_FizzBuzzCount[_currentNumberPointer] == Convert(givenInteger)) {
                _currentNumberPointer++;
                return true;
            } else {
                return false;
            }
                
        }


        private string Convert(int givenInteger)
        {
            return _fizzBuzzTranslator.DetermineReturnString(givenInteger);
        }










    }
}
