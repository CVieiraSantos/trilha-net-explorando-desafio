using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioProjetoHospedagem.Exceptions
{
    public class CapacidadeDeHospedes : Exception
    {
        public CapacidadeDeHospedes(string message) : base(message)
        {            
        }
    }
}