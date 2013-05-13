﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acmp_0004_Game_Csharp
{
    /**
     * Implementation of a class Game
     */
    public class Game
    {
        /**
         * Returns a game number
         * 
         * @param The input number
         * @return The game numbers
         */
        public int game(int number)
        {
            int result = 0;

            int firstDigit = number;
            int secondDigit = 9;
            int thirdDigit = secondDigit - firstDigit;

            result = firstDigit * 100 + secondDigit * 10 + thirdDigit;

            return result;
        }
    }
}
