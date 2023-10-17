using CalcularEdadMVC.Controller;
using CalcularEdadMVC.View;
using System;

namespace CalcularEdadMVC
{
    internal class MenuController
    {
        private UserModel user { get; set; }
        private MenuView menuView { get; set; }

        private CalculatorController calculatorController { get; set; }

        public MenuController() {
            user = new UserModel();
            menuView = new MenuView();  
            calculatorController = new CalculatorController();
        }

        public void menuManager() {
            bool end = false;
            do
            {
                int op = menuView.ShowMenu();
                switch (op)
                {
                    case 1: user.saveName();
                        break;
                    case 2: user.saveBirthday();
                        break;
                    case 3: calculatorController.showCalculatorMenu(user);
                        break;
                    case 4:
                        Console.WriteLine("ADIOS!!");
                        end = true;
                        break;

                }
            } while (end!=true);
            
        }

        public void getMenu()
        {
            int option = menuView.ShowMenu();
        }

        public string getName() {
            
            return user.name;
        }
    }
}
