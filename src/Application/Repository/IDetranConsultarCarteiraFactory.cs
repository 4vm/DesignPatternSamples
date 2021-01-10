
using System;

namespace DesignPatternSamples.Application.Repository
{
    public interface IDetranConsultarCarteiraFactory
    {
        public IDetranConsultarCarteiraFactory Register(string UF, Type repository);
        public IDetranConsultarCarteiraRepository Create(string UF);
    }
}
