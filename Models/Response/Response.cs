namespace TodoApi.Models
{
  public class Response<T>
  {
    private Metadata metadata { get; set; }
    private T data { get; set; }
  }
}