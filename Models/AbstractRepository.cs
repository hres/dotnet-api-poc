using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace LnhpdApi.Models
{
  public abstract class AbstractRepository<T> : IGenericProvider<T>
  {
    protected AbstractRepository() { }
    public abstract IEnumerable<T> GetAll(int limit, int offset, int page, string lang);
    public abstract T GetOne(int id, string lang);
  }
}