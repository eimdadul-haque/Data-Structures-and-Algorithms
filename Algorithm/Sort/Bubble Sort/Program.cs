public class BubbleSort
{
    public static void Main(String[] args)
    {
        var nums = new int[] { 4, 4365, 3, 4536, 12, 56, 67, 3, 467, };
        Console.WriteLine("Input: " + string.Join(", ", nums));
        
        sort(nums);
        Console.WriteLine("Output: " + string.Join(", ", nums));
    }

    public static void sort(int[] nums)
    {
        bool swapped = false;
        for (int i = 0; i < nums.Length - 1; i++)
        {
            for (int j = 0; j < nums.Length - i - 1; j++)
            {
                if (nums[j] > nums[j + 1])
                {
                    int temp = nums[j];
                    nums[j] = nums[j + 1];
                    nums[j + 1] = temp;
                    swapped = true;
                }
            }

            if (swapped == false)
                break;
        }
    }
}
