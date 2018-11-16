using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Swashbuckle.AspNetCore.Swagger;
using LnhpdApi.Models.Todo;
using LnhpdApi.Models.LNHPD;

namespace LnhpdApi
{
  public class Startup
  {
    public void ConfigureServices(IServiceCollection services)
    {
      services.AddDbContext<TodoContext>(opt => opt.UseInMemoryDatabase("TodoList"));

      services
      .AddMvc()
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
      application.UseMvc();
    }
  }
}