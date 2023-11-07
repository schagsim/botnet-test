public static class Kalkulacka
{
    public static void KalkulackaV5()
    {
        Console.WriteLine("Zadavejte cisla a operatory. Pokud budete chtit kalkulacku ukoncit, stisknete \"x\"");

        bool prevedeno1 = false;
        Console.WriteLine("Zadej cislo");
        string? zadaneCislo = Console.ReadLine() ?? "";
        double prevedeneCislo1 = 0;

        if (zadaneCislo.ToLower() == "x")
        {
            return;
        }
        prevedeno1 = double.TryParse(zadaneCislo, out prevedeneCislo1);

        while (prevedeno1 == false)
        {
            Console.WriteLine("Nezadal jsi platne cislo. Zadej spravne cislo.");
            zadaneCislo = Console.ReadLine() ?? "";
            if (zadaneCislo.ToLower() == "x")
            {
                return;
            }
            prevedeno1 = double.TryParse(zadaneCislo, out prevedeneCislo1);
        }

    }
}