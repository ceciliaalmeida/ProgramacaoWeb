using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProgramacaoWeb.Models
{
    public class RequisicaoExame
    {
        public DateTime DataRequisicao { get; set; }
        public int Situacao { get; set; }
        public DateTime DataAgendamento { get; set; }
    }
}