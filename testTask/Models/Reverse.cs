namespace testTask.Models
{
    public class Reverse
    {

        public static string ShowReverseString(string str)
        {
            if ((str == null) || (str.Length <= 1))
                return str;
            return ShowReverseString(str.Substring(1)) + str[0];
        }
    }
}
