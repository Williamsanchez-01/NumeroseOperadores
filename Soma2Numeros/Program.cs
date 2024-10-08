Console.Clear();
int n1, n2, soma; 

Console.WriteLine("Digite dois números para saber a soma entre eles.");

Console.Write("primeiro número: ");
n1 = Convert.ToInt32 (Console.ReadLine());

Console.Write("seguundo número: ");
n2 = Convert.ToInt32 (Console.ReadLine());

soma = n1+n2;

Console.WriteLine($"A soma desses dois números é : {soma}");

