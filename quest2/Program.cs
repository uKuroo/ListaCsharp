/* Dado o tamanho do lado de um quadrado, calcular a área e o perímetro do mesmo*/
Console.WriteLine("Insira o tamanho do lado do Quadrado");

int lado, perimetro;

lado = Convert.ToInt32(Console.ReadLine());

perimetro = lado * 4;

Console.WriteLine("Perimetro: "+ perimetro);
