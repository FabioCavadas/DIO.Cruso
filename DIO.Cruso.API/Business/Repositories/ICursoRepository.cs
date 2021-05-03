using DIO.Cruso.API.Business.Entities;
using System.Collections.Generic;

namespace DIO.Cruso.API.Business.Repositories
{
    public interface ICursoRepository
    {
        void Adicionar(Curso curso);
        void Commit();
        IList<Curso> ObterPorUsuario(int codigoUsuario);

    }
}
