/* Dado os três lados de um triângulo determinar o perímetro do mesmo */
Console.WriteLine("Insira o tamanho dos 3 lados do Triangulo para descobrir seu Perimetro");
double L1, L2, L3, Perimetro;

L1 = Convert.ToDouble(Console.ReadLine());
L2 = Convert.ToDouble(Console.ReadLine());
L3 = Convert.ToDouble(Console.ReadLine());

Perimetro = L1 + L2 + L3;

Console.WriteLine("Perimetro: "+Perimetro);
