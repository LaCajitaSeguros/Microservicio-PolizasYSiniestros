using Application.Dtos.DomainDTO;
using Application.Dtos.Requets;
using Application.Dtos.Response;
using Application.NuevosDtos.DomainDto;
using AutoMapper;
using Domain.Entities;
using Domain.Entitys;
using System;
namespace Application.ConfigNuevoMapper
{
    public class VehiculoVersionMapper : Profile
    {
        public VehiculoVersionMapper()
        {
            CreateMap<VersionVehiculo, VehiculoVersioDto>()
            .ForMember(dest => dest.NombreVersion, opt => opt.MapFrom(src => src.NombreVersion))
            .ForMember(dest => dest.Modelo, opt => opt.MapFrom(src => src.Modelo.NombreModelo))
            .ForMember(dest => dest.Marca, opt => opt.MapFrom(src => src.Modelo.Marca.NombreMarca)).ReverseMap();

        }
    }
}
