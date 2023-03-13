using IntegraBrasilApi.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntegraBrasilApi.Interfaces
{
    public interface IBancoService
    {
        Task<ResponseGenericoDTO<List<BancoResponseDTO>>> BuscarTodos();
        Task<ResponseGenericoDTO<BancoResponseDTO>> BuscarBanco(string codigoBanco);
    }
}