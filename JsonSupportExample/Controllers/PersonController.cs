using Devart.Data.PostgreSql.Entity;
using JsonSupportExample.Data;
using JsonSupportExample.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Text.Json;

namespace JsonSupportExample.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonController : Controller
    {
        AppDbContext _context;

        public PersonController(AppDbContext context)
        {
            _context = context;
        }
        [HttpPost]
        public string AddPerson()
        {
            /*var person = new Model.Person()
            {
                Name = "Sujan Bhujel",
                Address = @"{""Street"": ""123 Main St"", ""City"": ""Kathmandu"", ""ZipCode"": ""10001""}"
            };
            _context.Persons.Add(person);
            _context.SaveChanges();*/

            return "Added";
        }
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            try
            {
                /*var query = _context.Persons.Where(t => PgSqlJsonbFunctions.GetObjectFieldAsText(t.Address, "City") == "New York")
                           .Select(t => new PersonDto
                            {
                                Id = t.Id,
                                Json = t.Address,
                                ObjectType = PgSqlJsonbFunctions.TypeOf(t.Address),
                                FieldType = PgSqlJsonbFunctions.TypeOf(PgSqlJsonbFunctions.ExtractPath(t.Address, "City")),
                                ExtractPath = PgSqlJsonbFunctions.ExtractPath(t.Address, "City"),
                                ExtractPathText = PgSqlJsonbFunctions.ExtractPathText(t.Address, "City"),
                                GetObjectField = PgSqlJsonbFunctions.GetObjectField(t.Address, "City"),
                                GetObjectFieldAsText = PgSqlJsonbFunctions.GetObjectFieldAsText(t.Address, "City")
                                });*/
                var person = _context.Persons.ToList();
                var data = person.Select(x=>new
                {
                    Id = x.Id,
                    Address = JsonConvert.DeserializeObject<Address>(x.Address)
                }).ToList();
                return Ok(data);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
