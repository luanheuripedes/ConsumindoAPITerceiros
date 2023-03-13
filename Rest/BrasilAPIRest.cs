using System.Dynamic;
using System.Runtime.ConstrainedExecution;
using System.Text.Json;
using IntegraBrasilApi.DTOs;
using IntegraBrasilApi.Interfaces;
using IntegraBrasilApi.Models;

namespace IntegraBrasilApi.Rest
{
    public class BrasilAPIRest : IBrasilAPi
    {
        public async Task<ResponseGenericoDTO<EnderecoModel>> BuscarEnderecoPorCEP(string cep)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"https://brasilapi.com.br/api/cep/v1/{cep}");

            var response = new ResponseGenericoDTO<EnderecoModel>();

            using (var client = new HttpClient()){
                var responseBrasilAPI = await client.SendAsync(request);
                var conteudoResponse = await responseBrasilAPI.Content.ReadAsStringAsync();
                var objResponse = JsonSerializer.Deserialize<EnderecoModel>(conteudoResponse);


                if(responseBrasilAPI.IsSuccessStatusCode){
                    response.CodigoHttp = responseBrasilAPI.StatusCode;
                    response.DadosRetorno = objResponse;
                }else{
                    response.CodigoHttp = responseBrasilAPI.StatusCode;
                    response.ErroRetorno = JsonSerializer.Deserialize<ExpandoObject>(conteudoResponse);
                }
            }

            return response;
        }

        public async Task<ResponseGenericoDTO<List<BancoModel>>> BuscarTodosBancos()
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"https://brasilapi.com.br/api/banks/v1");

            var response = new ResponseGenericoDTO<List<BancoModel>>();

            using (var client = new HttpClient())
            {
                var responseBrasilAPI = await client.SendAsync(request);
                var conteudoResponse = await responseBrasilAPI.Content.ReadAsStringAsync();
                var objResponse = JsonSerializer.Deserialize<List<BancoModel>>(conteudoResponse);


                if (responseBrasilAPI.IsSuccessStatusCode)
                {
                    response.CodigoHttp = responseBrasilAPI.StatusCode;
                    response.DadosRetorno = objResponse;
                }
                else
                {
                    response.CodigoHttp = responseBrasilAPI.StatusCode;
                    response.ErroRetorno = JsonSerializer.Deserialize<ExpandoObject>(conteudoResponse);
                }
            }

            return response;
        }

        public async Task<ResponseGenericoDTO<BancoModel>> BuscarBanco(string codigoBanco)
        {
            throw new NotImplementedException();
        }

        
    }
}