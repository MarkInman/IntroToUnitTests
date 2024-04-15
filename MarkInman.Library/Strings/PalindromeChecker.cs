namespace MarkInman.Library.Strings;

public partial class EmailValidator
{
    public class PalindromeChecker
    {
        public bool IsPalindrome(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                return false;
            }

            var length = text.Length - 1;
            for (int i = 0; i < length; i++)
            {
                if (text[i] != text[length - i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
