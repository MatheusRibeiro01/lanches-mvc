using System.Collections;
using System.Collections.Generic;
using Lanches.Models;

namespace Lanches.Repositories
{
    public interface ICategoriaRepository
    {
        IEnumerable<Categoria> Categorias { get; }
    }
}