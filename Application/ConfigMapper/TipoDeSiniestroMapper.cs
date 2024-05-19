using Application.Dtos.DomainDTO;
using Domain.Entitys;

namespace Application.ConfigMapper
{
    public class TipoDeSiniestroMapper
    {

        public static List<SiniestroTipoDeSiniestro> TipoDeSiniestroASiniestroTipoDeSiniestro(List<TipoSiniestroDTO> TiposDeSiniestros)
        {
            List<SiniestroTipoDeSiniestro> tipoDeSiniestros = new List<SiniestroTipoDeSiniestro>();
            foreach (TipoSiniestroDTO tipoSiniestroDTO in TiposDeSiniestros)
            {
                SiniestroTipoDeSiniestro siniestroTipoDeSiniestro = new SiniestroTipoDeSiniestro();
                siniestroTipoDeSiniestro.TipoDeSiniestroId = tipoSiniestroDTO.TipoSiniestroId;

                tipoDeSiniestros.Add(siniestroTipoDeSiniestro);
            }

            return tipoDeSiniestros;
        }

        public static List<TipoSiniestroDTO> SiniestroTipoDeSiniestroATipoDeSiniestro(IList<SiniestroTipoDeSiniestro> siniestroTipoDeSiniestros)
        {
            List<TipoSiniestroDTO> listTipoDeSiniestrosDtos = new List<TipoSiniestroDTO>();
            foreach (SiniestroTipoDeSiniestro item in siniestroTipoDeSiniestros)
            {
                TipoSiniestroDTO tipoSiniestroDTO = new TipoSiniestroDTO();
                tipoSiniestroDTO.TipoSiniestroId = item.TipoDeSiniestroId;
                listTipoDeSiniestrosDtos.Add(tipoSiniestroDTO);
            }

            return listTipoDeSiniestrosDtos;
        }

    }
}
