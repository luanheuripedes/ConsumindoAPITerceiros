using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using IntegraBrasilApi.DTOs;
using IntegraBrasilApi.Models;

namespace IntegraBrasilApi.Mappings
{
    public class EnderecoMapping:Profile
    {
        public EnderecoMapping()
        {
          CreateMap(typeof(ResponseGenericoDTO<>), typeof(ResponseGenericoDTO<>));  
          CreateMap<EnderecoResponseDTO,EnderecoModel>().ReverseMap();
        }
        
    }
}