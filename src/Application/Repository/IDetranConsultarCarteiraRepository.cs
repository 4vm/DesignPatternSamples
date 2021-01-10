using DesignPatternSamples.Application.DTO;
using System.Threading.Tasks;

namespace DesignPatternSamples.Application.Repository
{
    public interface IDetranConsultarCarteiraRepository
    {
        Task<Carteira> ConsultarCarteira(string numero);
    }
}