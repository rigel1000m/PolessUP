namespace ConsoleApp1;
using static ConsoleApp1.Task_2_PolessUP;
using static ConsoleApp1.Task_3_PolessUP;
using static ConsoleApp1.Task_5_PolessUP;

public class main
{
    static void Main(string[] args)
    {
        Console.WriteLine("Первое задание:");
        Console.Write("    +\"\"\"\"\"+\n   (| o o |)\n    |  ^  |\n    | '-' |\n    +-----+\n");
        
        Console.WriteLine("Второе задание: ");
        Console.WriteLine("Введите цель");
        int target = int.Parse(Console.ReadLine());
        int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        Console.WriteLine(FindIndexes(nums, target));
        
        Console.WriteLine("Третье задание: ");
        Console.WriteLine("Первая проверка: " + binarySearch(nums, 8));
        Console.WriteLine("Вторая провекра: " + binarySearch(nums, 11));
        
        Console.WriteLine("Пятое задание: ");
        maxNum(nums);

    }
}
