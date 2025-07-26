using Microsoft.AspNetCore.Mvc;

[ApiController]
public class BaseController : ControllerBase
{
    protected IActionResult ResponseResult<T>(ApiResponse<T> response)
    {
        return StatusCode(response.Code, response);
    }
}
