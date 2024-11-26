using VarosokDoga;

List<Nagyvaros> nagyvarosok = [];
using(var sr = new StreamReader(@"..\..\..\src\varosok.csv"))
{
	_ = sr.ReadLine();
    while (!sr.EndOfStream)
	{
		nagyvarosok.Add(new Nagyvaros(sr.ReadLine()));
    }
}
Console.WriteLine($"Kollekció hossza: {nagyvarosok.Count}");

//1. feladat
Console.WriteLine($"1. feladat: {nagyvarosok.Where(x=>x.Orszag == "Kína").Sum(y=>y.Nepesseg):.00}");

//2. feladat
Console.WriteLine($"2. feladat: {nagyvarosok.Where(x=>x.Orszag=="India").Average(y=>y.Nepesseg):.00}");

//3. feladat
Console.WriteLine($"3. feladat: {nagyvarosok.MaxBy(x=>x.Nepesseg).ToString()}");

// 4.feladat
var f4 = nagyvarosok.Where(x => x.Nepesseg > 20).OrderByDescending(y => y.Nepesseg);
Console.WriteLine($"4. feladat:");
foreach (var item in f4)
{
    Console.WriteLine(item.ToString());
}

//5. feladat
Console.WriteLine($"5. feladat: {nagyvarosok.GroupBy(x => x.Orszag).Count(y => y.Count() > 1)}");

//6. feladat
Console.WriteLine($"6. feladat: {nagyvarosok.GroupBy(x => x.Varos[0]).MaxBy(y => y.Count()).Key}");



