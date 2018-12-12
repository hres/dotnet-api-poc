using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace LnhpdApi.Filters
{
  public class PaginationFilter : IResourceFilter
  {
    public void OnResourceExecuting(ResourceExecutingContext context)
    {
      context.Result = new ContentResult()
      {
        Content = "Filtered"
      };
    }
    public void OnResourceExecuted(ResourceExecutedContext context)
    {
      throw new System.NotImplementedException();
    }
  }
}