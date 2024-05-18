using Application.Dtos.Requets;
using Application.Dtos.Response;
using Application.Interfaces.Repository;
using Application.Interfaces.Service;
using AutoMapper;
using Microsoft.Extensions.Logging;

namespace Application.UserCase
{
    public class SiniestroServiceImpl : ISiniestroService
    {

        private IGenericRepository _genericRepository;
        private IValidacionesRepository _validacionesRepository;
        private ILogger<PolizaServiceImpl> _logger;
        private IMapper _mapper;

        public SiniestroServiceImpl(IGenericRepository genericRepository,
                                    ILogger<PolizaServiceImpl> logger,
                                    IMapper mapper,
                                    IValidacionesRepository validacionesRepository)
        {
            _genericRepository = genericRepository;
            _validacionesRepository = validacionesRepository;
            _logger = logger;
            _mapper = mapper;
        }


        public Task<SiniestroPostRequest> RegistrarSiniestroAsync(SiniestroPostRequest siniestroPostRequest)
        {
            throw new NotImplementedException();
        }
    }
}
