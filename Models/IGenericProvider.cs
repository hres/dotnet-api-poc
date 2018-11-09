using System.Collections.Generic;

namespace LnhpdApi.Models
{
  interface IGenericProvider<T>
  {
    IEnumerable<T> GetAll(int limit, int offset, int page, string lang);
    T GetOne(int id, string lang);
  }
}