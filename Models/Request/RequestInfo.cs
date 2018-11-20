using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;

namespace LnhpdApi.Models.Request
{
  public class RequestInfo
  {

    public RequestInfo() { }

    private int? _limit;
    public int? limit
    {
      get => _limit;
      set
      {
        if (value != null)
        {
          if (value > Config.MAX_PAGE_LIMIT || value < 1)
          {
            if (Config.THROW_ON_INVALID_LIMIT) throw new Exception();
            else _limit = Config.DEFAULT_PAGE_LIMIT;
          }
          else _limit = value;
        }
        else _limit = Config.DEFAULT_PAGE_LIMIT;
      }
    }

    public Nullable<int> page { get; set; }

    public string sort { get; set; }


    public string[] languages { get; set; }

    public string type { get; set; }

    public string path
    {
      get => context.Request.Path;
    }

    public string basePath
    {
      get => context.Request.PathBase;
    }
    public HttpContext context { get; set; }
  }
}