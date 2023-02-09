using System.Text;

class Program
{
    static void Main(string[] args)
    {
        int Count = int.Parse(Console.ReadLine());
        int[] arr = new int[Count];
        for (int i = 0; i < Count; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(arr);
        StringBuilder sb = new StringBuilder(string.Join("\n", arr));

        Console.WriteLine(sb);
    }
}