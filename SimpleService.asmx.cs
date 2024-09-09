$csContent = @"
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
"@
$csPath = "C:\inetpub\wwwroot\SimpleSoapService\SimpleSoapService.asmx.cs"
Set - Content - Path $csPath - Value $csContent
