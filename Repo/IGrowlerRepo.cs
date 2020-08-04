using System.Collections.Generic;
using Growler.Models;

namespace Growler.Repo
{
    public interface IGrowlerRepo
    {
        IEnumerable<Brew> GetAllBrews();
        Brew GetBrewById(int id);
    }
}