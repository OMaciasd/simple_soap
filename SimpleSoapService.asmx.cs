using System.Web.Services;

[WebService(Namespace = "http://tempuri.org/")]
public class SimpleSoapService : WebService
{
    [WebMethod]
    public string HelloWorld()
    {
        return "Hello, World!";
    }
}
