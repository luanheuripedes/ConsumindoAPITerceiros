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