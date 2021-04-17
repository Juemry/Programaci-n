using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2Archivos
{
    class Tarjetas
    {
        //Numero de tarjeta planteado como string ya que es la llave o key de los archivos con los que vamos a trabajar
        public string NroTarjeta { get; set; }
        public string Local { get; set; }
        public int CreditoDisponible { get; set; }
    }
}
