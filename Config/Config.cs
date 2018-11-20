using System.Net.Mime;
using Microsoft.AspNetCore.Mvc.Formatters;

namespace LnhpdApi
{
  public abstract class Config
  {
    // MediaTypes
    public static string DEFAULT_MEDIA_TYPE = MediaTypeNames.Application.Json;
    public static bool THROW_ON_INVALID_MEDIA_TYPE = false;

    // Pagination
    public static int DEFAULT_PAGE_LIMIT = 1;
    public static int MAX_PAGE_LIMIT = 100;
    public static bool THROW_ON_INVALID_LIMIT = false;

    // Languages
    public static string[] SUPPORTED_LANGUAGES = { "en", "fr" };


  }
}