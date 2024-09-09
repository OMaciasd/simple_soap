<%@ WebService Language="C#" Class="MyService" %>
<%@ WebServiceBinding Attribute="Use" Namespace="http://tempuri.org/" %>
<%@ WebMethod %>

public class MyService : System.Web.Services.WebService
{
    [WebMethod]
    public string HelloWorld()
    {
        return "Hello, world!";
    }
}
