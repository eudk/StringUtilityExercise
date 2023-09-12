namespace StringUtilityExercise
{
    public class StringUtility
    {
        public int CountOccurences(string strToCheck, string stringToFind)
        {
            strToCheck = strToCheck.ToLower(); // Insensitive str
            var stringAsCharArray = strToCheck.ToCharArray();
            var stringToCheckForAsChar = stringToFind.ToCharArray()[0];
            var occuranceCount = 0;

            // Character loop
            for (var characterIndex = 0; characterIndex <= stringAsCharArray.GetUpperBound(0); characterIndex++)
            {
                if (stringAsCharArray[characterIndex] == stringToCheckForAsChar)
                {
                    occuranceCount++;
                }
            }

            return occuranceCount;
        }


    }
}