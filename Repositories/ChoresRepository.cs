namespace choreList.Repositories;

public class ChoresRepository
{
  private List<Chore> dbChores;

  public ChoresRepository()
  {
    this.dbChores = new List<Chore> { };
    dbChores.Add(new Chore("Take out the trash", false, 1));
    dbChores.Add(new Chore("vacuum", false, 2));
    dbChores.Add(new Chore("Feed the dog", false, 3));
  }

  
}