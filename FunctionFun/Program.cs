static int Adder(int a, int b)
{
    int result = a + b;
    return result;
}



static long Adder2(int a, int b) => a + b;



int result = Adder(4, 7);
Console.WriteLine(result);

int a = 7;
int b = 8;
Console.WriteLine(Adder2(a, b));
Console.WriteLine(a);
