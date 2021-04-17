using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas.Model
{
    public class Medico
    {
        public int Legajo { get; set; }
        public String Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }

        public void Curar(Paciente paciente, int nroSala)
        {
            nroSala = 50; //Actualizo el dato de la sala porque estaba mal
            paciente.Temperatura--;
            Console.WriteLine("Curando el paciente " + paciente.Nombre + " en la sala Nro: " + nroSala.ToString());
        }
    }
}
