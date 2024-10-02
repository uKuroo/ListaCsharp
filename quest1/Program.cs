/* Dado o tamanho da base e da altura de um retângulo, calcular a sua área e o seu
perímetro.*/
Console.WriteLine("Insira a Base e a Altura do Retangulo");

int Base, Altura, Area;

Base = Convert.ToInt32(Console.ReadLine());
Altura = Convert.ToInt32(Console.ReadLine());

Area = Base * Altura;

Console.WriteLine("Area: "+ Area);
