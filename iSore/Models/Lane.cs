using System.Collections.Generic;

namespace iSore.Models
{
  public class Lane
  {
    public string Name { get; set; }
    public IEnumerable<Card> Cards { get; set; }
  }
}