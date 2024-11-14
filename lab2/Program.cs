using lab2.zadania;

class Program
{
    public static void Main(string[] args)
    {
        Person any = new Person("Name", "Surname", -15, "123456");
        any.PrzedstawSie();  // Nazywam sie Name Surname i mam 0 lat

        Quantity number = new Quantity(2);
        number.Condition(); // 2
        number.Sum(3); 
        number.Condition(); // 5
        number.Subtraction(1); 
        number.Condition(); // 4

        Adder nums = new Adder([1, 2, 3, 4]);
        Console.WriteLine(nums.Sum()); // 10
        Console.WriteLine(nums.SumDiv3()); // 2
        Console.WriteLine(nums.Count()); // 4
        nums.Display(0, 10); // 1 2 3 4

    }
}

