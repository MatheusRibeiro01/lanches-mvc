using System.Collections;
using System.Collections.Generic;
using Lanches.Models;

namespace Lanches.Repositories
{
    public interface ILancheRepository
    {
        IEnumerable <Lanche> Lanches{ get; }
        IEnumerable <Lanche> LanchesPreferidos{ get; }
        Lanche GetLancheById(int lancheId);
    }
}