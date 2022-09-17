Console.WriteLine("media a Aritmetica de 3 numeros:");

Console.WriteLine("digite seu primeiro número:");
double primeiro = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("digite seu primeiro número:");
double segundo = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("digite seu primeiro número:");
double terceiro = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("sua media e : ");
double media = (primeiro+segundo+terceiro)/3;
Console.Write($"{media:N1}");

