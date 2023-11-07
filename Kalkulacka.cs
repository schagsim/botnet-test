public static class Kalkulacka
{
    public static void KalkulackaV5()
    {
        Console.WriteLine("Zadavejte cisla a operatory. Pokud budete chtit kalkulacku ukoncit, stisknete \"x\"");

        bool prevedeno1 = false;
        Console.WriteLine("Zadej cislo");
        string zadaneCislo1 = Console.ReadLine() ?? "";
        double prevedeneCislo1 = 0;

        if (zadaneCislo1.ToLower() == "x")
        {
            return;
        }
        prevedeno1 = double.TryParse(zadaneCislo1, out prevedeneCislo1);

        while (prevedeno1 == false)
        {
            Console.WriteLine("Nezadal jsi platne cislo. Zadej spravne cislo.");
            zadaneCislo1 = Console.ReadLine() ?? "";
            if (zadaneCislo1.ToLower() == "x")
            {
                return;
            }
            prevedeno1 = double.TryParse(zadaneCislo1, out prevedeneCislo1);
        }

        double vysledek = prevedeneCislo1;
        string operatorVstup;
        bool prevedeno;
        string zadaneCislo;
        double prevedeneCislo;
        while (true)
        {
            double nynejsiVstup = vysledek;
            Console.WriteLine("Zadej operator");
            operatorVstup = Console.ReadLine() ?? "";
            if (operatorVstup.ToLower() == "x")
            {
                return;
            }
            
            while (operatorVstup != "+" && operatorVstup != "-" && operatorVstup != "*" && operatorVstup != "/" && operatorVstup != "ˆ")
            {
                Console.WriteLine("Zadal jsi spatny operator, zadej spravny");
                operatorVstup = Console.ReadLine() ?? "";
                if (operatorVstup == "x")
                {
                    return;
                }
            }

            Console.WriteLine("Zadej dalsi cislo");
            zadaneCislo = Console.ReadLine() ?? "";
            if (zadaneCislo.ToLower() == "x")
            {
                return;
            }
            prevedeno = double.TryParse(zadaneCislo, out prevedeneCislo);

            while (prevedeno == false)
            {
                Console.WriteLine("Nezdal jsi spravne cislo. Zadej znovu.");
                zadaneCislo = Console.ReadLine() ?? "";
                if (zadaneCislo.ToLower() == "x")
                {
                    return;
                }
                prevedeno = double.TryParse(zadaneCislo, out prevedeneCislo);
            }

            switch(operatorVstup)
            {
                case "*":
                    vysledek = vysledek * prevedeneCislo;
                    break;
                case "/":
                    if (prevedeneCislo == 0)
                    {
                        Console.WriteLine("Nelze delit nulout");
                    }
                    vysledek = vysledek / prevedeneCislo;
                    break;
                case "+":
                    vysledek = vysledek + prevedeneCislo;
                    break;
                case "-":
                    vysledek = vysledek - prevedeneCislo;
                    break;
                case "ˆ":
                    for (int i = 0; i < (int)prevedeneCislo; i++)
                    {
                        vysledek = vysledek * prevedeneCislo;
                    }
                    break;
                default:
                    Console.WriteLine("Neznamy operand");
                    break;
            }
            Console.WriteLine($"Vysledek: {nynejsiVstup} {operatorVstup} {prevedeneCislo} = {vysledek}");
        }

    }
}