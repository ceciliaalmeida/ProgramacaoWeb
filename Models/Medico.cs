using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProgramacaoWeb.Models
{
    public class Medico
    {
        public string nome { get; set; }
        public string crm { get; set; }
        public string tel { get; set; }
        public int atendimentos { get; set; }
    }
}