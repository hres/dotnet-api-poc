using System;

namespace LnhpdApi.Models.Response
{
  public class Pagination
  {
    public int limit { get; set; }
    public Nullable<int> offset { get; set; }
    public Nullable<int> page { get; set; }
    public int count { get; set; }
    public string next { get; set; }
    public string previous { get; set; }
  }
}