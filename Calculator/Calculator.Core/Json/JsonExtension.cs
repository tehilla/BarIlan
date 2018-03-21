﻿using System.Linq;

namespace Calculator.Core
{
    public static class JsonExtension
    {
        public static string GetLastNumeric(this JsonState state)
        {
            return GetLastNumeric(state.CalculatorState);
        }

        public static string GetLastNumeric(this string state)
        {
            return state.Split('-', '+', '*', '/', '=').LastOrDefault();
        }


    }

}
