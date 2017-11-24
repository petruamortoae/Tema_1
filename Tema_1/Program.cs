using System;
public class SuneteDeAnimale
{
    public static void Main()
    {
        string[] listaAnimale = new string[5];

        listaAnimale[0] = "Cainele face ham";
        listaAnimale[1] = "Pisica face miau";
        listaAnimale[2] = "Oaia face bee";
        listaAnimale[3] = "Rata face mac-mac";
        listaAnimale[4] = "Ursul face mor-mor";

        Console.Write("\nAnimalele urmate de sunetele scoase de acestea sunt: ");
        foreach (string animal in listaAnimale)
        {
            Console.Write("\n{0}  ", animal);
        }
        Console.ReadLine();
    }
}