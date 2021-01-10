using DesignPatternSamples.Application.DTO;
using DesignPatternSamples.Application.Repository;
using System.Threading.Tasks;

namespace DesignPatternSamples.Infra.Repository.Detran
{
    public abstract class DetranConsultarCarteiraRepositoryCrawlerBase : IDetranConsultarCarteiraRepository
    {
        public async Task<Carteira> ConsultarCarteira(string numero)
        {
            var html = await RealizarAcesso(numero);
            return await PadronizarResultado(html);
        }

        protected abstract Task<string> RealizarAcesso(string numero);
        protected abstract Task<Carteira> PadronizarResultado(string html);
    }
}
