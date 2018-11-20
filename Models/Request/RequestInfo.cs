using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;

namespace LnhpdApi.Models.Request
{
  public class RequestInfo
  {
    public Nullable<int> pageSize { get; set; }
    public Nullable<int> page { get; set; }

    public HttpContext context { get; set; }

    public string[] languages { get; set; }
  }
}