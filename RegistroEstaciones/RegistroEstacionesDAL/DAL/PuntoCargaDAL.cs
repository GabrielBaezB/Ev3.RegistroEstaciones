using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroEstacionesDAL.DAL
{
   public class PuntoCargaDAL
    {
        //Lista estatica
        private static List<PuntoCarga> puntoCargas = new List<PuntoCarga>();
        //Ver lista
        public List<PuntoCarga> GetAll()
        {
            return puntoCargas;
        }

        //Agregar
        public void Add(PuntoCarga p)
        {
            puntoCargas.Add(p);
        }

        //Delete
        //public void Remove(string id)
        //{
        //    PuntoCarga pc = puntoCargas.Find(p => p.Id == id);

        //    puntoCargas.Remove(pc);

        //}
        public List<PuntoCarga> GetAll(int tipo)
        {
            return puntoCargas.FindAll(p => p.Tipo == tipo);
        }
        public PuntoCarga findById(int id)
        {
            return puntoCargas.Find(p => p.Id == id);
        }

    }
}
