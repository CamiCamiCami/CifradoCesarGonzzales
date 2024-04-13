using System;
using System.Text;


class Program {
  static string alfabeto = "abcdefghijklmñnopqrstuvwxyz";
  public static void Main(){
      Console.WriteLine("Ingrese la frase a cifrar");

      string msj = Console.ReadLine();
      while (string.IsNullOrEmpty(msj))
      {
          Console.WriteLine("Ingrese un mensaje no vacio");
          msj = Console.ReadLine();
      }
      Program program = new Program();  
      Console.WriteLine(Program.Cifrar(msj));
  }

  public static string Cifrar(string mensaje){
        int shift = 3;
        StringBuilder constructor = new StringBuilder();
        foreach(char c in mensaje){
            int i = Program.alfabeto.IndexOf(c);
            i += shift;
            i %= Program.alfabeto.Length;
            char char_cifrado = Program.alfabeto[i];
            constructor.Append(char_cifrado);
        }
        return constructor.ToString();
    }
}