using DesignPatternSamples.Application.DTO;
using System.Threading.Tasks;

namespace DesignPatternSamples.Application.Services
{
    public interface IDetranConsultarCarteiraService
    {
        Task<Carteira> ConsultarCarteira(string numero);
    }
}
