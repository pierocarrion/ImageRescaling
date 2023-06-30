namespace ImageRescaling.Common.Exceptions;

public class ConsoleException : Exception
{
    public override string Message
    {
        get
        {
            return $"[ConsoleException]: {base.Message}";
        }
    }
}
