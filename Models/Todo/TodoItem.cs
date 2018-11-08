using System;
using System.Collections;

namespace LnhpdApi.Models.Todo
{
  public class TodoItem
  {
    public long Id { get; set; }
    public string Name { get; set; } = "Alex";
    public bool IsComplete { get; set; }
  }
}