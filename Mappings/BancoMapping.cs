using AutoMapper;
using IntegraBrasilApi.DTOs;
using IntegraBrasilApi.Models;

namespace IntegraBrasilApi.Mappings
{
    public class BancoMapping:Profile
    {
        public BancoMapping()
        {
            CreateMap(typeof(ResponseGenericoDTO<>), typeof(ResponseGenericoDTO<>));
            CreateMap<BancoResponseDTO, BancoModel>().ReverseMap();
        }
        
    }
}
