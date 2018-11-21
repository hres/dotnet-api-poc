using System.Collections.Generic;
using LnhpdApi.Models.Request;

namespace LnhpdApi.Models
{
  interface IGenericProvider<T>
  {
    IEnumerable<T> findAll(RequestInfo requestInfo);
    T findOne(RequestInfo requestInfo);
  }
}