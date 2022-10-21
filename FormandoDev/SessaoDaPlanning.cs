using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormandoDev
{
     public class SessaoDaPlanning
    {
        public string DescricaoPlanning { get; set; }
        public int Id { get; private set; }
        public List<HistoriaDeUsuarios> ListaDeHistoriaDeUsuario { get; set; } 
        public List<Cartas> ListaCarta { get; set; }

        public List<Usuarios> ListaUsuarios { get; set; }

        public List<Votos> ListaVotos { get; private set; }
        public SessaoDaPlanning(string descricaoPlanning, int id, List<HistoriaDeUsuarios> listaDeHistoriaDeUsuario, List<Cartas> listaCarta, List<Usuarios> listaUsuarios, List<Votos> listaVotos)
        {
            DescricaoPlanning = descricaoPlanning;
            Id = id;
            ListaDeHistoriaDeUsuario = listaDeHistoriaDeUsuario;
            ListaCarta = listaCarta;
            ListaUsuarios = listaUsuarios;
            ListaVotos = listaVotos;
        }

        public override string ToString()
        {


            return "Descrição da Planning:"
                + DescricaoPlanning
                + ",ID da Planning:"
                + Id
                + ",Historia de Usuários:"
                + ListaDeHistoriaDeUsuario
                + ",Cartas:"
                +ListaCarta
                +",Usuários"
                +ListaUsuarios
                +",Votos"
                + ListaVotos.ToString();
        }

    }



}
