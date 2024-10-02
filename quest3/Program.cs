/* Dado o tamanho do raio de uma circunferência, calcular a área e o perímetro da mesma */
Console.WriteLine("Insira o Raio da circunferencia para descobrir sua Area e seu Perimetro");

double Raio, Area, Perimetro;

Raio = Convert.ToDouble(Console.ReadLine());

Area = 3.14 * (Raio * Raio);
Perimetro = 2 * 3.14 * Raio;

Console.WriteLine("Area: "+Area);
Console.WriteLine("Perimetro: "+Perimetro);