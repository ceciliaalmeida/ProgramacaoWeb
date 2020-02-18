using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProgramacaoWeb.Models
{
    public class Paciente
    {
    public String nome { get; set; } 
    public int sexo { get; set; }
    public DateTime nascimento { get; set; }

    public virtual Consulta Consulta { get; set; }
      

    }
}