Console.Clear();

double milhas;

Console.Write("Informe distância em milhas para ser convertida em KM: ");
milhas = Convert.ToInt32 (Console.ReadLine()); 

Console.WriteLine($"Nas medidas de KM ficará: {milhas*=1.609} ");