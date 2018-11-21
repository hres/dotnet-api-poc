using System.Collections.Generic;
using LnhpdApi.Models.Request;
using Microsoft.EntityFrameworkCore;

namespace LnhpdApi.Models
{
  public abstract class AbstractRepository<T> : IGenericProvider<T>
  {
    protected AbstractRepository() { }
    public abstract IEnumerable<T> findAll(RequestInfo requestInfo);
    public abstract T findOne(RequestInfo requestInfo);
  }
}