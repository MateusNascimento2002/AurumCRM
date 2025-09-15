using System.Net;

namespace AurumCRM.Exception.BaseException;

public abstract class AurumCRMException(string message) : SystemException(message)
{
    public abstract IList<string> GetErrorMessages();
    public abstract HttpStatusCode GetStatusCode();
}
