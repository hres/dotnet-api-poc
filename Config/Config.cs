using System.Net.Mime;
using Microsoft.AspNetCore.Mvc.Formatters;

namespace LnhpdApi
{
  public abstract class Config
  {
    public static string DEFAULT_MEDIA_TYPE = MediaTypeNames.Application.Json;
    public static int DEFAULT_PAGE_SIZE = 1;
    public static string[] SUPPORTED_LANGUAGES = { "en", "fr" };


  }
}