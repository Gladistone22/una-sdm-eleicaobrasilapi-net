using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EleicaoBrasilApi.Models
{
    public class Candidato
    {
        public int id {get; set;}
        public string Nome { get; set; }
        public string partido { get; set; }
        public string Numero { get; set; }
    }
}