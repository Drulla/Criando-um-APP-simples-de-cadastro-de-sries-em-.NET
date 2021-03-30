using System.Collections.Generic;

namespace DIO.Series.Interfaces
{
    public interface Irepositorio<T>
    {
         List<T> Lista();
         T RetornaPorID (int id);
         void Insere(T entidade);
         void Excluir(int id);
         void Atualiza(int id, T entidade);
         int Proximo();
    }
}