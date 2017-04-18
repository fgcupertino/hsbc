using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HSBC
{
    public class ContaPoupanca : Conta
    {
        
        public override decimal Sacar (decimal valor)
        {
            
            if (valor + 0.10M <= 1000)
            {
                valor=(valor + 0.10M);
                return valor ;
            }

            else
            {
                return 0;
            }   
        }   


    
    }


}
