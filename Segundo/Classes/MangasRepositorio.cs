using System;
using System.Collections.Generic;
using Matheus.Mangas.Interface;

namespace Matheus.Mangas
{
    public class MangaRepositorio : IRepositorio<Manga>
    {
        public List<Manga> listaManga = new List<Manga>();

        public void atualiza(int id, Manga objeto)
        {
            listaManga[id] = objeto;
        }
        
        public void Exclui(int id)
        {
            listaManga[id].Excluir();
        }

        public void Insere(Manga objeto)
        {
            listaManga.Add(objeto);
        }

        public List<Manga> Lista()
        {
            return listaManga;
        }

         public int ProximoId()
        {
            return listaManga.Count;
        }

        public Manga RetornaPorId(int id)
        {
            return listaManga[id];
        }
    }
}