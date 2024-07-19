using Application.Dtos.Response.DtosUtils;
using Application.Interfaces.Repository;
using Application.Interfaces.Service;
using AutoMapper;

namespace Application.UserCase
{
    public class FormateoVehiculoVersionServiceImpl : IFormateoVehiculoVersionService
    {
        public IVersionRepository _versionRepository;
        private IMapper _mapper;

        public FormateoVehiculoVersionServiceImpl(IVersionRepository versionRepository, IMapper mapper)
        {
            _versionRepository = versionRepository;
            _mapper = mapper;
        }

        public async Task<VehiculoVersioResponseDto> MapearVehiculoVersion(int versionId)
        {
            VehiculoVersioResponseDto vehiculoVersioDto = _mapper
                                                     .Map<VehiculoVersioResponseDto>(
                                                        await _versionRepository.
                                                            BuscarVersionPorVersionIdAsync(versionId));

            return vehiculoVersioDto;
        }
    }
}
