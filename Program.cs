Console.Write("1.sınav notu gir: ");
int sınav1 = Convert.ToInt32(Console.ReadLine());

Console.Write("2.sınav notu gir:");
int sınav2 = Convert.ToInt32(Console.ReadLine());

decimal notOrtalaması = Convert.ToDecimal (sınav1+sınav2) / 2;
Console.WriteLine("not ortalaması: " +notOrtalaması);
Console.ReadKey();