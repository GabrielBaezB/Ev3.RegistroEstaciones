using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroEstacionesDAL
{
   public partial class PuntoCarga
    {
        private int id;
        private int tipo;
        private int capacidadMax;
        private DateTime vidaUtil;

        public int Id { get => id; set => id = value; }
        public int Tipo { get => tipo; set => tipo = value; }
        public int CapacidadMax { get => capacidadMax; set => capacidadMax = value; }
        public DateTime VidaUtil { get => vidaUtil; set => vidaUtil = value; }
    }
}
