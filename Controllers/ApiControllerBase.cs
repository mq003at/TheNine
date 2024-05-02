namespace store.Controllers;

using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;

/**
HTTP request and response will follow JSON format 
**/

[ApiController]
[Produces(MediaTypeNames.Application.Json)]
[Consumes(MediaTypeNames.Application.Json)]

[Route("[controller]s")]

public abstract class ApiControllerBase : ControllerBase
{

}