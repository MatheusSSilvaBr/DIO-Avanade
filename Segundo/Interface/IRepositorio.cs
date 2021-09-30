using System;
using System.Collections.Generic;

namespace Matheus.Mangas.Interface
{
    public interface IRepositorio<T>
    {
         List<T> Lista();

         T RetornaPorId(int id);

         void Insere(T entidade);

         void Exclui(int id);

         void atualiza(int id, T entidade);    

         int ProximoId();
    }
}