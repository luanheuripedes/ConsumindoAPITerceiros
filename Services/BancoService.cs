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
            var banco = await _brasilAPI.BuscarBanco(codigoBanco);
            return _mapper.Map<ResponseGenericoDTO<BancoResponseDTO>>(banco);
            
        }

        public async Task<ResponseGenericoDTO<List<BancoResponseDTO>>> BuscarTodos()
        {
            var bancos = await _brasilAPI.BuscarTodosBancos();
            return _mapper.Map<ResponseGenericoDTO<List<BancoResponseDTO>>>(bancos);
        }
    }
}