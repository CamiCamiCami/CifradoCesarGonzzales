using System;
using System.Text;


class Program {
    static string alfabeto = "abcdefghijklmñnopqrstuvwxyzABCDEFGHIJKLMNÑOPQRSTUVWXYZ1234567890_-+,#$%&/()=¿?¡!|,.;:{}[]";
    public static void Main() {
        Console.WriteLine("Ingrese la frase a cifrar");

        string msj = Console.ReadLine();
        while (string.IsNullOrEmpty(msj))
        {
            Console.WriteLine("Ingrese un mensaje no vacio");
            msj = Console.ReadLine();
        }
        Program program = new Program();

        string msj_cifrado = Program.Cifrar(msj);
        Console.WriteLine(msj_cifrado);
        string msj_decifrado = Program.Decifrar(msj_cifrado);
        Console.WriteLine(msj_decifrado);
    }

    public static string Cifrar(string mensaje) {
        int shift = 7;
        StringBuilder constructor = new StringBuilder();
        foreach (char c in mensaje) {
            int i = Program.alfabeto.IndexOf(c);
            i += shift;
            if (i < 0) { i += Program.alfabeto.Length; }
            i %= Program.alfabeto.Length;
            char char_cifrado = Program.alfabeto[i];
            constructor.Append(char_cifrado);
        }
        return constructor.ToString();
    }

    public static string Decifrar(string mensaje)
    {
        int shift = -7;
        StringBuilder constructor = new StringBuilder();
        foreach (char c in mensaje)
        {
            int i = Program.alfabeto.IndexOf(c);
            i += shift;
            if (i < 0) { i += Program.alfabeto.Length; }
            i %= Program.alfabeto.Length;
            char char_cifrado = Program.alfabeto[i];
            constructor.Append(char_cifrado);
        }
        return constructor.ToString();
    }

}