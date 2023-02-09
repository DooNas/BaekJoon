class Program
{
    public static void Main()
    {
        List<string> alphabat = new List<string>{"ABC", "DEF", "GHI", "JKL", "MNO", "PQRS", "TUV", "WXYZ"};

        string input = Console.ReadLine();
        int sum = 0;
        foreach(char c in input){
            for(int i = 0; i < alphabat.Count; i++){
                if(alphabat[i].Contains(c)){
                    sum += i+3;
                }
            }
        }
        Console.WriteLine(sum);
    }
}