namespace PrettyCode.Variables
{
    public class ObscureContext
    {
        private string verb;
        private string pluralModifier;
        private string number;

        public string make(char candidate, int count)
        {
            createPluralDependentMessageParts(count);

            string guessMessage = string.Format("There {0}, {1}, {2} {3}",
                                        verb, number, candidate, pluralModifier);
            return guessMessage;
        }

        public void createPluralDependentMessageParts(int count)
        {   
            if (count == 0)
            {
                thereAreNoLetters();
            }
            else if (count == 1)
            {
                thereIsOneLetter();
            }
            else
            {
                thereAreManyLetters(count);
            }
        }

        public void thereAreManyLetters(int count)
        {
            number = count.ToString();
            verb = "are";
            pluralModifier = "s";
        }
        public void thereIsOneLetter()
        {
            number = "1";
            verb = "is";
            pluralModifier = "";
        }
        public void thereAreNoLetters()
        {
            number = "no";
            verb = "are";
            pluralModifier = "s";
        }
    }
}
