using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Softplan.Service.Dtos
{
    public class TaxaJurosDto
    {
        [JsonPropertyName("Valor")]
        public decimal Valor { get; set; }
    }
}
