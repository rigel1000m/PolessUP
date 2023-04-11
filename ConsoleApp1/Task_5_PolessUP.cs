namespace ConsoleApp1;

public class Task_5_PolessUP
{
    public static int maxNum(int[] array)
    {
        int maxNum = 0;
        foreach (var num in array)
        {
            if (num > maxNum)
            {
                maxNum = num;
            }
        }

        return maxNum;
    }
}