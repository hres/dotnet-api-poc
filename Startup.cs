﻿using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Swashbuckle.AspNetCore.Swagger;
using LnhpdApi.Models.Todo;
using Newtonsoft.Json;
using LnhpdApi.Filters;
using LhnpdApi.Exceptions;

namespace LnhpdApi
{
  public class Startup
  {
    public void ConfigureServices(IServiceCollection services)
    {
      services.AddDbContext<TodoContext>(opt => opt.UseInMemoryDatabase("TodoList"));

      services
      .AddMvc(options =>
      {
        options.Filters.Add(typeof(PaginationFilter));
      })
      .AddJsonOptions(options =>
      {
        options.SerializerSettings.NullValueHandling = NullValueHandling.Ignore;
      })
      .AddXmlSerializerFormatters()
      .SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

      services.AddSwaggerGen(c =>
      {
        c.SwaggerDoc("v1", new Info { Title = "My API", Version = "v1" });
      });
    }

    public void Configure(IApplicationBuilder application)
    {
      application.UseStaticFiles();
      application.UseSwagger();
      application.UseSwaggerUI(c =>
      {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
        c.RoutePrefix = string.Empty;
      });
      application.UseMiddleware(typeof(ExceptionMiddleware));
      application.UseMvc();
    }
  }
}