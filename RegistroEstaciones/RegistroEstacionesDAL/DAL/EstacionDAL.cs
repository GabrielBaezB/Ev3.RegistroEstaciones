using RegistroEstacionesDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroEstacionesDAL.DAL
{
   public class EstacionDAL
    {
        //Lista estatica
        private static List<Estacion> estacions = new List<Estacion>();
        //Ver lista
        public List<Estacion> GetAll()
        {
            return estacions;
        }


        //Agregar
        public void Add(Estacion e)
        {
            estacions.Add(e);
        }

        //Delete

        public void Remove(int id)
        {
            Estacion estacion = estacions.Find(e => e.Id == id);
            estacions.Remove(estacion);
        }

        public Estacion FindById(int id)
        {
            return estacions.Find(e => e.Id == id);
        }

    }
}
