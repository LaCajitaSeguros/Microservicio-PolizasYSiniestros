using Application.Dtos.DomainDTO;
using Application.Dtos.Requets;
using Application.Exceptions;
using Application.Interfaces.Repository;
using Application.Interfaces.Service;
using AutoMapper;
using Domain.Entitys;
using Microsoft.Extensions.Logging;

namespace Application.UserCase
{
    public class SiniestroServiceImpl : ISiniestroService
    {
        private IGenericRepository _genericRepository;
        private ILogger<PolizaServiceImpl> _logger;
        private IMapper _mapper;
        private IPolizaRepository _polizaRepository;

        public SiniestroServiceImpl(IGenericRepository genericRepository,
                                    ILogger<PolizaServiceImpl> logger,
                                    IMapper mapper,
                                    IValidacionesRepository validacionesRepository,
                                    IPolizaRepository polizaRepository)
        {
            _genericRepository = genericRepository;
            _logger = logger;
            _mapper = mapper;
            _polizaRepository = polizaRepository;
        }

        public async Task<SiniestroPostRequest> RegistrarSiniestroAsync(SiniestroPostRequest siniestroPostRequest)
        {
            Poliza poliza = await _polizaRepository.BuscarPolizaPorNroPoliza(siniestroPostRequest.NroDePoliza);

            if (poliza == null)
            {
                throw new CustomBadRequest("No se encontro una poliza asociada al nro de poliza: " + siniestroPostRequest.NroDePoliza);
            }

            //Creo el siniestro y mapeo los datos del request
            Siniestro siniestro = _mapper.Map<Siniestro>(siniestroPostRequest);
            siniestro.PolizaId = poliza.PolizaId;

            //Formateo las imagenes del request a un string separado por comas y se las incorporo al objeto siniestro
            List<string> listImagenesString = new List<string>();

            foreach (ImagenDTO imagenDTO in siniestroPostRequest.Siniestro.Imagenes)
            {
                listImagenesString.Add(imagenDTO.UrlImagen);
            }

            string imagenes = string.Join(",", listImagenesString);
            siniestro.Imagenes = imagenes;

            //Creo la lista de tipo de siniestro y se las incorpor al siniestro
            List<SiniestroTipoDeSiniestro> tipoDeSiniestros = new List<SiniestroTipoDeSiniestro>();
            foreach (TipoSiniestroDTO tipoSiniestroDTO in siniestroPostRequest.Siniestro.TiposDeSiniestros)
            {
                SiniestroTipoDeSiniestro siniestroTipoDeSiniestro = new SiniestroTipoDeSiniestro();
                siniestroTipoDeSiniestro.TipoDeSiniestroId = tipoSiniestroDTO.TipoSiniestroId;

                tipoDeSiniestros.Add(siniestroTipoDeSiniestro);
            }

            siniestro.SiniestroTipoDeSiniestros = tipoDeSiniestros;

            await _genericRepository.save(siniestro);

            return null;
        }
    }
}
