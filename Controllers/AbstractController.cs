using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using LnhpdApi.Models.Todo;
using LnhpdApi.Models.Response;
using LnhpdApi.Models.LNHPD;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
using System.Configuration;
using Microsoft.Extensions.Configuration;
using LnhpdApi.Models;

namespace LnhpdApi.Controller
{
  public abstract class AbstractController<T> : ControllerBase
  {
    protected DbConnection connection = new DbConnection();

  }
}