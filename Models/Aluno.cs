using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OlaAspNetMVC_Core.Models
{
    public class Aluno
    {
        public int Matricula { get; set; }
        public String Nome { get; set; }
        public String CPF { get;  set; }

        public float MGP { get; private set; }
        public bool estaMatriculado { get; set; }

    }
}
