using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using LnhpdApi.Models.Todo;
using LnhpdApi.Models.Response;
using LnhpdApi.Models.LNHPD;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
using System.Configuration;
using Microsoft.Extensions.Configuration;
using LnhpdApi.Models.Request;

namespace LnhpdApi.Controller
{
  [Produces("application/json", "application/xml")]
  [Route("api/medicinal-ingredient")]
  [Route("api/ingredient-medicinale")]
  [ApiController]
  public class MedicinalIngredientController : ControllerBase
  {
    // can't use DI as EF requires a DbContext reference, which limits our ability to transform data and there is no OracleProvider
    private readonly MedicinalIngredientContext _context = new MedicinalIngredientContext();

    [HttpGet("{id}")]
    public ActionResult<Response<MedicinalIngredient>> GetMedicinalIngredientById(int id, string lang)
    {
      Response<MedicinalIngredient> response = _context.GetMedicinalIngredientById(id, lang);
      if (response == null) return NotFound();
      return response;
    }

    [HttpGet]
    public ActionResult<Response<List<MedicinalIngredient>>> GetAllMedicinalIngredient(int pageSize, int page, string lang)
    {
      return _context.GetAllMedicinalIngredient(new RequestInfo { pageSize = pageSize, page = page, context = HttpContext });
    }
  }
}