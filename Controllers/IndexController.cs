using System.Net;
using Microsoft.AspNetCore.Mvc;

namespace DemoMicroService.Controllers;

[ApiController]
[Route("/")]
public class HomeController : ControllerBase
{
    [HttpGet(Name = "IndexController")]
    public HttpResponseMessage Index()
    {
        string result = "Hello world! Time is: " + DateTime.Now;
        var resp = new HttpResponseMessage(HttpStatusCode.OK);
        resp.Content = new StringContent(result, System.Text.Encoding.UTF8, "text/plain");
        return resp;
    }   
}