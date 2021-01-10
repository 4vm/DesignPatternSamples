using DesignPatternSamples.Application.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSamples.Infra.Repository.Detran
{
    public class DetranConsultarCarteiraFactory : IDetranConsultarCarteiraFactory
    {
        private readonly IServiceProvider _ServiceProvider;
        private readonly IDictionary<string, Type> _Repositories = new Dictionary<string, Type>();

        public DetranConsultarCarteiraFactory(IServiceProvider serviceProvider)
        {
            _ServiceProvider = serviceProvider;
        }

        public IDetranConsultarCarteiraRepository Create(string UF)
        {
            IDetranConsultarCarteiraRepository result = null;

            if (_Repositories.TryGetValue(UF, out Type type))
            {
                result = _ServiceProvider.GetService(type) as IDetranConsultarCarteiraRepository;
            }

            return result;
        }

        public IDetranConsultarCarteiraFactory Register(string UF, Type repository)
        {
            if (!_Repositories.TryAdd(UF, repository))
            {
                _Repositories[UF] = repository;
            }

            return this;
        }
    }
}
