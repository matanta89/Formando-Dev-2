using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormandoDev
{
      public class HistoriaDeUsuarios
    {
        public string Descricao { get; set; }
        public int ID { get; private set; }

        public HistoriaDeUsuarios(string descricao, int iD)
        {
            Descricao = descricao;
            ID = iD;
        }
        public override string ToString()
        {


            return "Descrição"
                + Descricao
                + ",Identificação"
                + ID.ToString();
        }

    }
}
