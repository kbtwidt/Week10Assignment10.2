namespace Week10Assignment10._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Part 1");

            int[] numbers = { 2, -1, 3, -3, 10, -200 };

            var positiveNumbers = numbers.Where(n => n > 0);

            Console.WriteLine("Positive numbers are:");

            foreach (var num in positiveNumbers)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("\nPart 2");

            List<Employee> employees = new List<Employee>()
            {
                new Employee { Name = "John", Age = 25, Salary = 6000 },
                new Employee { Name = "David", Age = 32, Salary = 7000 },
                new Employee { Name = "Mary", Age = 28, Salary = 4500 },
                new Employee { Name = "Peter", Age = 26, Salary = 8000 },
                new Employee { Name = "Alice", Age = 29, Salary = 5500 }
            };

            var result = employees.Where(e => e.Salary > 5000 && e.Age < 30);

            Console.WriteLine("\nEmployees with salary > 5000 and age < 30:");

            foreach (var emp in result)
            {
                Console.WriteLine("Name: " + emp.Name +
                                  ", Age: " + emp.Age +
                                  ", Salary: $" + emp.Salary);
            }

            Console.WriteLine("\nPart 3");

            string[] cities =
            {
                "ROME", "LONDON", "NAIROBI",
                "CALIFORNIA", "ZURICH", "NEW DELHI",
                "AMSTERDAM", "ABU DHABI", "PARIS"
            };

            Console.Write("Input starting character: ");
            char start = Convert.ToChar(Console.ReadLine());

            Console.Write("Input ending character: ");
            char end = Convert.ToChar(Console.ReadLine());

            var result2 = cities.Where(c =>
                c.StartsWith(start.ToString(), StringComparison.OrdinalIgnoreCase) &&
                c.EndsWith(end.ToString(), StringComparison.OrdinalIgnoreCase));

            foreach (var city in result2)
            {
                Console.WriteLine("The city starting with " + start +
                                  " and ending with " + end +
                                  " is : " + city);
            }

            Console.WriteLine("\nPart 4");

            List<int> numbers2 = new List<int>()
            {
                55, 200, 740, 76, 230, 482, 95
            };

            var result3 = numbers.Where(n => n > 80);

            Console.WriteLine("The numbers greater than 80 are:");

            foreach (var num in result3)
            {
                Console.WriteLine(num);
            }


            Console.WriteLine("\nPart 5");

            char[] letters = { 'c', 'f', 'j' };
            char target = 'a';

            char result4 = letters
                .Where(c => c > target)
                .DefaultIfEmpty(letters[0])
                .First();

            Console.WriteLine("Output: " + result4);
        }
    }
}
