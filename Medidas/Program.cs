Console.Clear();

double metros;

Console.WriteLine("Digite uma medida em metros para saber o equivalente em CM e KM"); 
metros = Convert.ToDouble (Console.ReadLine());

Console.WriteLine("--- Equivalência --");
Console.WriteLine($"{metros} m");
Console.WriteLine($"{metros*100} cm");
Console.WriteLine($"{metros/1000:N2} km");