using Growler.Models;
using System.Collections.Generic;

namespace Growler.Repo
{
    public interface IGrowlerRepo
    {
        IEnumerable<Brew> GetAllBrews();
        Brew GetBrewById(int id);
    }
}