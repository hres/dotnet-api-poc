using System;
using System.Collections;

namespace TodoApi.Models.Todo
{
  public class TodoItem
  {
    public long Id { get; set; }
    public string Name { get; set; } = "Alex";
    public bool IsComplete { get; set; }
  }
}