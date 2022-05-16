import java.util.Scanner;

public class Main {
    public static void main(String[] args){
        Scanner sc = new Scanner(System.in);
        int[] arr = new int[9];

        for (int index = 0; index < 9; index++){
            arr[index] = sc.nextInt();
        }
        int max = arr[0];
        int maxindex = 0;
        for (int index : arr) {
            if(max < index) max = index;
        }
        for (int index=0; index < arr.length; index++){
            if( max == arr[index]) maxindex = index + 1;
        }
        System.out.println(max);
        System.out.println(maxindex);
    }
}