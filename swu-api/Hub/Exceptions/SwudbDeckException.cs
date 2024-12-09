namespace SwuApi.Server.Exceptions
{
    public class SwudbDeckException : Exception
    {
        public SwudbDeckException(string message) : base(message) { }

        public static SwudbDeckException ThrowNoDeckFound()
        {
            throw new SwudbDeckException("Deck list could not be found in SWDB response.");
        }
    }
}
