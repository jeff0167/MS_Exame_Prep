internal class WorkWithDelegates
{
    delegate int MathOperation(int x, int y);
    public void Run()
    {
        int d = 0;

        d = Do(2, 2, (x, y) => x + y);
        Console.WriteLine(d);


        d = Do(8, 8, Add);
        Console.WriteLine(d);
    }
    int Do(int x, int y, MathOperation op)
    {
        return op(x, y);
    }

    int Add(int x, int y)
    {
        return x + y;
    }
}

