using Application.Dtos.Response.DtosUtils;
using AutoMapper;
using Domain.Entitys;

namespace Application.ConfigNuevoMapper
{
    public class TercerosInvolucradosDtoMapper : Profile
    {
        public TercerosInvolucradosDtoMapper()
        {
            CreateMap<Tercero, TercerosInvolucradosResponseDto>()
            .ForMember(dest => dest.Nombre, opt => opt.MapFrom(src => src.Nombre))
            .ForMember(dest => dest.CompaniaDeSeguro, opt => opt.MapFrom(src => src.CompaniaDeSeguro))
            .ForMember(dest => dest.Ubicacion, opt => opt.MapFrom(src => src.Ubicacion))
            .ForMember(dest => dest.Patente, opt => opt.MapFrom(src => src.Patente)).ReverseMap();
        }
    }
}
