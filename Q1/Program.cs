﻿class Program {
    public static void Main(string[] args) {
        double n = double.Parse(Console.ReadLine());
        Console.WriteLine(f(n));
    }

    public static double f(double n) {
        if (n*n<=4) {return n=2;}
        else {return 1+f(n-(4*Math.Abs(n))/n);}
    }
}