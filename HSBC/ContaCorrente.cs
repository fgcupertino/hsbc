using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSBC
{
    public class ContaCorrente:Conta
    {
        public override decimal Sacar(decimal valor)
        {
            
            return valor+=0.2m;
        }

    }
}
