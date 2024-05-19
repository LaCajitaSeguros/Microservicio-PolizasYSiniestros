using Application.Dtos.DomainDTO;
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

        public async Task<SiniestroPostResponse> RegistrarSiniestroAsync(SiniestroPostRequest siniestroPostRequest)
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

            Siniestro siniestroGuardado =  await _genericRepository.save(siniestro);

            //Armo la respuesta
            SiniestroPostResponse response = _mapper.Map<SiniestroPostResponse>(siniestroGuardado);
            response.Siniestro = _mapper.Map<SiniestroDTO>(siniestroGuardado);

            //Mapeo los tipo de siniestros del siniestro guardado al response
           // response.Siniestro.TiposDeSiniestros = siniestroPostRequest.Siniestro.TiposDeSiniestros;

            List<TipoSiniestroDTO> listTipoDeSiniestrosDtos = new List<TipoSiniestroDTO>();
            foreach(SiniestroTipoDeSiniestro item in siniestroGuardado.SiniestroTipoDeSiniestros)
            {
                TipoSiniestroDTO tipoSiniestroDTO = new TipoSiniestroDTO();
                tipoSiniestroDTO.TipoSiniestroId = item.TipoDeSiniestroId;
                listTipoDeSiniestrosDtos.Add(tipoSiniestroDTO);
            }
            response.Siniestro.TiposDeSiniestros = listTipoDeSiniestrosDtos;


            //Mapeo las imagenes desde un string a una lista de imagenes

            List<ImagenDTO> listImagenes = new List<ImagenDTO>(); 
            List<string> listStringImagenes = siniestroGuardado.Imagenes.Split(',').ToList();
            foreach (string item in listStringImagenes)
            {
                ImagenDTO imagenDTO = new ImagenDTO();
                imagenDTO.UrlImagen = item;
                listImagenes.Add(imagenDTO);
            }

            response.Siniestro.Imagenes = listImagenes;
            response.Siniestro.Imagenes = siniestroPostRequest.Siniestro.Imagenes;

            return response;
        }
    }
}
