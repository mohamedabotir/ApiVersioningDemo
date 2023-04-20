using Microsoft.AspNetCore.Mvc;

namespace ApiVersioningDemo.Controller;
[ApiController]
[Route("api/[Controller]")]
public abstract class ApiBase :ControllerBase
{
    
}