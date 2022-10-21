using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormandoDev
{
    public class Cartas
    {
        public int ID { get; private set; }
        public int ValorCarta { get; set; }

        public Cartas(int iD, int valorCarta)
        {
            ID = iD;
            ValorCarta = valorCarta;
        }

        public override string ToString() { 
        

            return "Cartas:"
                + ID
                + ",Valor da Carta:"
                + ValorCarta.ToString();
        }
    }
}
