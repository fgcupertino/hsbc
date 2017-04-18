using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSBC
{
    public class Conta
    {
       
            public int id { get; set; }
            public string Numero { get; set; }
            public string Agencia { get; set; }
            public string Tipo { get; set; }
            public decimal Saldo { get; set; }
            public virtual decimal Sacar(decimal valor)
            {
                return 0;    
            }
    }
          
        
        
  }

