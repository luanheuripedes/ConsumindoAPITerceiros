using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntegraBrasilApi.DTOs
{
    public class BancoResponseDTO
    {
        public string? Ispb { get; set; }
        public string? NomeAbreviado { get; set; }
        public int? CodigoBanco { get; set; }
        public string? NomeCompleto { get; set; }
    }
}