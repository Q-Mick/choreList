namespace choreList.Services;

public class ChoresService
{

  private readonly ChoresRepository _repo;

  public ChoresService(ChoresRepository repo)
  {
    _repo = repo;
  }
}