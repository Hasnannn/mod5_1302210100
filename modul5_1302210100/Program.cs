// See https://aka.ms/new-console-template for more information

using modul5_1302210100;

public class Program
{
    public static void Main(string[] args)
    {
        penjumlahan<long> penjumlahan = new penjumlahan<long>();
        penjumlahan.JumlahTigaAngka(13, 02, 21);

        SimpleDataBase<int> simpleDataBase = new SimpleDataBase<int>();
        simpleDataBase.addData(13, DateTime.Now);
        simpleDataBase.addData(02, DateTime.Now);
        simpleDataBase.addData(21, DateTime.Now);
        
        simpleDataBase.PrintAllData();
    }
}