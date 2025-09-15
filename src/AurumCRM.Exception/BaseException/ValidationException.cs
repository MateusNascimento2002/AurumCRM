using System.Net;

namespace AurumCRM.Exception.BaseException;

public class ValidationException(IList<string> errorMessages) : AurumCRMException(string.Empty)
{
    public override IList<string> GetErrorMessages() => errorMessages;
    public override HttpStatusCode GetStatusCode() => HttpStatusCode.BadRequest;
}
