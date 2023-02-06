using System;

class Program {
  public static void Main (string[] args) {
    string maca;
      Double num1, valor;

  Console.WriteLine("Número de maças: ");
   maca = Console.ReadLine ();
   num1 = Double.Parse(maca);
  if (num1 > 12)
  { 
    valor = num1 * 1.0;
  }
   else
   { 
    valor = num1 * 1.3;
   }
    Console.WriteLine ("O custo total das maças é de : " + valor);
  }
}