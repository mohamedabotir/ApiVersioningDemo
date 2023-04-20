using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace ApiVersioningDemo.Controller;

[ApiVersion("1.0", Deprecated = true)]
public class DeviecsController : ApiBase
{
    [HttpGet]
    [Route(nameof(GetFirstDevice))]

    public IActionResult GetFirstDevice()
    {
        return Ok("Laptop mac book air");
    }
}