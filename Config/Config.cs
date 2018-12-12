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
    public static int DEFAULT_PAGE_LIMIT = 100;
    public static int MAX_PAGE_LIMIT = 500;
    public static bool THROW_ON_INVALID_LIMIT = false;
    public static bool THROW_ON_PAGE_OUT_OF_BOUNDS = false;

    // Languages
    public static string[] DEFAULT_LANGUAGES = { "en", "fr" };
    public static bool THROW_ON_ONLY_INVALID_LANGUAGES = false;

  }
}