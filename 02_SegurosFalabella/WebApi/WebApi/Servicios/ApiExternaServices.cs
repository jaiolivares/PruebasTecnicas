using WebApi.Repositorio;

namespace WebApi.Servicios
{
    public class ApiExternaServices
    {
        public static List<Models.Monedas> ConsultarApiExterna()
        {
            return ApiPublica.ConsultarApiExterna();
        }
    }
}