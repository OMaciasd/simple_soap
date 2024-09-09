using System.Web.Services;

[WebService(Namespace = "http://tempuri.org/")]
public class SimpleService : WebService
{
    [WebMethod]
    public string HelloWorld()
    {
        return "Hello, world!";
    }
}
