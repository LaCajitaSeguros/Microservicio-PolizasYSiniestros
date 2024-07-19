using Application.Dtos.Requets.DtosUtils;
using AutoMapper;
using Domain.Entitys;


namespace Application.ConfigMapper
{
    public class TercerosInvolucradosMapper : Profile
    {
        public TercerosInvolucradosMapper()
        {
            CreateMap<Tercero, TercerosInvolucradosRequestDto>().ReverseMap();
        }
    }
}
