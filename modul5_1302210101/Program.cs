// See https://aka.ms/new-console-template for more information
using modul5_1302210101;

Console.WriteLine("Jumlah 3 Angka: ");
Penjumlahan<float> jumlah = new Penjumlahan<float>();
float satu = 13;
float dua = 22;
float tiga = 10;
jumlah.JumlahTigaAngka(satu,dua,tiga);

Console.WriteLine(" ");
Console.WriteLine("Masukkan Data: ");
SimpleDataBase<string> database = new SimpleDataBase<string>();
database.AddNewData("Data 1");
database.AddNewData("Data 2");
database.AddNewData("Data 3");
database.printAllData();