using System;

class Penjumlahan
{
    public T JumlahTigaAngka<T>(T a, T b, T c)
    {
        dynamic x = a;
        dynamic y = b;
        dynamic z = c;
        return x + y + z;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Penjumlahan p = new Penjumlahan();

        float hasil = p.JumlahTigaAngka<float>(10f, 30f, 82f);
        Console.WriteLine("Hasil penjumlahan: " + hasil);
        Console.ReadKey();
    }
}