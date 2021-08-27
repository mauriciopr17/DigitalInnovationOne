using System.Collections.Generic;

namespace DIO.Series.Interfaces
{
  public interface IRepositorio<T>
  {
    void Atualiza(int id, T entidade);
    void Exclui(int id);
    void Insere(T entidade);
    List<T> Lista();
    int ProximoId();
    T RetornarPorId(int id);
  }

}