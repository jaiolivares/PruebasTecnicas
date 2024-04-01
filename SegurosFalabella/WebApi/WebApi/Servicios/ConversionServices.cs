namespace WebApi.Servicios
{
    public class ConversionServices
    {
        public int Conversion(float cantidad, string tipoMoneda)
        {
            var listMonedas = ApiExternaServices.ConsultarApiExterna();

            var monedaConversion = listMonedas.FirstOrDefault(x => x.Codigo == tipoMoneda);

            var valorConvertido = Convert.ToInt32(Math.Round(cantidad * monedaConversion.Valor));

            return valorConvertido;
        }
    }
}