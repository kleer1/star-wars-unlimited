namespace SwuApi.Server.Exceptions
{
    public class SwdbDeckException : Exception
    {
        public SwdbDeckException(string message) : base(message) { }

        public static SwdbDeckException ThrowNoDeckFound()
        {
            throw new SwdbDeckException("Deck list could not be found in SWDB response.");
        }
    }
}
