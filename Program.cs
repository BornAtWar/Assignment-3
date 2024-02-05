namespace Assignment_3
{ //Author: Demetrius Richards
  //Course: COMP-003A
  //Purpose: Week 3 Assignment
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numeric to letter grade using an if else statement");
            Console.WriteLine("Enter a numeric Grade (0-100):");
            double numericGrade = double.Parse(Console.ReadLine());
            Console.WriteLine("Letter Grade:");
            if (numericGrade >= 90)
            {
                Console.WriteLine("A");
            }
            else if (numericGrade >= 80)
            {
                Console.WriteLine("B");
            }
            else if (numericGrade >= 70)
            {
                Console.WriteLine("C");
            }
            else if (numericGrade >= 60)
            {
                Console.WriteLine("D");
            }
            else if (numericGrade >= 50)
            {
                Console.WriteLine("F");
            }
            Console.WriteLine("******************************************************");
            Console.WriteLine("Integer to string day using an switch statement");
            Console.WriteLine("Enter an Integer day of the week (1-7)");
            int numericDay = int.Parse(Console.ReadLine());
            Console.WriteLine("String Day:");
            if (numericDay == 1)
                Console.WriteLine("Monday");
            else if (numericDay == 2)
                Console.WriteLine("Tuesday");
            else if (numericDay == 3)
                Console.WriteLine("Wednesday");
            else if (numericDay == 4)
                Console.WriteLine("Thursday");
            else if (numericDay == 5)
                Console.WriteLine("Friday");
            else if (numericDay == 6)
                Console.WriteLine("Saturday");
            else if (numericDay == 7)
                Console.WriteLine("Sunday");






        }       
    }
}
