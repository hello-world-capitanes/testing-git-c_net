using CalcularEdadMVC.Controller;


namespace CalcularEdadMVC.View
{
    public class CalculatorView
    {
        private CalculatorController controller;
     
        public CalculatorView(){}

        public int calculatorMenuManager()
        {
            Console.WriteLine(" ");
            Console.WriteLine("--- CALCULADORA DE EDAD ---");
            Console.WriteLine("1. Edad en otros planetas");
            Console.WriteLine("2. Calcular edad futura");
            Console.WriteLine("3. Calcular edad actual");
            Console.WriteLine("4. Salir");
            Console.Write("Opcion: ");

            int op = Convert.ToInt32(Console.ReadLine());
            return op;
        }

        public int ShowCalculatorMenu()
        {
            Console.WriteLine(" ");
            Console.WriteLine("Elija como mostrar la fecha: ");
            Console.WriteLine("1. Años");
            Console.WriteLine("2. Meses y dias");
            Console.WriteLine("3. Salir");
            Console.Write("Opcion: ");

            int op = Convert.ToInt32(Console.ReadLine());
            return op;
        }
    }
}
