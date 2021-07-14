using System;

namespace RegistroEstacionesDAL
{
    public partial class PuntoCarga
    {
        public String TipoTxt
        {
            get
            {
                String texto = "";
                switch (Tipo)
                {
                    case 1:
                        texto = "Carga Lenta";
                        break;
                    case 2:
                        texto = "Carga semi rápida";
                        break;
                    case 3:
                        texto = "Carga rápida";
                        break;
                    case 4:
                        texto = "Carga super rápida";
                        break;
                    case 5:
                        texto = "Carga ultra rápida";
                        break;
                                   }
                return texto;
            }
        }
    }
}
