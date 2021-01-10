using DesignPatternSamples.Application.DTO;
using DesignPatternSamples.Application.Repository;
using DesignPatternSamples.Application.Services;
using System.Threading.Tasks;

namespace DesignPatternSamples.Application.Implementations
{
    public class DetranConsultarCarteiraServices : IDetranConsultarCarteiraService
    {
        private readonly IDetranConsultarCarteiraFactory _Factory;

        public DetranConsultarCarteiraServices(IDetranConsultarCarteiraFactory factory)
        {
            _Factory = factory;
        }

        public Task<Carteira> ConsultarCarteira(string numero)
        {
            IDetranConsultarCarteiraRepository repository = _Factory.Create("PE");
            return repository.ConsultarCarteira(numero);
        }

    }
}
