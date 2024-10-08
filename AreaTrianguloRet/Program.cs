Console.Clear();

double H,B,A;

Console.WriteLine("Vamos calcular a área de um triângulo retângulo");

Console.WriteLine("Infome a base...: ");
B = Convert.ToDouble (Console.ReadLine());


Console.WriteLine("Informe a altura...:");
H = Convert.ToDouble (Console.ReadLine());

A = B*H;

Console.WriteLine($"Base..: {B}");
Console.WriteLine($"Altura..: {H}");
Console.WriteLine($"Àrea..:{A/2}");