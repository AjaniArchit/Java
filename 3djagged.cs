using System;
 class demo
 {
   static void Main(String[] args)
   {
      int [][][]a=new int[3][][];
	  a[0]=new int[3][];
	  a[1]=new int[2][];
	  a[2]=new int[4][];
	  
	  a[0]=new int[3][];
	  a[1]=new int[2][];
	  a[2]=new int[3][];
	  
	  a[1][0]=new int[3];
	  a[1][1]=new int[1];
	  
	  a[2][0]=new int[3];
	  a[2][0]=new int[2];
	  a[2][1]=new int[3];
	  a[2][2]=new int[3];
	  a[2][3]=new int[3];
	  
	  Console.WriteLine(a.Length); //di
	  Console.WriteLine(a.GetLength(0));
	  
	  Console.WriteLine(a[0].Length);
	  Console.WriteLine(a[1].Length);
	  Console.WriteLine(a[2].Length);
	  
	Console.WriteLine(a[0][0].Length);
	Console.WriteLine(a[1][1].Length);
	Console.WriteLine(a[2][3].Length);
	Console.WriteLine(a[0][0][0]);//element
	}
}	
