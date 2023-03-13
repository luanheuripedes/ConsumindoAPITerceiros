using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IntegraBrasilApi.DTOs;
using IntegraBrasilApi.Models;

namespace IntegraBrasilApi.Interfaces
{
    public interface IBrasilAPi
    {
        Task<ResponseGenericoDTO<EnderecoModel>> BuscarEnderecoPorCEP(string cep);
        Task<ResponseGenericoDTO<List<BancoModel>>> BuscarTodosBancos();
        Task<ResponseGenericoDTO<BancoModel>> BuscarBanco(string codigoBanco);
    }
}