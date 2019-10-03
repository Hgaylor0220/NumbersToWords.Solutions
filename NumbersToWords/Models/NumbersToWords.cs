using System;
using System.Collections.Generic;

namespace Game.Models
{
    public class NTW
    {
        public Dictionary<int, string> Ones { get; set; }
        public Dictionary<int, string> Teens { get; set; }
        public Dictionary<int, string> Tens { get; set; }
        public Dictionary<int, string> Hundreds { get; set; }
        public Dictionary<int, string> Thousands { get; set; }
        public Dictionary<int, string> TenThousands { get; set; }
        public Dictionary<int, string> HundredThousands { get; set; }
        public Dictionary<int, string> Millions { get; set; }
        public string input {get; set;}
        public int [] numArray; 
        public string output;
    
        public NTW()
        {
            public static Dictionary<int, string> ones = new Dictionary<int, string>(){{1, "one"},{2, "two"},{3, "three"},{4, "four"},{5, "five"},{6, "six"},{7, "seven"},{8, "eight"},{9, "nine"}};

            public static Dictionary<int, string> teens = new Dictionary<int, string>(){{0, "ten"},{12, "twelve"},{13, "thirteen"},{14, "fourteen"},{15, "fifteen"},{16, "sixteen"},{17, "seventeen"},{18, "eighteen"},{19, "nineteen"}};
            
            public static Dictionary<int, string> tens = new Dictionary<int, string>(){{2, "twenty"},{3, "thirty"},{4, "forty"},{5, "fifty"},{6, "sixty"},{7,"seventy"},{8, "eighty"},{9, "ninety"}};

            public static Dictionary<int, string> hundreds = new Dictionary<int, string>(){{0, "one-hundred"},{2, "two-hundred"},{3, "three-hundred"},{4, "four-hundred"},{5, "five-hundred"},{6, "six-hundred"},{7, "seven-hundred"},{8, "eight-hundred"},{9, "nine-hundred"}};

            public static Dictionary<int, string> thousands = new Dictionary<int, string>(){{0, "one-thosand"},{2, "two-thosand"},{3, "three-thosand"},{4, "four-thosand"},{5, "five-thosand"},{6, "six-thosand"},{7, "seven-thosand"},{8, "eight-thosand"},{9, "nine-thosand"}};

            public static Dictionary<int, string> tenThousands = new Dictionary<int, string>(){{0, "ten-thousand"},{2, "twenty-thousand"},{3, "thirty-thousand"},{4, "fourty-thousand"},{5, "fifty-thousand"},{6, "sixty-thousand"},{7, "seventy-thousand"},{8, "eighty-thousand"},{9, "ninty-thousand"}};

            public static Dictionary<int, string> hundredThousands = new Dictionary<int, string>(){{0, "one-hundred thousand"},{2, "two-hundred thousand"},{3, "three hundred thousand"},{4, "four hundred thousand"},{5, "five hundred thousand"},{6, "six hundred thousand"},{7, "seven hundred thousand"},{8, "eight hundred thousand"},{9, "nine hundred thousand"}};

            public static Dictionary<int, string> millions = new Dictionary<int, string>(){{0, "one million"},{2, "two-million"},{3, "three-million"},{4, "four-million"},{5, "five-million"},{6, "six-million"},{7, "seven-million"},{8, "eight-million"},{9, "nine-million"}};

            public void string Converter(string input)
            {
                char[] numChars = input.ToCharArray();
                int[] nums = new int[numChars.Length];
                for(int i =0; i< input.Length; i++)
                {
                    nums[i] = numChars[numChars.Length-1-i];
                    nums[i] *= (int)Math.Pow(10, i);
                } 
            }
        }
    } 
}