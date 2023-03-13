using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using IntegraBrasilApi.DTOs;
using IntegraBrasilApi.Interfaces;

namespace IntegraBrasilApi.Services
{
    public class EnderecoService : IEnderecoService
    {
        private readonly IBrasilAPi _brasilAPI;
        private readonly IMapper _mapper;

        public EnderecoService(IBrasilAPi brasilAPI, IMapper mapper)
        {
            _brasilAPI = brasilAPI;
            _mapper = mapper;
        }

        public async Task<ResponseGenericoDTO<EnderecoResponseDTO>> BuscarEndereco(string cep)
        {
            var endereco = await _brasilAPI.BuscarEnderecoPorCEP(cep);
            return _mapper.Map<ResponseGenericoDTO<EnderecoResponseDTO>>(endereco);
        }
    }
}