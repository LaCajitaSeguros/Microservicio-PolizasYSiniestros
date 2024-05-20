using Application.Interfaces.Repository;
using Application.Interfaces.Service;
using Application.NuevosDtos.DomainDto;
using AutoMapper;
using Domain.Entitys;

namespace Application.UserCase
{
    public class FormateoUbicacionService : IFormateoUbicacionService
    {
        public IProviciaRepository _proviciaRepository;
        public ILocalidadRepository _localidadRepository;
        public IVersionRepository _versionRepository;
        private IMapper _mapper;

        public FormateoUbicacionService(IProviciaRepository proviciaRepository,
                                        ILocalidadRepository localidadRepository,
                                        IMapper mapper,
                                        IVersionRepository versionRepository)
        {
            _proviciaRepository = proviciaRepository;
            _localidadRepository = localidadRepository;
            _versionRepository = versionRepository;
            _mapper = mapper;
        }

        public async Task<BienAseguradoDto> MapearUbicacionBienAsegurado(BienAsegurado bienAsegurado)
        {
            BienAseguradoDto bienAseguradoDto = _mapper.Map<BienAseguradoDto>(bienAsegurado);

            // bienAseguradoDto.Ubicacion.Provincia = "";
            bienAseguradoDto.Ubicacion.Localidad = "";

            Provincia provincia = await _proviciaRepository.BuscarProviciaPorIdAsync(bienAsegurado.Ubicacion.ProvinciaId);

            Localidad localidad = (await _localidadRepository.BuscarLocalidadPorIdAsync(bienAsegurado.Ubicacion.LocalidadId));

            bienAseguradoDto.Ubicacion.Provincia = provincia.Nombre;
            bienAseguradoDto.Ubicacion.Localidad = localidad.Nombre;

            return bienAseguradoDto;
        }


    }
}
