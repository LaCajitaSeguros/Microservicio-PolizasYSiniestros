using Application.Dtos.DomainDTO;
using Application.Dtos.Requets;
using AutoMapper;
using Domain.Entitys;


namespace Application.ConfigMapper
{
    public class SiniestroMapperProfile : Profile
    {
        public SiniestroMapperProfile()
        {

            CreateMap<SiniestroDTO, Siniestro>();

            CreateMap<SiniestroPostRequest, Siniestro>()
                  .ForMember(dest => dest.TercerosInvolucrados, opt => opt.MapFrom(src => src.Siniestro.TercerosInvolucrados))
                  .ForMember(dest => dest.Ubicacion, opt => opt.MapFrom(src => src.Siniestro.Ubicacion)).ReverseMap();
        }
    }
}
