using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Softplan.Service.Dtos;
using Softplan.Service.Interfaces;
using System;
using System.Configuration;
using System.Net.Http;
using System.Net.Http.Headers;

namespace Softplan.Service.Services
{
    public class SoftplanService : ISoftplanService
    {
        private readonly HttpClient client = new HttpClient();
        private string apiV1;

        public SoftplanService()
        {
            apiV1 = ConfigurationManager.AppSettings["ApiV1"];
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }


        public CalculaJurosDto CalculaJuros(decimal valorinicial, int tempo)
        {
            CalculaJurosDto dto1 = new CalculaJurosDto();
            decimal juros = CalculaTaxaJuros(valorinicial);
            dto1.ValorFinal = valorinicial + juros;
            return dto1;
        }

        private TaxaJurosDto TaxaJuros()
        {
            var response = (JObject.Parse(client.GetStringAsync(apiV1).Result)).ToObject<TaxaJurosDto>();
            return response;
        }

        private decimal CalculaTaxaJuros(decimal ValorInicial)
        {
            var jurosApi = JsonConvert.DeserializeObject<TaxaJurosDto>(TaxaJuros().Valor.ToString());
            decimal juros = (int)Convert.ToDecimal(jurosApi);

            decimal taxa = ValorInicial * Convert.ToDecimal(jurosApi) / 100;
            return taxa;
        }
    }
}
