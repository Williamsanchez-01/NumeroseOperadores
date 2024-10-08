Console.Clear();

double lado1,lado2,lado3,semiperimetro,raiz,area;

Console.WriteLine("Calculando a área de um triangulo, de 3 medidas para calcularmos o semiperímetro e a área.");


Console.Write("Lado 1.: " );
lado1 = Convert.ToDouble(Console.ReadLine());


Console.Write("Lado 2..: ");
lado2 = Convert.ToDouble(Console.ReadLine());


Console.Write("Lado 3...: ");
lado3 = Convert.ToDouble(Console.ReadLine());

semiperimetro = (lado1+lado2+lado3)/2;

double D1 = semiperimetro-lado1;
double D2 = semiperimetro-lado2;
double D3 = semiperimetro-lado3;

raiz =  semiperimetro*D1*D2*D3;

area = Math.Sqrt(raiz);

Console.WriteLine();
Console.WriteLine($"Semiperímetro...: {semiperimetro}");
Console.WriteLine($"Área...........: {area:N2}");