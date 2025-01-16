using System.Drawing;

internal class WorkWithDelegates
{
    delegate int MathOperation(int x, int y);

    Point[] points = { new Point(100, 200), new Point(150, 250), new Point(250, 375), new Point(275, 395), new Point(295, 450) };

    Predicate<Point> predicate = FindPoints;

    public void Run()
    {
        // Predicate
        //Point[] All = Array.FindAll(points, predicate);
        Point[] All = Array.FindAll(points, static x => x.X * x.Y > 50000); // the static is not necesary but prevents unintentional memory allocation -> micro-optimization

        foreach (var item in All)
        {
            Console.WriteLine(item);
        }

        // Func
        int d = 0;

        d = Calculate(2, 2, static (x, y) => x + y); // the static is not necesary
        Console.WriteLine(d);


        d = Calculate(8, 8, Add);
        Console.WriteLine(d);


        //MathOperation m = Add;
        Func<int, int, int> m = Add;
        //MathOperation m = (x, y) => x + y;
        m += Add;

        //d = m(3,3);

        d = Calculate(3, 3, m);
        Console.WriteLine(d);
    }
    //static int Calculate(int x, int y, MathOperation op)
    //{
    //    return op(x, y);
    //}

    static int Calculate(int x, int y, Func<int, int, int> op)
    {
        return op(x, y);
    }

    static int Add(int x, int y)
    {
        Console.WriteLine("Fun ++");
        return x + y;
    }

    static int Subtract(int x, int y)
    {
        Console.WriteLine("Fun --");
        return x - y;
    }

    static bool FindPoints(Point obj)
    {
        return obj.X * obj.Y > 100000;
    }
}

