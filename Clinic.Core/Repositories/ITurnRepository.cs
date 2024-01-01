using Clinic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.Core.Repositories
{
    public interface ITurnRepository
    {
        public IEnumerable<Turn> GetTurns();
        public Turn GetTurn(int id);
        public void AddTurn(Turn turn);
        public bool UpdateTurn(int id, Turn turn);
        public void deleteTurn(int id);
    }
}
