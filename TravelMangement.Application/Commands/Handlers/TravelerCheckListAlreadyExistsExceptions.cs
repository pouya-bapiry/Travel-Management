
namespace TravelManagement.Application.Commands.Handlers
{
    [Serializable]
    internal class TravelerCheckListAlreadyExistsExceptions : Exception
    {
        public TravelerCheckListAlreadyExistsExceptions()
        {
        }

        public TravelerCheckListAlreadyExistsExceptions(string? message) : base(message)
        {
        }

        public TravelerCheckListAlreadyExistsExceptions(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}