using Clinic.Core.Repositories;
using Clinic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.Data.Repositories
{
    internal class TurnRepository:ITurnRepository
    {
        private readonly DataContext _context;
        public TurnRepository(DataContext context)
        {
            _context = context;
        }

        public void AddTurn(Turn turn)
        {
            _context.Turns.Add(turn);   
        }

        public void deleteTurn(int id)
        {
           _context.Turns.Remove( _context.Turns.Find(x => x.code == id));
        }

        public Turn GetTurn(int id)
        {
            return _context.Turns.Find(x => x.code == id);
        }

        public IEnumerable<Turn> GetTurns()
        {
           return _context.Turns;
        }

        public bool UpdateTurn(int id, Turn turn)
        {
            var e = _context.Turns.Find(e => e.code == id);
            if (e != null)
            {
               e.date = turn.date;
               e.Dr=turn.Dr;
               e.Pt=turn.Pt;

                return true;
            }
            return false;
        }
    }
}
