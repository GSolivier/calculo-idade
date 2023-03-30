Console.Write($"Digite o seu nome: ");
string? nome = Console.ReadLine();

Console.Write("Digite o ano de seu nascimento: ");
int datau = int.Parse(Console.ReadLine());

var data = DateTime.Now;

var datas = (data.Year);

int idade = datas - datau;

int semana = idade * 52;

Console.WriteLine($"{nome}, voce tem {idade} anos de idade, e durante esse tempo, voce viveu durante {semana} semanas.");




