namespace ConsoleApp1;

public class Task_2_PolessUP
{
    public static string FindIndexes(int[] nums,int target)
    {
        for (int i = 0; i < nums.Length - 1; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                int sum = nums[i] + nums[j];
                if (sum == target)
                {
                    string indexes = $"Индексы {i} и {j}";
                    return indexes;
                }
            }
        }
        return "Сумма элементов в массиве невозможна для такой цели";
    }
}