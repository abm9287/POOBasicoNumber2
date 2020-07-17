using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POOBasicoPractica2
{
    class Vehiculo
    {
        //Propiedades
        public int Velocidad { get; set; }
        public string Motor { get; set; }
        public int TanqueGasolina { get; set; }

        //Métodos
        public int Aumentar()
        {
            if (Velocidad >= 0 && Velocidad <= 200) 
            {
                Velocidad += 10;
                return Velocidad;
            }else{
                return 200;
            }
        }

        public int Disminuir ()
        {
            if(Velocidad>=0)
            {
                Velocidad -= 5;
            }
            return Velocidad;
        }
        public int Frenar()
        {
            if(Velocidad>=0)
            {
                Velocidad = 0;
            }
            return Velocidad;
        }
      
    }
}
