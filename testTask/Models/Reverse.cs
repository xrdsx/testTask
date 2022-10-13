namespace testTask.Models
{
    public class Reverse
    {

        public static string ShowReverseString(string stringToReverse)
        {
            if ((stringToReverse == null) || (stringToReverse.Length <= 1))
                return stringToReverse;
            return ShowReverseString(stringToReverse.Substring(1)) + stringToReverse[0];
        }
    }
}
