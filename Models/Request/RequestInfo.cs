using System.Collections.Generic;

namespace LnhpdApi.Models.Request
{
  public class RequestInfo
  {
    public int limit { get; set; } = 10;
    public int offset { get; set; }
    public int page { get; set; }
    public string[] languages { get; set; } = { "en", "fr" };

  }
}