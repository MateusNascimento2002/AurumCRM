using System.Net;

namespace AurumCRM.Exception.BaseException;

public class NotFoundException(string message) : AurumCRMException(message)
{
    public override IList<string> GetErrorMessages() => [Message];
    public override HttpStatusCode GetStatusCode() => HttpStatusCode.NotFound;
}