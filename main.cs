using System;

class Program {
  public static void Main (string[] args) {
  string entrada;
    Double n1, n2, n3, resultado;
   
   
    Console.WriteLine("Digite a primeira nota");
    entrada = Console.ReadLine();
    n1 =  Double.Parse(entrada);
   
    Console.WriteLine ("Digite segunda nota");
    entrada = Console.ReadLine();
    n2 = Double.Parse(entrada);

    Console.WriteLine ("Digite terceira nota");
    entrada = Console.ReadLine();
    n3 = Double.Parse(entrada);
   
   resultado = (n1*2 +n2*3 +n3*5)/10;
    Console.WriteLine (resultado);

  }
}