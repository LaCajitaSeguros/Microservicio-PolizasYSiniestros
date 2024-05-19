using Application.Dtos.Requets;
using Application.Dtos.Response;
using Application.Exceptions;
using Application.Interfaces.Repository;
using Application.Interfaces.Service;
using AutoMapper;
using Domain.Entitys;
using Microsoft.Extensions.Logging;

namespace Application.UserCase
{
    public class PolizaServiceImpl : IPolizaService
    {
        private IGenericRepository _genericRepository;
        private IValidacionesRepository _validacionesRepository;
        private IPolizaRepository _polizaRepository;
        private ILogger<PolizaServiceImpl> _logger;
        private IMapper _mapper;

        public PolizaServiceImpl(IGenericRepository genericRepository,
                                 ILogger<PolizaServiceImpl> logger,
                                 IMapper mapper,
                                 IValidacionesRepository validacionesRepository,
                                 IPolizaRepository polizaRepository)
        {
            _genericRepository = genericRepository;
            _validacionesRepository = validacionesRepository;
            _logger = logger;
            _mapper = mapper;
            _polizaRepository = polizaRepository;
        }

        public async Task<PolizaGetResponse> BuscarPolizasConSiniestrosPorUsuarioId(string usuarioId)
        {
            await _polizaRepository.BuscarPolizasConSiniestrosPorUsuarioId(usuarioId);
            return null;
        }

        public async Task<PolizaPostResponse> GuardarPolizaAsync(PolizaPostRequest polizaPostRequest)
        {
            _logger.LogInformation("Inicio - GuardarPolizaAsync");
            Random random = new Random();

            _logger.LogInformation("Valido que el usuario no tenga una poliza asociado a el bien, No se permite tener dos polizas para un mismo bien");
            if (await _validacionesRepository.TieneBienAseguradoAsync(polizaPostRequest.UsuarioId,
                                                                     polizaPostRequest.BienAsegurado.Patente))
            {
                throw new CustomBadRequest("El cliente ya poseé una poliza asociado al bien con patente: " + polizaPostRequest.BienAsegurado.Patente);
            }

            _logger.LogInformation("Armo la Poliza y persistir en Base");
            Poliza poliza = _mapper.Map<Poliza>(polizaPostRequest);
            poliza.NroDePoliza = random.Next(0, 999999999);
            poliza.FechaInicio = DateTime.Now;
            //Se esta tomando como fecha de vencimiento 6 meses en adelante
            poliza.FechaVencimiento = poliza.FechaInicio.AddMonths(6);

            Poliza polizaGuardada = await _genericRepository.save(poliza);

            PolizaPostResponse response = _mapper.Map<PolizaPostResponse>(polizaGuardada);

            _logger.LogInformation("Fin - GuardarPolizaAsync");
            return response;
        }
    }
}
