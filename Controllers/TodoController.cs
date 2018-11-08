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

namespace LnhpdApi.Controller
{
  [Produces("application/json", "application/xml")]
  [Route("api/[controller]")]
  [ApiController]
  public class TodoController : ControllerBase
  {
    private readonly TodoContext _context;

    public TodoController(TodoContext context)
    {
      _context = context;

      if (_context.TodoItems.Count() == 0)
      {
        _context.TodoItems.Add(new TodoItem());
        _context.SaveChanges();
      }
    }

    [HttpGet]
    public ActionResult<Response<List<TodoItem>>> GetAll()
    {
      var response = new Response<List<TodoItem>> { data = _context.TodoItems.ToList() };
      return response;
    }
  }
}