using System;
using System.Collections.Generic;

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

class SimpleDataBase<T>
{
    private List<T> storedData;
    private List<DateTime> inputDates;

    public SimpleDataBase()
    {
        storedData = new List<T>();
        inputDates = new List<DateTime>();
    }

    public void AddNewData(T data)
    {
        storedData.Add(data);
        inputDates.Add(DateTime.UtcNow);
    }

    public void PrintAllData()
    {
        for (int i = 0; i < storedData.Count; i++)
        {
            Console.WriteLine($"Data {i + 1} berisi: {storedData[i]}, yang disimpan pada waktu UTC: {inputDates[i]}");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Penjumlahan p = new Penjumlahan();

        float hasil = p.JumlahTigaAngka<float>(10f, 30f, 82f);
        Console.WriteLine("Hasil penjumlahan: " + hasil);

        Console.WriteLine();

        SimpleDataBase<float> db = new SimpleDataBase<float>();
        db.AddNewData(10f);
        db.AddNewData(30f);
        db.AddNewData(82f);
        db.PrintAllData();

        Console.ReadKey();
    }
}