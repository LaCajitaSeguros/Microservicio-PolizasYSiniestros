using Application.Dtos.DomainDTO;
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
    public class TercerosInvolucradosDtoMapper : Profile
    {
        public TercerosInvolucradosDtoMapper()
        {
            CreateMap<Tercero, TercerosInvolucradosDto>()
            .ForMember(dest => dest.Nombre, opt => opt.MapFrom(src => src.Nombre))
            .ForMember(dest => dest.CompaniaDeSeguro, opt => opt.MapFrom(src => src.CompaniaDeSeguro))
            .ForMember(dest => dest.Ubicacion, opt => opt.MapFrom(src => src.Ubicacion))
            .ForMember(dest => dest.Patente, opt => opt.MapFrom(src => src.Patente)).ReverseMap();
        }
    }
}
