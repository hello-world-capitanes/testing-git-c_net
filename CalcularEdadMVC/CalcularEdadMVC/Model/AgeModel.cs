public class AgeModel
{
    public int year;
    public int month;
    public int day;
    public AgeModel(){}

    public (int, int, int) CalculateFutureAge(DateTime birthday) 
    {
        Console.WriteLine(" ");
        Console.Write("Ingresa tu fecha futura (dd/mm/aaaa): ");
        string input = Console.ReadLine();
        DateTime futureDate = DateTime.Parse(input);
        Console.WriteLine(" ");

        int years = futureDate.Year - birthday.Year;
        int months = futureDate.Month - birthday.Month;
        int days = futureDate.Day - birthday.Day; 

        if (days < 0)
        {
            months--;
            days += DateTime.DaysInMonth(futureDate.Year, futureDate.Month);
        }

        if (months < 0)
        {
            years--;
            months += 12;
        }
        return (years, months, days);
    }

    public void CalculateAgeOtherPlanets(UserModel user)
    {
        Console.WriteLine(" ");
        string date = user.birthday.ToString();

        if (DateTime.TryParse(date, out DateTime birthday))
        {
            DateTime actualTime = DateTime.Now;

            if (birthday <= actualTime)
            {
                (int years, int months, int days) earthAge = user.CalculateAge(birthday, actualTime);
                //Tierra
                double earthDays = earthAge.years * 365 + earthAge.months * 30 + earthAge.days;
                //Mercurio
                double merYears = earthDays / 88;
                Console.WriteLine($"1. Mercurio: {merYears} años.");
                // Venus
                double venusYears = earthDays / 225;
                Console.WriteLine($"2. Venus: {venusYears} años.");
                // Marte
                double marsYears = earthDays / 687;
                Console.WriteLine($"3. Marte: {marsYears} años.");
                // Júpiter
                double jupiterYears = earthDays / (11.9 * 365.25);
                Console.WriteLine($"4. Júpiter: {jupiterYears} años.");
                // Saturno
                double satYears = earthDays / 29;
                Console.WriteLine($"5. Saturno: {satYears} años.");
                // Urano
                double urYears = earthDays / 84;
                Console.WriteLine($"6. Urano: {urYears} años.");
                // Neptuno
                double neptuneYears = earthDays / 164;
                Console.WriteLine($"7. Neptuno: {neptuneYears} años.");
            }
        }
    }
}