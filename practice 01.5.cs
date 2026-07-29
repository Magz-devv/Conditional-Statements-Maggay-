class Program
{
    static void Main(string[] args)
    {
        char choice;
        double radius, answer;

        Console.WriteLine("A - Area");
        Console.WriteLine("P - Perimeter");
        Console.WriteLine("X - Exit");
        Console.Write("Enter your choice: ");
        choice = Convert.ToChar(Console.ReadLine());

        switch (char.ToUpper(choice))
        {
            case 'A':
                Console.Write("Enter the radius: ");
                radius = Convert.ToDouble(Console.ReadLine());

                answer = 3.1416 * radius * radius;
                Console.WriteLine("Area is " + answer);
                break;

            case 'P':
                Console.Write("Enter the radius: ");
                radius = Convert.ToDouble(Console.ReadLine());

                answer = 2 * 3.1416 * radius;
                Console.WriteLine("Perimeter is " + answer);
                break;

            case 'X':
                Console.WriteLine("Program closed.");
                break;

            default:
                Console.WriteLine("Invalid choice.");
                break;
        }
    }
}
