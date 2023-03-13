using AutoMapper;
using IntegraBrasilApi.DTOs;
using IntegraBrasilApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntegraBrasilApi.Services
{
    public class BancoService : IBancoService
    {
        private readonly IMapper _mapper;
        private readonly IBrasilAPi _brasilAPI;

        public BancoService(IMapper mapper, IBrasilAPi brasilAPI)
        {
            _mapper = mapper;
            _brasilAPI = brasilAPI;
        }

        public async Task<ResponseGenericoDTO<BancoResponseDTO>> BuscarBanco(string codigoBanco)
        {
            throw new NotImplementedException();
        }

        public async Task<ResponseGenericoDTO<List<BancoResponseDTO>>> BuscarTodos()
        {
            throw new NotImplementedException();
        }
    }
}