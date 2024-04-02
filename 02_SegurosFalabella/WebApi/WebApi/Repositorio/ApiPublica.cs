using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Runtime.InteropServices.JavaScript;

namespace WebApi.Repositorio
{
    public class ApiPublica
    {
        private const string urlApi = "https://api.gael.cloud/general/public/monedas";

        public static List<Models.Monedas> ConsultarApiExterna()
        {
            using (var client = new HttpClient())
            {
                var listMoneada = new List<Models.Monedas>();

                client.DefaultRequestHeaders.Clear();

                var responseResult = client.GetAsync(urlApi).Result;

                var res = responseResult.Content.ReadAsStringAsync().Result;

                List<Models.Monedas> objectDynamic = JsonConvert.DeserializeObject<List<Models.Monedas>>(res); // JObject.Parse(res);

                //foreach (var item in objectDynamic)
                //{
                //    var moneda = new Models.Monedas()
                //    {
                //        Codigo = item["Codigo"],
                //        Nombre = item["Nombre"],
                //        Valor = Convert.ToDecimal(item["Valor"]),
                //    };

                //    listMoneada.Add(moneda);
                //}

                return objectDynamic;
            }
        }
    }
}