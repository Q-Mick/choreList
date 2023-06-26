using System.ComponentModel.DataAnnotations;

namespace choreList.Models;

public class Chore
{
  public Chore(string name, bool? finished, int id)
  {
    Name = name;
    Finished = finished;
    Id = id;

  }
public int Id{ get; set; }
[Required]
public string Name{ get; set; }
public bool? Finished{ get; set;}
}
