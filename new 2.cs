 class calculator
 
 {
	 static void Main(string[] args)
	 {
		int a =10;
		int b =5;
		
		Console.WriteLine("hasil 10 + 5", a, b, penambahan (a,b));
		Console.WriteLine("hasil 10 - 5", a, b, pengurangan (a,b));
		
		Console.WriteLine("yaudahlah.......");
		Console.ReadKey();
	 }
	 static int penambahan (int a, int b)
	 {
		 return a + b;
	 }
	 	 static int Pengurangan (int a, int b)
	 {
		 return a - b;
	 }
 }