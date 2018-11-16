namespace LnhpdApi.Models.Response
{
  public class Pagination
  {
    public int limit { get; set; }
    public int offset { get; set; }
    public int page { get; set; }
    public int count { get; set; }
    public string next { get; set; }
    public string previous { get; set; }
  }
}