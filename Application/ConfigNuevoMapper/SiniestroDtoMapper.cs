using Application.NuevosDtos.DomainDto;
using AutoMapper;
using Domain.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ConfigNuevoMapper
{
    public class SiniestroDtoMapper : Profile
    {
        public SiniestroDtoMapper()
        {
            CreateMap<Siniestro, SiniestroDto>()
            .ForMember(dest => dest.SiniestroId, opt => opt.MapFrom(src => src.SiniestroId))
            .ForMember(dest => dest.TercerosInvolucrados, opt => opt.MapFrom(src => src.TercerosInvolucrados))
            .ForMember(dest => dest.Ubicacion, opt => opt.MapFrom(src => src.Ubicacion))
            .ReverseMap();
        }
    
    }
}
