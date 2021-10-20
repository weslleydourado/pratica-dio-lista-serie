using System;
using System.Collections.Generic;
using Cad.Series.Interfaces;

namespace Cad.Series.classes
{
    public class SerieRepo : IRepo<Serie>
    {
        private List<Serie> listaSerie = new List<Serie>();
        public void Atualiza(int id, Serie entidade)
        {
            listaSerie[id] = entidade;
        }
        public void Exclui(int id)
        {
            listaSerie[id].Excluir();
        }

        public void Insere(Serie entidade)
        {
            listaSerie.Add(entidade);
         }

        public List<Serie> Lista()
        {
            return listaSerie;
        }

        public int ProximoId()
        {
            return listaSerie.Count;
        }

        public Serie RetornaId(int id)
        {
            return listaSerie[id];
        }
    }
}