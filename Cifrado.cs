using System;
using System.Text;


class Program {
    static string alfabeto = "abcdefghijklmñnopqrstuvwxyzABCDEFGHIJKLMNÑOPQRSTUVWXYZ1234567890_-+,#$%&/()=¿?¡!|,.;:{}[]";
    public static void Main() {
        Console.WriteLine("Ingrese la frase a cifrar");

        string frase = Console.ReadLine();
        while (!Program.FraseEsValida(frase))
        {
            frase = Console.ReadLine();
        }

        string frase_cifrada = Program.Cifrar(frase);
        Console.WriteLine(frase_cifrada);
        frase = Program.Decifrar(frase_cifrada);
        Console.WriteLine(frase);
    }

    private static bool FraseEsValida(string frase)
    {
        if (string.IsNullOrEmpty(frase))
        {
            Console.WriteLine("Frase Invalida - Frase Vacia");
            return false;
        }
        foreach (char c in frase)
        {
            if (!Program.alfabeto.Contains(c) && !(c == '\0' || c == '\n'))
            {
                Console.WriteLine("Frase Invalida - Caracter '" + c + "' no puede ser cifrado");
                return false;
            }
        }
        return true;
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