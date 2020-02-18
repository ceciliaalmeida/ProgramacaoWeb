using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProgramacaoWeb.Models
{
    public class Endereco
    {
        public string cidade { get; set; }
        public string logradouro { get; set; } 
        public string cep { get; set; }
        public virtual Estado Estado { get; set; }
    }
}