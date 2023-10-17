using CalcularEdadMVC.View;

namespace CalcularEdadMVC.Controller
{
    public class CalculatorController
    {
        private CalculatorView calculatorView;
        private AgeModel ageModel;
      
        public CalculatorController() {
            calculatorView = new CalculatorView();
            ageModel = new AgeModel();
        }
        public void showCalculatorMenu(UserModel user)
        {
            DateTime actualDate = DateTime.Now;
            bool end = false;
            do {
                int op = calculatorView.calculatorMenuManager();
                switch (op)
                {
                    case 1:
                        ageModel.CalculateAgeOtherPlanets(user);
                      
                        break;
                    case 2:
                        (int years, int months, int days) = ageModel.CalculateFutureAge(user.birthday);
                        int option = calculatorView.ShowCalculatorMenu();
                        datesMenu(option, years, months, days);
                        break;
                    case 3:
                        (int yearsActual, int monthsActual, int daysActual) = user.CalculateAge(user.birthday, actualDate);
                        int option2 = calculatorView.ShowCalculatorMenu();
                        datesMenu(option2, yearsActual, monthsActual, daysActual);
                        break;
                    case 4:
                        Console.WriteLine("ADIOS!!");
                        end = true;
                        break;
                }
            } while (end!=true);
            
        }
        public void ShowAgeYear(int years) {
            Console.WriteLine("Años: " + years);
        }
        public void ShowAgeMonthAndDay(int months, int days) {
            Console.WriteLine("Meses: " + months + ", dias: " + days);
        }

        public void datesMenu(int op, int years, int months, int days)
        {
            if (op == 1)
            {
                ShowAgeYear(years);
            }
            else
            {
                ShowAgeMonthAndDay(months, days);
            }
        }
    }
}
