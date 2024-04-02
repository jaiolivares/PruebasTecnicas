using Microsoft.AspNetCore.Mvc;
using WebApi.Servicios;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConversionController : ControllerBase
    {
        // GET api/<ConversionController>/5
        [HttpGet("{cantidadUf}")]
        public int Get(int cantidadUf)
        {
            var moneda = "UF";

            var metConversion = new ConversionServices();

            var valorConvertido = metConversion.Conversion(cantidadUf, moneda);

            return valorConvertido;
        }

        //// GET: api/<ConversionController>
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// POST api/<ConversionController>
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT api/<ConversionController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<ConversionController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}