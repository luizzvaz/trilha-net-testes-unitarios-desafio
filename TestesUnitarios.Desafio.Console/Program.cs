
using TestesUnitarios.Desafio.Console.Services;

ValidacoesLista ListaNumero = new ValidacoesLista();
List<int> lista = new List<int> { 5, -1, -8, 9 };
Console.WriteLine(lista == lista);
foreach (int item in ListaNumero.RemoverNumerosNegativos(lista))
{
  Console.WriteLine(item);
}
Console.WriteLine(ListaNumero.ListaContemDeterminadoNumero(lista, 10));
foreach (int item in ListaNumero.MultiplicarNumerosLista(lista, -2))
{
  Console.WriteLine(item);
}
Console.WriteLine(ListaNumero.RetornarMaiorNumeroLista(lista));
Console.WriteLine(ListaNumero.RetornarMenorNumeroLista(lista));

ValidacoesString TextoString = new ValidacoesString();
string Texto = "testando";
string conter1 = "ando";
string conter2 = "conter";
Console.WriteLine(TextoString.RetornarQuantidadeCaracteres(Texto));
Console.WriteLine(TextoString.ContemCaractere(Texto, conter1));
Console.WriteLine(TextoString.ContemCaractere(Texto, conter2));
Console.WriteLine(TextoString.TextoTerminaCom(Texto, conter1));
Console.WriteLine(TextoString.TextoTerminaCom(Texto, conter2));


// No TesteUnitarios.Desafio.Console.csproj e No TesteUnitarios.Desafio.Test.csproj
// eu alterei, pois não conseguir roda o programa, <TargetFramework>net8.0</TargetFramework>
// e rodou.