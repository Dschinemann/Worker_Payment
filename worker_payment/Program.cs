using System.Globalization;
using worker_payment.Entities;

public class Program
{
    public static void Main(String[] args)
    {

        Console.WriteLine("Enter with number of employees");
        int NumberOfEmployess = int.Parse(Console.ReadLine());
        List<Employee> employees = new List<Employee>();

        for (int i = 0; i < NumberOfEmployess; i++)
        {
            Console.WriteLine($"employee #{i} data:");
            Console.Write("OutSourced (y/n) ?");
            bool isOutSourced = Console.ReadLine().Equals("y") ? true : false;

            Console.Write("Name:");
            string name = Console.ReadLine();
            Console.Write("Hours:");
            int hours = int.Parse(Console.ReadLine());
            Console.Write("Value per Hour:");
            double ValuePerHours = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (isOutSourced)
            {
                Console.Write("Additional Charge:");
                double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                employees.Add(new OutsourceEmployee(additionalCharge,name,hours,ValuePerHours));
            }
            else
            {
                employees.Add(new Employee(name,hours,ValuePerHours));
            }
        }
        Console.WriteLine("PAYMENTS");
        foreach (Employee employee in employees)
        {
            Console.WriteLine($"{employee.Name} -$ {employee.Payment().ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
