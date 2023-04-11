namespace ConsoleApp1;

public class Task_3_PolessUP
{
    public static string binarySearch(int[] array, int item)
    {
        int low = 0;
        int high = array.Length - 1;

        while (low <= high)
        {
            int mid = (low + high) / 2;
            int guess = array[mid];
            if (guess == item)
            {
                return mid.ToString();
            }

            if (guess > item)
            {
                high = mid - 1;
            }
            else
            {
                low = mid + 1;
            }
        }
        return "Элемент не найден....";
    }
}