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
        private const int MaxGameNumber = 100;

        private readonly FizzBuzzTranslator _fizzBuzzTranslator;
        private readonly string[] _fizzBuzzCount;


        public FizzBuzzGame(FizzBuzzTranslator fizzBuzzTranslator)
        {
            _fizzBuzzTranslator = fizzBuzzTranslator;
            
            _fizzBuzzCount = new string[MaxGameNumber];

            //initialize correct FIZZBUZZCOUNT
            for (int i = 1; i < MaxGameNumber; i++)
            {
                _fizzBuzzCount[i] = Convert(i);
            }
        }

        public bool ProvideNextValue(string givenValue)
        {
            if (CorrectFizzBuzzValue(givenValue)) {
                _currentNumberPointer++;
                return true;
            } else {
                return false;
            }
        }

        private bool CorrectFizzBuzzValue(string givenValue)
        {
            return givenValue == _fizzBuzzCount[_currentNumberPointer];
        }


        private string Convert(int givenInteger)
        {
            return _fizzBuzzTranslator.DetermineReturnString(givenInteger);
        }










    }
}
