﻿using Application.Dtos.DomainDTO;
using Application.Dtos.Requets;
using Application.Exceptions;
using Application.Interfaces.Repository;
using Application.Interfaces.Service;
using AutoMapper;
using Domain.Entitys;
using Microsoft.Extensions.Logging;

namespace Application.UserCase
{
    public class SiniestroServiceImpl : ISiniestroService
    {


        private IGenericRepository _genericRepository;
        private IValidacionesRepository _validacionesRepository;
        private ILogger<PolizaServiceImpl> _logger;
        private IMapper _mapper;
        private IPolizaRepository _polizaRepository;

        public SiniestroServiceImpl(IGenericRepository genericRepository,
                                    ILogger<PolizaServiceImpl> logger,
                                    IMapper mapper,
                                    IValidacionesRepository validacionesRepository,
                                    IPolizaRepository polizaRepository)
        {
            _genericRepository = genericRepository;
            _validacionesRepository = validacionesRepository;
            _logger = logger;
            _mapper = mapper;
            _polizaRepository = polizaRepository;
        }


        public async Task<SiniestroPostRequest> RegistrarSiniestroAsync(SiniestroPostRequest siniestroPostRequest)
        {
            Poliza poliza = await _polizaRepository.BuscarPolizaPorNroPoliza(siniestroPostRequest.NroDePoliza);

            if (poliza == null)
            {
                throw new CustomBadRequest("No se encontro una poliza asociada al nro de poliza: " + siniestroPostRequest.NroDePoliza);
            }

            //Creo el siniestro y mapeo los datos del request
            Siniestro siniestro = _mapper.Map<Siniestro>(siniestroPostRequest);

            //Formateo las imagenes del request a un string separado por comas y se las incorporo al objeto siniestro

            List<string> listImagenesString = new List<string>();   

            foreach (ImagenDTO imagenDTO in siniestroPostRequest.Siniestro.Imagenes)
            {
                listImagenesString.Add(imagenDTO.UrlImagen);
            }

            string imagenes = string.Join(",", listImagenesString);

            siniestro.Imagenes = imagenes;  

            return null;
        }
    }
}
