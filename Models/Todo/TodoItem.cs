using System;
using System.Collections;

namespace TodoApi.Models.Todo
{
  public class TodoItem
  {
    public long Id { get; set; }
    public Hashtable Name { get; set; } = new Hashtable();
    public bool IsComplete { get; set; }

    public TodoItem()
    {
      try
      {
        Name.Add("en", "Alexander");
        Name.Add("fr", "Alexandre");
      }
      catch (Exception e)
      {
        Console.WriteLine(e.Message);
      }
    }
  }
}