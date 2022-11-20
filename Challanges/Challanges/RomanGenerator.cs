using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challanges
{
    internal class RomanGenerator
    {

        private readonly Dictionary<string, int> _romanMapper = new()
        {
            {"M",1000},
            {"CM",900},
            {"D",500},
            {"CD",400},
            {"C",100},
            {"XC",90},
            {"L",50},
            {"XL",40},
            {"X",10},
            {"IX",9},
            {"V",5},
            {"IV", 4},
            {"I",1}

        };

        internal string IntToRoman(int number)
        {
            var romanNumber = new StringBuilder();

            foreach (var item in _romanMapper)
            {
                while (number >= item.Value)
                {
                    romanNumber.Append(item.Key);
                    number -= item.Value;
                }
            }

            return romanNumber.ToString();
        }

        internal int RomanToInt(string roman)
        {
            var number = 0;
            for (var i = roman.Length - 1; i >= 0; i--)
            {
                if (i > 0 && _romanMapper[roman[i].ToString()] > _romanMapper[roman[i - 1].ToString()])
                {
                    number += _romanMapper[$"{roman[i - 1]}{roman[i]}"];
                    i--;
                    continue;
                }

                number += _romanMapper[roman[i].ToString()];
            }

            return number;
        }
    }
}
