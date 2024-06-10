namespace Web_Hotel.Filters
{
    public class ValidationException : Exception
    {
        public ValidationException(string message) : base(message) { }
    }
}
