
public class program
{
    public static void Main(string[] args)
    {
        var nums = new int[] { 2, 43, 24, 1, 345, 345, 1, 1433, 54, 4564, 6 };
        Console.WriteLine("Input: " + string.Join(", ", nums));
        Sort(nums, new int[nums.Length], 0, nums.Length - 1);
        Console.WriteLine("Output: " + string.Join(", ", nums));
    }


    public static void Sort(int[] array, int[] tempArray, int low, int height) 
    {
        if (low < height)
        {
            int mid = low + (height - low) / 2;
            Sort(array, tempArray, low, mid);
            Sort(array, tempArray, mid + 1, height);
            Marge(array, tempArray, low, mid, height);
        }
    }

    private static void Marge(int[] array, int[] tempArray, int low, int mid, int height)
    {
        for (int index = low; index <= height; index++)
            tempArray[index] = array[index];

        int i = low;
        int j = mid + 1;
        int k = low;

        while (i <= mid && j <= height)
        {
            if (tempArray[i] <= tempArray[j])
                array[k] = tempArray[i++];
            else
                array[k] = tempArray[j++];
            k++;
        }

        while (i <= mid)
        {
            array[k] = tempArray[i++];
            k++;
        }
    }
}
