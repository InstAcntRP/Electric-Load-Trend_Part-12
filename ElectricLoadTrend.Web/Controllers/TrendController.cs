using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ElectricLoadTrend.Web;

[ApiController]
[Route("[controller]")]
public class TrendController : ControllerBase
{
     [HttpGet("[action]")]
    public IActionResult GetCurrentTime()
    {
        string dt = string.Empty;
        dt = DateTime.Now.ToString("MM-dd-yyyy hh:mm:ss");
        return Ok(dt);
    }
}
