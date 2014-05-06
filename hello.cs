using System;
using System.Linq;

public static class Program{

  public static void Main(){

	Console.WriteLine("Hello");
	for(var i = 0; i < 10; i++){
		for(var j = 0; j < i; j++){Console.Write(" ");}
		Console.WriteLine(" in mono");
	}

        Console.WriteLine();
  
	Console.WriteLine(" ---- and now linq ---- ");
	var items = new[]{
		"zenek", "arek",
		"franek", "marek",
		"damian", "darek",
		"kazek", "jarek"
	};

        Console.WriteLine(string.Format("total names : {0}", items.Count()));
	var names = items.Where(x=>x.EndsWith("rek"));
	foreach(var k in names){
		Console.WriteLine(k);
	}
    }
}  
