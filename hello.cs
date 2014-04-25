using System;

public static class Program{

  public static void Main(){

	Console.WriteLine("Hello");
	for(var i = 0; i < 10; i++){
		for(var j = 0; j < i; j++){Console.Write(" ");}
		Console.WriteLine(" in mono");
	}

        Console.WriteLine();
  }
}  
