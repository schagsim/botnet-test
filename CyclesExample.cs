static class ForCycleExample
{
    static void RunCycleExample()
    {
        for (float f = 1.94f; f < 5; f += 1)
        {
            Console.WriteLine(f);
        }

        float ff = 1.94f;
        while (ff < 5)
        {
            Console.WriteLine(ff);
            ff += 1.0f;
        }
    }

    static void RunGotoExample()
    {
        int val1 = 2;
        int val2 = 5;
        string @operator = "*"; // '@' is used to allow reserved words as variable names
        int result = 0;

        if (@operator == "*")
        {
            goto Multiply;
        }
        else if (@operator == "+")
        {
            goto Add;
        }
        else if (@operator == "-")
        {
            goto Subtract;
        }
        else if (@operator == "/")
        {
            goto Divide;
        }

        End:
            Console.WriteLine("Result: " + result);
            return; // Assuming this is part of a method, otherwise you would not use 'return' here.

        Multiply:
            result = val1 * val2;
            goto End;

        Add:
            result = val1 + val2;
            goto End;

        Subtract:
            result = val1 - val2;
            goto End;

        Divide:
            if (val2 != 0)
            {
                result = val1 / val2;
            }
            else
            {
                Console.WriteLine("Cannot divide by zero");
            }
            goto End;
    }
}
