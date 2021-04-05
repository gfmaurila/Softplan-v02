using Softplan.Service.Dtos;

namespace Softplan.Service.Interfaces
{
    public interface ISoftplanService
    {
        CalculaJurosDto CalculaJuros(decimal valorinicial, int tempo);
    }
}
