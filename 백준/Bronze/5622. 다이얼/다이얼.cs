class Program
{
    public static void Main()
    {
        List<string> alphabat = new List<string>{"ABC", "DEF", "GHI", "JKL", "MNO", "PQRS", "TUV", "WXYZ"};
        List<int> time = new List<int>{3,4,5,6,7,8,9,10};

        string input = Console.ReadLine();
        int sum = 0;
        foreach(char c in input){
            for(int i = 0; i < alphabat.Count; i++){
                if(alphabat[i].Contains(c)){
                    sum += time[i];
                }
            }
        }
        Console.WriteLine(sum);
    }
}