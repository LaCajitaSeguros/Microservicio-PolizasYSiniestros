﻿using Application.Dtos.Response.DtosUtils;
using AutoMapper;
using Domain.Entities;
namespace Application.ConfigNuevoMapper
{
    public class VehiculoVersionMapper : Profile
    {
        public VehiculoVersionMapper()
        {
            CreateMap<VersionVehiculo, VehiculoVersioResponseDto>()
            .ForMember(dest => dest.NombreVersion, opt => opt.MapFrom(src => src.NombreVersion))
            .ForMember(dest => dest.Modelo, opt => opt.MapFrom(src => src.Modelo.NombreModelo))
            .ForMember(dest => dest.Marca, opt => opt.MapFrom(src => src.Modelo.Marca.NombreMarca)).ReverseMap();

        }
    }
}
