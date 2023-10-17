using CalcularEdadMVC.Controller;
using CalcularEdadMVC.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularEdadMVC
{
    public class MenuView
    {
      
        public MenuView() {
          
        }
        public int ShowMenu()
        {
            Console.WriteLine(" ");
            Console.WriteLine("--- MAIN MENU ---");
            Console.WriteLine("1. Guardar nombre");
            Console.WriteLine("2. Guardar cumpleaños");
            Console.WriteLine("3. Calcular edad");
            Console.WriteLine("4. Salir");
            Console.Write("Opcion: ");

            int op = Convert.ToInt32(Console.ReadLine());
            
            return op;
        }

    }

    
}
