using System.Collections.Generic;
using Microsoft.AspNetCore.Http;

namespace LnhpdApi.Models.Request
{
  public class RequestInfo
  {
    public int limit { get; set; } = 10;
    public int offset { get; set; }
    public int page { get; set; }

    public HttpContext context { get; set; }

    public string[] languages { get; set; } = { "en", "fr" };
  }
}