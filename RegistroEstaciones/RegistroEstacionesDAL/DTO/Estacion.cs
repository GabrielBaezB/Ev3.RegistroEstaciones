using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroEstacionesDAL
{
    public class Estacion
    {

        private int id;
        private string direccion;
        private int capacidadMax;
        private string region;
        private string horarioAtencion;

        public int Id { get => id; set => id = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public int CapacidadMax { get => capacidadMax; set => capacidadMax = value; }
        public string Region { get => region; set => region = value; }
        public string HorarioAtencion { get => horarioAtencion; set => horarioAtencion = value; }
    }
}
