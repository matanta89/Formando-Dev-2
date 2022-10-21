using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormandoDev
{
    public class Usuarios
    {
        private string nome { get; set; }
        public int ID { get; private set; }
        public string Dono { get; private set; }

        public Usuarios()
        {

        }

        public Usuarios(string nome, int iD, string dono)
        {
            Nome = nome;
            ID = iD;
            Dono = dono;
            
        }
        public override string ToString()
        {


            return "Nome do Usuário:"
                + nome
                + ",Identificação:"
                + ID
                + ", Dono:"
                + Dono.ToString();
        }

        public string Nome
        {
            get { return Nome; }
            set
            {
                if (value != null && value.Length > 5)
                    nome = value;
            }
        }
    }
}
