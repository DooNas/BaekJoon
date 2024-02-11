namespace Solution {
  class Program {

    static int DecompositionSum(int num) {
      int sum = num;
      while (true) {
        if (num == 0) break ;

        sum += num % 10;
        num /= 10;
      }

      return sum;
    }

    static void Main(string[] args) {

      var n = int.Parse(Console.ReadLine()!);

      for (int i = 1; i < n; i++) {
        if (DecompositionSum(i) == n) {
          Console.WriteLine(i);
          return ;
        }
      }

      Console.WriteLine(0);

    }
  }
}