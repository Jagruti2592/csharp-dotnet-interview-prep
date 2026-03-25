using System.Net;

namespace SmartCommerce.Application.Exceptions;

public class NotFoundException : AppException
{
    public NotFoundException(string message)
        : base(message, (int)HttpStatusCode.NotFound)
    {
    }
}