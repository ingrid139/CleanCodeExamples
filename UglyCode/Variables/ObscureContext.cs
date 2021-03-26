using System;
using System.Collections.Generic;
using System.Text;

namespace UglyCode.Variables
{
    public class ObscureContext
    {
        public string printGuessStatics(char candidate, int count)
        {
            string verb;
            string pluralModifier;
            string number;
            if (count == 0)
            {
                number = "no";
                verb = "are";
                pluralModifier = "s";
            }
            else if (count == 1)
            {
                number = "1";
                verb = "is";
                pluralModifier = "";
            }
            else
            {
                number = count.ToString();
                verb = "are";
                pluralModifier = "s";
            }

            string guessMessage = string.Format("There {0}, {1}, {2} {3}", 
                                        verb, number, candidate, pluralModifier);
            return guessMessage;
        }
    }
}
