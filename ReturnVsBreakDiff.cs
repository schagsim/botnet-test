public static class ReturnVsBreakDiff
{
    public static void RunReturnVsBreak(bool prerus, bool preskoc, bool vratSe)
    {
        Console.WriteLine("Zaciname test return vs break");

        Console.WriteLine("Prvni cyklus...");
        bool mamSePrerusit = false;
        bool mamSeVratit = false;
        for (int prvniCyklusIndex = 0; prvniCyklusIndex < 5; prvniCyklusIndex++)
        {
            if (prvniCyklusIndex == 3 && mamSePrerusit)
            {
                break;
            }
            Console.WriteLine($"Prvni for cyklus, index: {prvniCyklusIndex}");
            if (prvniCyklusIndex == 3 && mamSeVratit)
            {
                return;
            }
        }

        bool mamPreskocit = false;
        mamSeVratit = false;
        Console.WriteLine("Druhy cyklus...");
        for (int druhyCyklusIndex = 0; druhyCyklusIndex < 5; druhyCyklusIndex++)
        {
            if (druhyCyklusIndex == 3 && mamPreskocit)
            {
                continue;
            }
            Console.WriteLine($"Druhy for cyklus, index: {druhyCyklusIndex}");
            if (druhyCyklusIndex == 3 && mamSeVratit)
            {
                return;
            }
        }

    }
}