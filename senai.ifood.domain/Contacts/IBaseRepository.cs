using System.Collections.Generic;

namespace senai.ifood.domain.Contacts {
    //usando generics
    public interface IBaseRepository<T> where T : class {

        //para fazer join na hora de listar, se quiser que faça o join
        IEnumerable<T> Listar (string[] includes = null);

        int Atualizar (T dados);

        int Inserir (T dados);

        int Deletar (T dados);

        //aqui é a mesma coisa
        T BuscarPorId (int id, string[] includes=null);
    }
}