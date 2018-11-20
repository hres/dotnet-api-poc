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

    private int? _page;
    public Nullable<int> page
    {
      get => _page;
      set => _page = value ?? 1;
    }

    public HttpContext context { get; set; }

    public string[] languages { get; set; }
  }
}