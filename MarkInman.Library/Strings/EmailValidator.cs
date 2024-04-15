namespace MarkInman.Library.Strings;

public partial class EmailValidator
{
    public bool IsValid(string email)
    {
        if (string.IsNullOrEmpty(email))
        {
            return false;
        }

        if (HasAtSign(email))
        {
            return false;
        }

        if (!HasPeriod(email))
        {
            return false;
        }

        return true;
    }

    private static bool HasPeriod(string email)
    {
        return email.Contains('.');
    }

    private static bool HasAtSign(string email)
    {
        return email.IndexOf('@') == -1;
    }
}
