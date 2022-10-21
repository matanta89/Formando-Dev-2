using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormandoDev
{
     public class Votos
    {
        public string IdUsuario { get; private set;}
        public int ID { get; private set; }
        public int IdCarta { get; private set; }
        public int IdHistoria { get; private set; }


        public Votos() { 
        }


        public Votos(string idusuario, int id, int idcarta, int idhistoria )
        {
            IdUsuario = idusuario;
            ID = id;
            IdCarta = idcarta;
            IdHistoria = idhistoria;
        }
        public override string ToString()
        {


            return "Identificação do Usuário:"
                + IdUsuario
                + ",ID:"
                + ID
                + ",Identificação da Carta:"
                + IdCarta
                + ",Identificação da História:"
                + IdHistoria.ToString();
        }


    }
}
