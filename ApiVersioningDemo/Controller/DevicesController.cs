using ApiVersioningDemo.Controller;
using Microsoft.AspNetCore.Mvc;

namespace ApiVersioningDemo.ControllerV2;
 
[ApiVersion("2.0")]
public class DeviecsController :ApiBase
{
    [HttpGet]
    [Route(nameof(GetFirstDevice))]
    
    public IActionResult GetFirstDevice()
    {
        return Ok($"Laptop mac book air price : {2000.ToString("C0")}");
    } 
}