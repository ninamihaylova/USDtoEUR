﻿class USDtoEUR
{
    static void Main(string[] args)

    {
        double dollar = double.Parse(Console.ReadLine());
        double euro = dollar * 0.88;
        Console.WriteLine($"{euro:F2}");

    }
}