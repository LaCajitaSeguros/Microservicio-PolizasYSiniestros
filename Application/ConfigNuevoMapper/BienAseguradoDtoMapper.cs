using Application.Dtos.Response.DtosUtils;
using AutoMapper;
using Domain.Entitys;

namespace Application.ConfigNuevoMapper
{
    internal class BienAseguradoDtoMapper : Profile
    {
        public BienAseguradoDtoMapper()
        {
            CreateMap<BienAsegurado, BienAseguradoResponseDto>()
            .ForMember(dest => dest.CodMotor, opt => opt.MapFrom(src => src.CodMotor))
            .ForMember(dest => dest.CodChasis, opt => opt.MapFrom(src => src.CodChasis)).ReverseMap();

        }
    }
}
