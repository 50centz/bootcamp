public static class Infrastructure
{
    public static int[] CreateArray(this int size, int min = 0, int max = 50)
    {
        return Enumerable.Range(1, size).Select(item => Random.Shared.Next(min, max) ).ToArray();
    }

    public static int[] Print(this int[] array, string separator = ", ")
    {
        string output = String.Join(separator, array);
        Console.WriteLine($"{output}]");
        return array;
    }

    public static double Pow(this double a, double b)
    {
        return Math.Pow(a , b);
    }

     public static double Pow(this int a, double b)
    {
        return Math.Pow(a , b);
    }
}