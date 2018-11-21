using Microsoft.AspNetCore.Mvc;
using LnhpdApi.Models;

namespace LnhpdApi.Controller
{
  public abstract class AbstractController<T> : ControllerBase
  {
    protected DbConnection connection = new DbConnection();

  }
}