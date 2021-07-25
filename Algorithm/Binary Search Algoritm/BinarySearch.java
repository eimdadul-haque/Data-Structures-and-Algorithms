import java.util.Scanner;

/**
 * BinarySearch
 */
public class BinarySearch {
    static Scanner input = new Scanner(System.in);
    public static void main(String[] args) {
        int key = input.nextInt();
        int[] arr = {1,2,3,4,5,6,10,56,88};

        int result = Search(key, arr);
        if(result == -1){
            System.out.print("Not Found...");
        }
        else{
            System.out.print("Index number: "+result);
        }
       
    }

    public static int Search(int key, int[] list) {
        
        int low = 0;
        int hight = list.length - 1;

        while (low <= hight) {
            int mid = (low + hight) / 2;
            if (key == list[mid]) {
                return mid;
            }   

            if (key > list[mid]) {
                low = mid + 1;
            }
            else{
                hight = mid - 1;
            }
        }

        return -1;
    }
}