

namespace choreList.Controllers;


[ApiController]
[Route("api/chores")]
public class ChoresController : ControllerBase
{
  private readonly ChoresService = _ChoresService;

public ChoresController(ChoresService choresService)
  {
    _choresService = choresService;
  }
}