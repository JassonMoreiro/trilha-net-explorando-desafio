using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
List<Pessoa> hospedes = new List<Pessoa>();
Pessoa p1 = new Pessoa(nome: "Jasson Hadryell");
Pessoa p2 = new Pessoa(nome: "Lavinia Orbolato");
Pessoa p3 = new Pessoa(nome: "Ana Clara");
Pessoa p4 = new Pessoa(nome: "João Vitor");

// Reserva para a suíte Premium com p1 e p2
List<Pessoa> hospedesPremium = new List<Pessoa> { p1, p2 };
Suite suitePremium = new Suite(tipoSuite: "Premium", capacidade: 2, valorDiaria: 30);
Reserva reservaPremium = new Reserva(diasReservados: 5);
reservaPremium.CadastrarSuite(suitePremium);
reservaPremium.CadastrarHospedes(hospedesPremium);

// Reserva para a suíte Master com p3
List<Pessoa> hospedesMaster = new List<Pessoa> { p3 };
Suite suiteMaster = new Suite(tipoSuite: "Master", capacidade: 5, valorDiaria: 80);
Reserva reservaMaster = new Reserva(diasReservados: 3);
reservaMaster.CadastrarSuite(suiteMaster);
reservaMaster.CadastrarHospedes(hospedesMaster);

List<Pessoa> hospedesPresidencial = new List<Pessoa> { p4 };
Suite suitePresidencial = new Suite(tipoSuite: "Presidencial", capacidade: 10, valorDiaria: 150);
Reserva reservaPresidencial = new Reserva(diasReservados: 7);
reservaPresidencial.CadastrarSuite(suitePresidencial);
reservaPresidencial.CadastrarHospedes(hospedesPresidencial);

Console.WriteLine($"Hóspedes na Suíte {reservaPremium.Suite.TipoSuite}");
foreach (var hospede in hospedesPremium)
{
    Console.WriteLine(hospede.Nome);
}
Console.WriteLine($"O valor de sua diária é {reservaPremium.CalcularValorDiaria()} R$, Volte Sempre!");

// Exibe a mensagem para a suíte Master
Console.WriteLine($"Hóspedes na Suíte {reservaMaster.Suite.TipoSuite}");
foreach (var hospede in hospedesMaster)
{
    Console.WriteLine(hospede.Nome);
}
Console.WriteLine($"O valor de sua diária é {reservaMaster.CalcularValorDiaria()} R$, Volte Sempre!");

// Exibe a mensagem para a suíte Presidencial
Console.WriteLine($"Hóspedes na Suíte {reservaPresidencial.Suite.TipoSuite}");
foreach (var hospede in hospedesPresidencial)
{
    Console.WriteLine(hospede.Nome);
}
Console.WriteLine($"O valor de sua diária é {reservaPresidencial.CalcularValorDiaria()} R$, Volte Sempre!");