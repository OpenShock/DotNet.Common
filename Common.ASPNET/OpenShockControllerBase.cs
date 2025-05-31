using System.Net.Mime;
using Microsoft.AspNetCore.Mvc;
using OpenShock.Common.Models;
using OpenShock.Common.Problems;

namespace OpenShock.Common;

[Consumes(MediaTypeNames.Application.Json)]
public class OpenShockControllerBase : ControllerBase
{
    [NonAction]
    public ObjectResult Problem(OpenShockProblem problem) => problem.ToObjectResult(HttpContext);
    
    [NonAction]
    [Obsolete("Use OpenShockControllerBase.Problem instead")]
    public OkObjectResult LegacyDataOk<T>(T data)
    {
        return Ok(new LegacyDataResponse<T>(data));
    }

    [NonAction]
    [Obsolete("Use OpenShockControllerBase.Problem instead")]
    public CreatedResult LegacyDataCreated<T>(string? uri, T data)
    {
        return Created(uri, new LegacyDataResponse<T>(data));
    }

    [NonAction]
    [Obsolete("Use OpenShockControllerBase.Problem instead")]
    public OkObjectResult LegacyEmptyOk(string message = "")
    {
        return Ok(new LegacyEmptyResponse(message));
    }
}