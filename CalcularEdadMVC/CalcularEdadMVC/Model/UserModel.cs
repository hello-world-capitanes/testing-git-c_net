public class UserModel
{

    public string name;
    public DateTime birthday;
    public UserModel(){}

    public void saveName()
    {
        Console.Write("Introduce tu nombre: ");
        string input = Console.ReadLine();

        name = input;
        Console.WriteLine("Nombre: " + name);
    }

    public void saveBirthday()
    {
        Console.Write("Ingresa tu fecha de nacimiento (dd/mm/aaaa): ");
        string input = Console.ReadLine();
        DateTime dt = DateTime.Parse(input);

        birthday = dt;
        Console.WriteLine("Cumpleaños: " + birthday);
    }

    public (int, int, int) CalculateAge(DateTime birthday, DateTime actualDate)
    {
        int years = actualDate.Year - birthday.Year;
        int months = actualDate.Month - birthday.Month;
        int days = actualDate.Day - birthday.Day;


        if (days < 0)
        {
            months--;
            days += DateTime.DaysInMonth(actualDate.Year, actualDate.Month);
        }

        if (months < 0)
        {
            years--;
            months += 12;
        }

        return (years, months, days);
    }
}