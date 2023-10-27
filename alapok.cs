using System;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");    // a writeline olyan mint egy pythonos print() a printelés utám sort emel
      Console.WriteLine("I am Learning C#");
      Console.WriteLine("It is fucking shit!");
      Console.WriteLine("pls kill me\nPython is better than this shit");
      Console.WriteLine(3 + 3);
      Console.WriteLine($"ez egy f string {12/2}");
      Console.Write("Hello World! ");
      Console.Write("I will print on the same line."); // a sima write egy fogykos print mert printelés után elfelejt sort emelni
      Console.WriteLine("___________________________________________");
      int szam = 69;
      double tizedes = 69.999999;
      float tizedes2 = 8.888888F;
      double big_szam = 14E3;
      float f1 = 35e3F;
      double d1 = 12E4D;
      char egykarakter = 'a';
      string nev = "VencelPanzer";
      bool vencel_buzi_e = true;
      long hosszu = 456546546456546564L;
      const float myNum = 3.14159F;   // a const beállitja hogy ennek a változonak mindig fix értéke legyen és ne tudjuk megváltoztatni
      Console.WriteLine($"ez egy integer: {szam}");
      Console.WriteLine($"ez egy double adattipus: {tizedes}");
      Console.WriteLine($"ez egy integer: {tizedes2}");
      Console.WriteLine($"ez egy char: {egykarakter}");
      Console.WriteLine($"ez egy név: {nev}");
      Console.WriteLine($"ez egy bool: {vencel_buzi_e}");
      Console.WriteLine($"ez egy hosszu long adattipus: {hosszu}");
      Console.WriteLine($"összeg {szam+tizedes2}");
      Console.WriteLine($"E használata: {big_szam}");
      Console.WriteLine($"E használata: {f1}");
      Console.WriteLine($"E használata: {d1}");
      
      
      
      
      
    }
  }
}

// egysoros komment


/*
EZ
EGY
kicseszett
több
soros
komment
kappa
VencelPanzer
UWU
*/
// int - stores integers (whole numbers), without decimals, such as 123 or -123
// double - stores floating point numbers, with decimals, such as 19.99 or -19.99
// char - stores single characters, such as 'a' or 'B'. Char values are surrounded by single quotes
// string - stores text, such as "Hello World". String values are surrounded by double quotes
// bool - stores values with two states: true or false


