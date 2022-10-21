using System;

class Program {
  public static void Main (string[] args) {
    int print;
    Console.WriteLine("heads or tails");
    string b = Console.ReadLine();
    string[] dash = {"tails", "heads"};
    Random rd = new Random();
    print = rd.Next(0,1);
    Console.WriteLine(dash[print]);
    if(b == "head" && print == 1){
      Console.WriteLine("Correct");
      
    }
    if(b == "tails" && print == 0){
      Console.WriteLine("Correct");
      
    }
    
    if(b != "heads" && print == 1){
      Console.WriteLine("wrong");
      
    }
    if(b != "tails" && print == 0){
      Console.WriteLine("wrong");
      
    }
  }
}