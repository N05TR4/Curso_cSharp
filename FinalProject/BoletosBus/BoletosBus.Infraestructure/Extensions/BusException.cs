using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoletosBus.Infraestructure.Extensions
{
    public class BusException : Exception
    {
        public BusException(string message) : base(message) 
        { 

        }
    }
}
